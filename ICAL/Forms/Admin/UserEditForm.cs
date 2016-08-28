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

namespace ICAL_Final.Forms.Admin
{
    public partial class UserEditForm : Form
    {
        private Action refreshCallback;
        private ICALDatabaseDataSet.UsersRow user;

        /// <summary>
        ///  Initializes a new instance of the form
        /// </summary>
        /// <param name="user"> Used to update the selected user </param>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public UserEditForm(ICALDatabaseDataSet.UsersRow user, Action callBack = null)
        {
            InitializeComponent();

            this.user = user;
            refreshCallback = callBack;
        }

        /// <summary>
        ///  Shows the info about the current user on the form
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void UserEditForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = user.Id.ToString();
            firstNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
        }

        /// <summary>
        ///  Checks if the input is valid
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
            }

            return true;
        }

        /// <summary>
        /// Updates the current user in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of saving the changes in the database </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(IsInputValid())
            {
                using (var userService = new UserService())
                {
                    user.FirstName = firstNameTextBox.Text;
                    user.LastName = lastNameTextBox.Text;

                    var saveInstance = userService.Update(user);
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
        /// Verifies the user's intent, then deletes the user from the database
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of deleting </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = NotificationManager.ConfirmationDelete(Strings.DeleteConfirmation);
            if (dialogResult)
            {
                using (var userService = new UserService())
                {
                    using (var attendedChapterService = new AttendedChapterService())
                    {
                        var saveInstanceMinor = attendedChapterService.DeleteAllAfterIdStudent(user.Id);
                    }

                    var saveInstance = userService.Delete(user.Id);
                    if (saveInstance == true)
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
    }
}
