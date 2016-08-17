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
using System.Windows.Forms;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.Student
{
    public partial class AboutStudentForm : Form
    {
        private int totalScore;
        private ICALDatabaseDataSet.UsersRow loggedUser;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="loggedUser"> Used to update the user who  is logged in and to show data about the total score and trophies </param>
        public AboutStudentForm(ICALDatabaseDataSet.UsersRow loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;
        }

        /// <summary>
        /// Shows the info of the user on the form
        /// Calculates the total score and shows the trophees if the user has any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutStudentForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = loggedUser.FirstName;
            lastNameTextBox.Text = loggedUser.LastName;

            using (var attendedChapterService = new AttendedChapterService())
            {
                var attendedChaptersByIdStudent = attendedChapterService.GetAfterIdStudent(loggedUser.Id);
                foreach (var attendedChapter in attendedChaptersByIdStudent)
                {
                    totalScore += attendedChapter.Score;
                }

                totalScoreTextBox.Text = totalScore.ToString();

                var numberOfAttentedChapters = attendedChapterService.ChaptersAttentedByIdStudent(loggedUser.Id);                
                if (numberOfAttentedChapters < 3)
                {
                    beginnerPictureBox.Image = Properties.Resources.gadge33;
                }
                else if (numberOfAttentedChapters == 3)
                {
                    beginnerPictureBox.Image = Properties.Resources.gadge33;
                    beginnerPictureBox.Image = Properties.Resources.gadge22;
                }
                else
                {
                    beginnerPictureBox.Image = Properties.Resources.gadge33;
                    beginnerPictureBox.Image = Properties.Resources.gadge22;
                    beginnerPictureBox.Image = Properties.Resources.gadge11;
                }

            }
        }

        /// <summary>
        /// Checks if the input is valid
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            foreach (var control in updateProfilePanel.Controls)
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
            }

            if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text)
            {
                    NotificationManager.LogException(Strings.DifferentPasswords);
                    return false;
            }
            else if (passwordTextBox.Text == newPasswordTextBox.Text)
            {
                NotificationManager.LogException(Strings.SamePasswords);
                return false;
            }
            else if (passwordTextBox.Text != EncryptionManager.Decrypt(loggedUser.Password))
            {
                NotificationManager.LogException(Strings.DifferentPasswords);
                return false;
            }

                return true;  
        }

        /// <summary>
        /// Updates the current user in the database if the method IsInputValid returns true
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of saving the changes in the database </param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var userService = new UserService())
                {
                    loggedUser.FirstName = firstNameTextBox.Text;
                    loggedUser.LastName = lastNameTextBox.Text;
                    loggedUser.Password = EncryptionManager.Encrypt(newPasswordTextBox.Text);

                    var saveInstance = userService.Update(loggedUser);
                    if (saveInstance == null)
                    {
                        NotificationManager.LogException(Strings.UpdateError);
                        return;
                    }
                }
            }
        }
    }
}
