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
        private int idChapter;
        private string level = "medium";
        private Action refreshCallback;
        private List<int> randomNumbers;
        private List<int> wrongAnswers = new List<int>();
        private ICALDatabaseDataSet.TestQuestionsRow[] questions;
        private ICALDatabaseDataSet.UsersRow loggedUser;

        /// <summary>
        /// Initiliazes a new instance of the form
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
        }

        /// <summary>
        /// Every time the form is shown, the view must be refreshed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestQuestionForm_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        /// Generates a list of random numbers for the questions
        /// </summary>
        private void RefreshView()
        {
            using (var testQuestion = new TestQuestionService())
            {
                questions = testQuestion.GetAfterChapterAndLevel(idChapter, level);

                var randomNumbersGenerator = new RandomNumbersGenerator(1);
                randomNumbers = randomNumbersGenerator.Generate(0, questions.Length - 1, 3);

                ShowQuestions(); 
            }
        }

        /// <summary>
        /// Shows the randomised questions on the form
        /// </summary>
        private void ShowQuestions()
        {
            correctAnswersTextBox.Text = "";

            foreach (var control in questionsPanel.Controls)
            {
                if (control is Panel)
                {
                    var panel = control as Panel;
                    var questionNumber = int.Parse(panel.Tag.ToString());

                    foreach (var childControl in panel.Controls)
                    {
                        if (childControl is TextBox)
                        {
                            var questionTextBox = childControl as TextBox;

                            questionTextBox.Text = questions[randomNumbers[questionNumber]].Question;
                        }
                        else
                        {
                            var answerRadioButton = childControl as RadioButton;
                            var tagOfAnswerRadioButton = answerRadioButton.Tag.ToString();
                            if (tagOfAnswerRadioButton == "a)")
                            {
                                answerRadioButton.Text = questions[randomNumbers[questionNumber]].FirstAnswer;
                            }
                            else if (tagOfAnswerRadioButton == "b)")
                            {
                                answerRadioButton.Text = questions[randomNumbers[questionNumber]].SecondAnswer;
                            }
                            else
                            {
                                answerRadioButton.Text = questions[randomNumbers[questionNumber]].ThirdAnswer;
                            }  
                        }
                    }
                }
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
        /// Calculates the score per test and updates the list of wrong answers
        /// </summary>
        /// <returns> The result </returns>
        private int ScorePerTest()
        {
            int score = 0;

            foreach (var control in questionsPanel.Controls)
            {
                if (control is Panel)
                {
                    var panel = control as Panel;
                    var questionNumber = int.Parse(panel.Tag.ToString());

                    var correctAnswer = questions[randomNumbers[questionNumber]].CorrectAnswer;
                    var chosenAnswer = panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                    if (chosenAnswer == correctAnswer)
                    {
                        score++;
                    }
                    else
                    {
                        wrongAnswers.Add(questionNumber);
                    }
                }
            }

            return score;
        }

        /// <summary>
        /// Shows the correct answers to the questions where the user has not answered correctly
        /// </summary>
        private void ShowCorrectAnswers()
        {
            string correctedAnswers = "";
            foreach (var wrongAnswer in wrongAnswers)
            {
                correctedAnswers += "Question " + wrongAnswer.ToString() + "The correct answer is " + questions[randomNumbers[wrongAnswer]].CorrectAnswer.ToString() + Environment.NewLine;
            }

            correctAnswersTextBox.Text = correctedAnswers;
        }

        /// <summary>
        /// According to the result of the test, goes further with the evaluation or back to the chapter to revise it
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of submiting the answers </param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            var score = ScorePerTest();          
            if (score == 3)
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
                ShowCorrectAnswers();

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
    }
}
