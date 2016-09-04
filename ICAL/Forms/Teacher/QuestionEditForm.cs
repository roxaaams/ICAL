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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.Teacher
{
    public partial class QuestionEditForm : Form
    {
        private Action refreshCallback;
        private ICALDatabaseDataSet.TestQuestionsRow testQuestion;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="testQuestion"> Used to update the selected test question </param>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public QuestionEditForm(ICALDatabaseDataSet.TestQuestionsRow testQuestion, Action callBack = null)
        {
            InitializeComponent();

            this.testQuestion = testQuestion;
            refreshCallback = callBack;
        }

        /// <summary>
        /// Shows the data about the question on the form
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void QuestionEditForm_Load(object sender, EventArgs e)
        {
            descriptionLabel.Text += testQuestion.Id.ToString();
            chapterComboBox.SelectedItem = testQuestion.IdChapter.ToString();
            levelComboBox.SelectedItem = testQuestion.Level.ToString();
            questionRichTextBox.Rtf = testQuestion.Question;
            firstAnswerTextBox.Text = testQuestion.FirstAnswer;
            secondAnswerTextBox.Text = testQuestion.SecondAnswer;
            thirdAnswerTextBox.Text = testQuestion.ThirdAnswer;

            foreach (var answerType in managementPanel.Controls.OfType<RadioButton>())
            {
                answerType.Checked = (answerType.Tag.ToString() == testQuestion.CorrectAnswer.ToString()) ? true : false;
                answerType.Text = (answerType.Checked) ? "Correct answer" : "Wrong answer";
                answerType.ForeColor = (answerType.Checked) ? Colors.greenColor : Colors.redColor;
            }
        }

        /// <summary>
        /// Checks if the input is valid
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            foreach (var control in managementPanel.Controls)
            {
                if (control is TextBox)
                {
                    var input = (control as TextBox).Text;
                    if (input.Length < 1)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
                else if (control is RichTextBox)
                {
                    var input = (control as RichTextBox).Text;
                    if (input.Length < 1)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
                else if(control is ComboBox)
                {
                    var input = (control as ComboBox).SelectedItem.ToString();
                    if(input.Length < 1)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        ///  Updates the current question in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of saving the changes in the database </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var testQuestionService = new TestQuestionService())
                {
                    testQuestion.IdChapter = int.Parse(chapterComboBox.SelectedItem.ToString());
                    testQuestion.Level = levelComboBox.SelectedItem.ToString();
                    testQuestion.Question = questionRichTextBox.Rtf;
                    testQuestion.FirstAnswer = firstAnswerTextBox.Text;
                    testQuestion.SecondAnswer = secondAnswerTextBox.Text;
                    testQuestion.ThirdAnswer = thirdAnswerTextBox.Text;
                    testQuestion.CorrectAnswer = (managementPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)).Tag.ToString();

                    var saveInstance = testQuestionService.Update(testQuestion);
                    if (saveInstance == null)
                    {
                        NotificationManager.LogException(Strings.UpdateError);
                        return;
                    }
                    else
                    {
                        if (refreshCallback != null)
                        {
                            refreshCallback();
                        }
                    }
                }
            }
        }

        /// <summary>
        ///  Verifies the user's intent, then deletes the question from the database
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of deleting </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = NotificationManager.ConfirmationDelete(Strings.DeleteConfirmation);
            if (dialogResult)
            {
                using (var testQuestionService = new TestQuestionService())
                {
                    var saveInstance = testQuestionService.Delete(testQuestion.Id);
                    if (saveInstance)
                    {
                        NotificationManager.Alert(Strings.DeleteSucces);
                        Close();
                    }
                    else
                    {
                        NotificationManager.Alert(Strings.UpdateError);
                    }
                }
            }
        }

        /// <summary>
        /// Changes the font of the selected text
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of changing the font </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void fontToolStripButton_Click(object sender, EventArgs e)
        {
            var font = LessonManager.SetFont(questionRichTextBox.SelectionFont);
            questionRichTextBox.SelectionFont = font;
        }

        /// <summary>
        ///  Changes the font style of the selected text
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of changing the font style </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void fontStyleToolStripButton_Click(object sender, EventArgs e)
        {
            var fontStyle = new FontStyle();
            var elementTag = (sender as ToolStripButton).Tag.ToString();
            switch (elementTag)
            {
                case "Bold": fontStyle = FontStyle.Bold; break;
                case "Italic": fontStyle = FontStyle.Italic; break;
                case "Underline": fontStyle = FontStyle.Underline; break;
                case "Strikeout": fontStyle = FontStyle.Strikeout; break;
            }

            if (questionRichTextBox.SelectionFont.Style.Equals(fontStyle))
            {
                try
                {
                    questionRichTextBox.SelectionFont = new Font(questionRichTextBox.SelectionFont, FontStyle.Regular);
                }
                catch (ArgumentException exception)
                {
                    NotificationManager.LogException(exception.ToString());
                }
            }
            else
            {
                try
                {
                    questionRichTextBox.SelectionFont = new Font(questionRichTextBox.SelectionFont, fontStyle);
                }
                catch (ArgumentException exception)
                {
                    NotificationManager.LogException(exception.ToString());
                }
            }
        }

        /// <summary>
        /// Changes the color of the selected text
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of changing the color </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void colorToolStripButton_Click(object sender, EventArgs e)
        {
            var color = LessonManager.SetColor();
            if (color != null)
            {
                var elementTag = (sender as ToolStripButton).Tag.ToString();
                switch (elementTag)
                {
                    case "Fore color": questionRichTextBox.SelectionColor = color; break;
                    case "Back color": questionRichTextBox.SelectionBackColor = color; break;
                }
            }
        }

        /// <summary>
        ///  Changes the align of the selected text
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of changing the align </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void alignToolStripButton_Click(object sender, EventArgs e)
        {
            var elementTag = (sender as ToolStripButton).Tag.ToString();
            switch (elementTag)
            {
                case "Left": questionRichTextBox.SelectionAlignment = HorizontalAlignment.Left; break;
                case "Center": questionRichTextBox.SelectionAlignment = HorizontalAlignment.Center; break;
                case "Right": questionRichTextBox.SelectionAlignment = HorizontalAlignment.Right; break;
            }
        }

        /// <summary>
        ///  Updates the correct answer
        /// </summary>
        /// <param name="sender"> The radio button which was checked </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void answersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var answerType in managementPanel.Controls.OfType<RadioButton>())
            {
                answerType.Text = (answerType.Checked) ? "Correct answer" : "Wrong answer";
                answerType.ForeColor = (answerType.Checked) ? Colors.greenColor : Colors.redColor;
            }
        }
    }
}
