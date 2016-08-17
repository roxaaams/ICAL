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
    public partial class BlobTreeEditForm : Form
    {
        private Action refreshCallback;
        private ICALDatabaseDataSet.PsychologicalQuestionsRow psychologicalQuestion;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="psychologicalQuestion"> Used to update the selected psychological question (aka blob tree) </param>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public BlobTreeEditForm(ICALDatabaseDataSet.PsychologicalQuestionsRow psychologicalQuestion, Action callBack = null)
        {
            InitializeComponent();

            this.psychologicalQuestion = psychologicalQuestion;
            refreshCallback = callBack;
        }

        /// <summary>
        ///  Shows the psychological question on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlobTreeEditForm_Load(object sender, EventArgs e)
        {
            idTextBox.Text = psychologicalQuestion.Id.ToString();
            blobTreePictureBox.Image = ImageManager.ConvertByteArrayToImage(psychologicalQuestion.Question);
        }

        /// <summary>
        /// Checks if the user uploaded an image(aka a blob tree)
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            if (blobTreePictureBox.Image == null)
            {
                NotificationManager.LogException(Strings.InvalidData);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Updates the current psycological question (aka blob tree) in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of saving the changes in the database </param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var psychologicalQuestionService = new PsychologicalQuestionService())
            {
                psychologicalQuestion.Question = ImageManager.ConvertImageToByteArray(blobTreePictureBox.Image, ImageFormat.Bmp);

                var saveInstance = psychologicalQuestionService.Update(psychologicalQuestion);
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

        /// <summary>
        ///  Verifies the user's intent, then deletes the blob tree from the database
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of deleting </param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogResult = NotificationManager.ConfirmationDelete(Strings.DeleteConfirmation);
            if (dialogResult)
            {
                using (var psychologicalQuestionService = new PsychologicalQuestionService())
                {
                    var saveInstance = psychologicalQuestionService.Delete(psychologicalQuestion.Id);
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

        /// <summary>
        /// Uploads a new drawing which contains a blob tree
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of uploading </param>
        /// <param name="e"></param>
        private void uploadNewBlobTreeButton_Click(object sender, EventArgs e)
        {
            var fileName = ImageManager.UploadImage(Strings.NewBlobTree);
            if (fileName != Strings.NoFile)
            {
                blobTreePictureBox.Image = new Bitmap(fileName);
            }
        }
    }
}
