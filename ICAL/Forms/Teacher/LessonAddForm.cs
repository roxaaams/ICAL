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

namespace ICAL_Final.Forms.Teacher
{
    public partial class LessonAddForm : Form
    {
        private Action refreshCallback;
        private ICALDatabaseDataSet.UsersRow loggedUser;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="loggedUser"> Used to know which user adds a new lesson </param>
        /// <param name="callBack"> Used to call a private method from another form </param>
        public LessonAddForm(ICALDatabaseDataSet.UsersRow loggedUser, Action callBack = null)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;
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
                else if (control is ComboBox)
                {
                    var input = (control as ComboBox).SelectedItem.ToString();
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
        /// Creates a new lesson and inserts it in the database if the method IsInputValid returns true
        /// and calls back the method from the main form
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of creating and inserting </param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                using (var lessonService = new LessonService())
                {
                    var lesson = lessonService.CreateNewEntity();

                    lesson.IdChapter = int.Parse(chapterComboBox.SelectedItem.ToString());
                    lesson.Title = titleTextBox.Text;
                    lesson.Lesson = lessonRichTextBox.Text;
                    lesson.CreatedByIdTeacher = loggedUser.Id;
                    lesson.UpdatedByIdTeacher = loggedUser.Id;
                    if (newPictureBox.Image != null)
                    {
                        lesson.Picture = ImageManager.ConvertImageToByteArray(newPictureBox.Image, ImageFormat.Bmp);
                    }

                    var saveInstance = lessonService.Insert(lesson);
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
        /// Uploads a new picture for the lesson
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of uploading </param>
        /// <param name="e"></param>
        private void uploadNewPictureButton_Click(object sender, EventArgs e)
        {
            var fileName = ImageManager.UploadImage(Strings.NewPictureForLesson);
            if (fileName != Strings.NoFile)
            {
                newPictureBox.Image = new Bitmap(fileName);
            }
        }
    }
}
