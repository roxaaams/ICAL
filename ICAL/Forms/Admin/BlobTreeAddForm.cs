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
using ICAL_Final.Datalayer;
using ICAL_Final.Managers;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.Admin
{
    public partial class BlobTreeAddForm : Form
    {
        private Action refreshCallback;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public BlobTreeAddForm(Action callBack = null)
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
            if (blobTreePictureBox.Image == null)
            {
                NotificationManager.LogException(Strings.InvalidData);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates a new psychological question (aka blob tree) and inserts it in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of creating and inserting </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var psychologicalQuestionService = new PsychologicalQuestionService())
                {
                    var psychologicalQuestion = psychologicalQuestionService.CreateNewEntity();

                    psychologicalQuestion.Question = ImageManager.ConvertImageToByteArray(blobTreePictureBox.Image, ImageFormat.Bmp);

                    var saveInstance = psychologicalQuestionService.Insert(psychologicalQuestion);
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
        /// Uploads a new drawing which contains a blob tree
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of uploading </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
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
