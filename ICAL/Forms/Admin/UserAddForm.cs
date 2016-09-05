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
using System.Drawing.Imaging;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.Admin
{
    public partial class UserAddForm : Form
    {
        private Action refreshCallback;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public UserAddForm(Action callBack = null)
        {
            InitializeComponent();

            refreshCallback = callBack;
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
                else if (control is PictureBox)
                {
                    var pictureBox = control as PictureBox;
                    if (pictureBox.Image == null && studentRadioButton.Checked == true)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
            }

            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            using (var userService = new UserService())
            {
                var users = userService.GetAfterUser(username); 
                if(users != null)
                {
                    NotificationManager.LogException(Strings.TakenUsername);
                    return false;
                }
            }

            if (username == password)
            {
                NotificationManager.LogException(Strings.TakenUsername);
                return false;
            }

            var usernameRegex = @"^[a-zA-Z][a-zA-Z0-9_]{5,15}$";
            var matchUsername = new Regex(usernameRegex);
            if (!matchUsername.IsMatch(username))
            {
                NotificationManager.LogException(Strings.InvalidData);
                return false;
            }

            var passwordRegex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
            var matchPassword = new Regex(passwordRegex);
            if (!matchPassword.IsMatch(password))
            {
                NotificationManager.LogException(Strings.InvalidData);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates a new user and inserts it in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of creating and inserting </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var userService = new UserService())
                {
                    var user = userService.CreateNewEntity();

                    user.Username = usernameTextBox.Text;
                    user.Password = EncryptionManager.Encrypt(passwordTextBox.Text);
                    user.FirstName = firstNameTextBox.Text;
                    user.LastName = lastNameTextBox.Text;
                    if (facePictureBox.Image != null)
                    {
                        user.Face = ImageManager.ConvertImageToByteArray(facePictureBox.Image, ImageFormat.Bmp);
                    }

                    user.Type = int.Parse((managementPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)).Tag.ToString());

                    var saveInstance = userService.Insert(user);
                    if (saveInstance == null)
                    {
                        NotificationManager.LogException(Strings.AddNewUserError);
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
        ///  Uploads a new face of the user
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of uploading </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void uploadNewFaceButton_Click(object sender, EventArgs e)
        {
            var fileName = ImageManager.UploadImage(Strings.NewFace);
            if (fileName != Strings.NoFile)
            {
                facePictureBox.Image = new Bitmap(fileName);
            }
        }
    }
}
