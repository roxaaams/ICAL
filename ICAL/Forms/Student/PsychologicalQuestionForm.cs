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
using System.Linq;
using System.Windows.Forms;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;
using ICAL_Final.Useful;

namespace ICAL_Final.Forms.Student
{
    public partial class PsychologicalQuestionForm : Form
    {
        private int sumOfEmotionsPhases;
        private Action positiveRefreshCallBack;
        private Action negativeRefreshCallBack;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="sumOfEmotionsPhases"> Used to know the mood </param>
        /// <param name="positiveCallBack"> Used for the positive sumOfEmotionsPhases </param>
        /// <param name="negativeCallBack"> Used for the negative sumOfEmotionsPhases </param>
        public PsychologicalQuestionForm(int sumOfEmotionsPhases, Action positiveCallBack = null, Action negativeCallBack = null)
        {
            InitializeComponent();

            this.sumOfEmotionsPhases = sumOfEmotionsPhases;
            positiveRefreshCallBack = positiveCallBack;
            negativeRefreshCallBack = negativeCallBack;
        }

        /// <summary>
        /// Shows a random chosen blob tree from the database
        /// </summary>
        private void RefreshView()
        {
            using (var psycolgicalQuestion = new PsychologicalQuestionService())
            {
                var psycolgicalQuestions = psycolgicalQuestion.GetAll();

                var randomNumbersGenerator = new RandomNumbersGenerator(1);
                var randomNumbers = randomNumbersGenerator.Generate(0, psycolgicalQuestions.Length - 1, 1);

                facePictureBox.Image = ImageManager.ConvertByteArrayToImage(psycolgicalQuestions[randomNumbers[0]].Question);
            }   
        }

        /// <summary>
        /// Checks if the input is valid
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            if (numberTextBox.Text == "")
            {
                NotificationManager.Alert(Strings.NoAnswer);
                return false;
            }

            return true;
        }

        /// <summary>
        ///  Calculates the total sum of emotions phases
        ///  The numbers 9 and 14 represent always "happiness" (the sum increases), respectively "sadness"(the sum decreases) , while the others are balanced in terms of emotions
        ///  If the sum is positive, calls back the method which takes the user to the tests
        ///  If it is null, retakes the psychological question
        ///  Else, revises the chapter again
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of confirmation </param>
        /// <param name="e"></param>
        private void confirmAnswerButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                var chosenNumber = int.Parse(numberTextBox.Text);
                if (chosenNumber == 9)
                {
                    sumOfEmotionsPhases++;
                }
                else if (chosenNumber == 14)
                {
                    sumOfEmotionsPhases--;
                }

                if (sumOfEmotionsPhases > 0)
                {
                    NotificationManager.Alert(Strings.HappyMood);
                    positiveRefreshCallBack();
                    Close();
                }
                else if (sumOfEmotionsPhases < 0)
                {
                    NotificationManager.Alert(Strings.SadMood);
                    negativeRefreshCallBack();
                    Close();
                }
                else
                {
                    NotificationManager.Alert(Strings.NotSureAboutTheMood);
                    RefreshView();
                }
            }
        }

        /// <summary>
        ///  Accepts only numbers and tab, because the blob tree contains only numbers
        ///  and makes the conversion from string to int easier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && e.KeyChar.Equals(Keys.Tab))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Doesn't let the first character of the textBox to be "0", because the numbers on the blob trees start always from 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBox.Text.StartsWith("0"))
            {
                numberTextBox.Text = new string(numberTextBox.Text.SkipWhile(c => c == '0').ToArray());
            }
        }

        /// <summary>
        /// Each time the form is loaded, the view must be refreshed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PsychologicalQuestionForm_Load(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
