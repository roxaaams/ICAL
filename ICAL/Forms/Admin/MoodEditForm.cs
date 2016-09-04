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
using System.Windows.Forms;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.Admin
{
    public partial class MoodEditForm : Form
    {
        private Action refreshCallback;
        private ICALDatabaseDataSet.MoodsRow mood;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="mood"> Used to update the selected mood </param>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public MoodEditForm(ICALDatabaseDataSet.MoodsRow mood, Action callBack = null)
        {
            InitializeComponent();

            this.mood = mood;
            refreshCallback = callBack;
        }

        /// <summary>
        ///  Shows the mood on the form
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void MoodEditForm_Load(object sender, EventArgs e)
        {
            descriptionLabel.Text += mood.Id.ToString();
            moodComboBox.SelectedItem = mood.Name;
            facePictureBox.Image = ImageManager.ConvertByteArrayToImage(mood.Picture);
        }

        /// <summary>
        /// Checks if the input is valid
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            foreach (var control in managementPanel.Controls)
            {
                if (control is ComboBox)
                {
                    var input = (control as ComboBox).SelectedItem.ToString();
                    if (input.Length < 1)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
                else if (control is PictureBox)
                {
                    var pictureBox = control as PictureBox;
                    if (pictureBox.Image == null)
                    {
                        NotificationManager.LogException(Strings.InvalidData);
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        ///  Updates the current mood in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of saving the changes in the database </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var moodService = new MoodService())
                {
                    mood.Name = moodComboBox.SelectedItem.ToString();
                    mood.Picture = ImageManager.ConvertImageToByteArray(facePictureBox.Image, ImageFormat.Bmp);

                    var saveInstance = moodService.Update(mood);
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
        ///  Uploads a new face
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of uploading </param>
        /// <param name="e"></param>
        private void uploadNewFaceButton_Click(object sender, EventArgs e)
        {
            var fileName = ImageManager.UploadImage(Strings.NewMood);
            if (fileName != Strings.NoFile)
            {
                facePictureBox.Image = new Bitmap(fileName);
            }
        }

        /// <summary>
        /// Verifies the user's intent, then deletes the mood from the database
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of deleting </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = NotificationManager.ConfirmationDelete(Strings.DeleteConfirmation);
            if (dialogResult)
            {
                using (var moodService = new MoodService())
                {
                    var saveInstance = moodService.Delete(mood.Id);
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
    }
}
