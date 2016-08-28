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

namespace ICAL_Final.Forms.Student
{
    public partial class StudentMainForm : Form
    {
        private ICALDatabaseDataSet.UsersRow loggedUser;

        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        /// <param name="loggedUser"> Used to know the user who is logged in </param>
        public StudentMainForm(ICALDatabaseDataSet.UsersRow loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;
        }

        /// <summary>
        /// Every time the form is shown, the view must be refreshed
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void StudentMainForm_Shown(object sender, EventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        ///  Refreshes the view and makes the chapters enabled if it is possible
        /// </summary>
        private void RefreshView()
        {
            using (var attentedChapterService = new AttendedChapterService())
            {
                var numberOfAttendedChapters = attentedChapterService.ChaptersAttentedByIdStudent(loggedUser.Id);

                foreach (var control in Controls)
                {
                    if (control is Button)
                    {
                        var button = control as Button;
                        button.Enabled = ShouldEnable(button, numberOfAttendedChapters);
                    }
                }
            }

            nameLabel.Text = "Hello, " + loggedUser.FirstName.ToString() + "!" + Environment.NewLine + "Edit your account";
        }

        /// <summary>
        /// Checks if the chapters should be enabled 
        /// </summary>
        /// <param name="button"> The button which must be checked </param>
        /// <param name="numberOfAttendedChapters"> The number of attended chapters by the user who logged in </param>
        /// <returns> The result of the check </returns>
        private bool ShouldEnable(Button button, int numberOfAttendedChapters)
        {
            return int.Parse(button.Tag.ToString()) <= numberOfAttendedChapters + 1;
        }

        /// <summary>
        /// Opens the profile of the user
        /// </summary>
        /// <param name="sender"> The label responsible with serving the intent of opening the personal profile </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void nameLabel_Click(object sender, EventArgs e)
        {
            new AboutStudentForm(loggedUser).ShowDialog();
        }

        /// <summary>
        /// Opens a LessonForm for the selected chapter
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of viewing the chapter </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void viewChapterButton_Click(object sender, EventArgs e)
        {
            var seeChapterButton = sender as Button;
            var idChapter = int.Parse(seeChapterButton.Tag.ToString());

            new LessonForm(idChapter, loggedUser, RefreshView).ShowDialog();
        }
    }
}
