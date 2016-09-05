/* Copyright 2015-2016 Roxana Teodora Mafteiu-Scai, Diana Fabiola Popa
#
# This file is part of ICAL - Intelligent Computer Assisted Learning.
#
# ICAL - Intelligent Computer Assisted Learning is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# ICAL - Intelligent Computer Assisted Learning is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with ICAL - Intelligent Computer Assisted Learning.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;
using ICAL_Final.Useful;

namespace ICAL_Final.Forms.Student
{
    public partial class TestQuestionForm : Form
    {
        private int indexOfQuestion = 0;
        private int scorePerTest = 0;
        private int idChapter;
        private string level = "medium";
        private List<int> randomNumbers;
        private ICALDatabaseDataSet.TestQuestionsRow[] questions;

        private Action refreshCallback;
        private ICALDatabaseDataSet.UsersRow loggedUser;

        private RandomNumbersGenerator randomNumbersGenerator;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="idChapter"> Used to know the selected chapter for evaluation </param>
        /// <param name="loggedUser"> used to know the user who is logged in </param>
        /// <param name="callBack"> Used to call back a method from the main form </param>
        public TestQuestionForm(int idChapter, ICALDatabaseDataSet.UsersRow loggedUser, Action callBack = null)
        {
            InitializeComponent();

            this.idChapter = idChapter;
            this.loggedUser = loggedUser;
            refreshCallback = callBack;

            randomNumbersGenerator = new RandomNumbersGenerator(1);
        }

        /// <summary>
        /// Every time the form is shown, the view must be refreshed
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void TestQuestionForm_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        /// Generates a list of random numbers for the questions
        /// </summary>
        private void RefreshView()
        {
            scorePerTestLabel.Text = "";
            descriptionLabel.Text = string.Format(Strings.Level, level);
            nextButton.Text = "Next Question";

            indexOfQuestion = 0;
            scorePerTest = 0;

            using (var testQuestion = new TestQuestionService())
            {
                questions = testQuestion.GetAfterChapterAndLevel(idChapter, level);
                randomNumbers = randomNumbersGenerator.Generate(0, questions.Length - 1, 3);

                ShowQuestion(); 
            }
        }

        /// <summary>
        /// Shows the randomised question on the form
        /// </summary>
        private void ShowQuestion()
        {
            questionLabel.Text = "Question " + indexOfQuestion.ToString();
            questionRichTextBox.Rtf = questions[randomNumbers[indexOfQuestion]].Question;
            firstAnswerRadioButton.Text = questions[randomNumbers[indexOfQuestion]].FirstAnswer;
            secondAnswerRadioButton.Text = questions[randomNumbers[indexOfQuestion]].SecondAnswer;
            thirdAnswerRadioButton.Text = questions[randomNumbers[indexOfQuestion]].ThirdAnswer;

            foreach (var answerRadioButton in questionPanel.Controls.OfType<RadioButton>())
            {
                answerRadioButton.Enabled = true;
                answerRadioButton.Checked = false;
                answerRadioButton.ForeColor = Color.WhiteSmoke;
            }
        }

        /// <summary>
        /// Updates the score (3 points for the whole test) in the database
        /// and if it is the first time when the user attented this test, creates a new entity and inserts it in the database
        /// </summary>
        private void UpdateScoreInDatabase()
        {
            using (var attendedChapterService = new AttendedChapterService())
            {
                var attendedThisChapter = attendedChapterService.GetAfterIdChapterAndIdStudent(idChapter, loggedUser.Id);
                if (attendedThisChapter == null)
                {
                    var newChapter = attendedChapterService.CreateNewEntity();

                    newChapter.IdChapter = idChapter;
                    newChapter.IdStudent = loggedUser.Id;
                    newChapter.Score = 3;

                    attendedChapterService.Insert(newChapter);
                }
                else
                {
                    attendedThisChapter[0].Score += 3;   

                    var saveInstance = attendedChapterService.Update(attendedThisChapter[0]);
                    if (saveInstance == null)
                    {
                        NotificationManager.Alert(Strings.UpdateError);
                    }
                }
            }
        }

        /// <summary>
        /// Checks the answers
        /// </summary>
        /// <param name="sender"> The sender which was checked </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void answerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var correctAnswer = questions[randomNumbers[indexOfQuestion]].CorrectAnswer;

            foreach (var answerRadioButton in questionPanel.Controls.OfType<RadioButton>())
            {
                answerRadioButton.Enabled = false;

                var tagOfAnswer = answerRadioButton.Tag.ToString();
                if (tagOfAnswer == correctAnswer)
                {
                    answerRadioButton.ForeColor = Colors.greenColor;
                    scorePerTest++;
                    scorePerTestLabel.Text = string.Format("Correct answers: ", scorePerTest.ToString(), "/3");
                }
                else
                {
                    answerRadioButton.ForeColor = Colors.redColor;
                } 
            }

            if (indexOfQuestion == questions.Length - 1)
            {
                nextButton.Text = "Attempt the next test";
            }

            nextButton.Visible = true;
        }

        /// <summary>
        ///  Advances the test state
        /// </summary>
        /// <param name="sender"> The button responsible with serving the main intent of advancinf the test state </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (indexOfQuestion < questions.Length - 1)
            {
                indexOfQuestion++;

                ShowQuestion();
            }
            else
            {
                if (scorePerTest == 3)
                {
                    if (level == "medium")
                    {
                        level = "hard";
                        NotificationManager.Alert(Strings.WellDoneNextToHarderTest);
                        UpdateScoreInDatabase();
                        RefreshView();
                    }
                    else if (level == "hard")
                    {
                        level = "very hard";
                        NotificationManager.Alert(Strings.WellDoneHarderTest);
                        UpdateScoreInDatabase();
                        RefreshView();
                    }
                    else if (level == "very hard")
                    {
                        NotificationManager.Alert(Strings.PassedHardestTest);
                        UpdateScoreInDatabase();
                    }
                    else
                    {
                        NotificationManager.Alert(Strings.PassedEasyTest);
                        refreshCallback();
                    }
                }
                else
                {
                    if (level == "medium")
                    {
                        level = "easy";
                        NotificationManager.Alert(Strings.NotPassedMediumTest);
                        RefreshView();
                    }
                    else if (level == "hard" || level == "very hard")
                    {
                        NotificationManager.Alert(Strings.NotPassedHarderTest);
                        refreshCallback();
                        Close();
                    }
                    else
                    {
                        NotificationManager.Alert(Strings.NotPassedEasyTest);
                        refreshCallback();
                        Close();
                    }
                }
            }

            nextButton.Visible = false;
        }
    }
}
