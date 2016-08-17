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
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;

namespace ICAL_Final.Forms.Teacher
{
    public partial class TeacherMainForm : Form
    {
        private bool viewAll;
        private ICALDatabaseDataSet.UsersRow loggedUser;
        private ICALDatabaseDataSet.LessonsRow[] lessons;
        private ICALDatabaseDataSet.TestQuestionsRow[] testQuestions;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="loggedUser"> Represents the user who is logged in </param>
        public TeacherMainForm(ICALDatabaseDataSet.UsersRow loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;

            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.AutoGenerateColumns = true;
        }

        /// <summary>
        /// Refreshes the properties of some controls according to the user's choice of dataView
        /// </summary>
        private void RefreshProperties()
        {
            viewAll = (viewAll) ? false : true;

            foreach (var control in dashboardPanel.Controls)
            {
                if (control is Button)
                {
                    var button = control as Button;

                    button.Enabled = (button.Enabled) ? false : true;
                }
            } 
        }

        /// <summary>
        /// Refreshes the content of the dataView
        /// </summary>
        public void RefreshView()
        {
            if (viewAll == false)
            {
                using (var lessonService = new LessonService())
                {
                    lessons = lessonService.GetAll();

                    var viewModels = lessons.Select(s => new
                    {
                        Id = s.Id,
                        Chapter = s.IdChapter,
                        Title = s.Title,
                        CreatedBy = s.CreatedByIdTeacher,
                        UpdatedBy = s.UpdatedByIdTeacher,

                    }).ToArray();

                    dataView.DataSource = viewModels;
                }
            }
            else
            {
                using (var testQuestionService = new TestQuestionService())
                {
                    testQuestions = testQuestionService.GetAll();

                    var viewModels = testQuestions.Select(s => new
                    {
                        Id = s.Id,
                        Chapter = s.IdChapter,
                        Level = s.Level,
                        Question = s.Question
                    }).ToArray();

                    dataView.DataSource = viewModels;
                }
            }

            nameLabel.Text = "Hello, " + loggedUser.FirstName.ToString() + "!" + Environment.NewLine + "Edit Your Profile";
        }

        /// <summary>
        /// Every time when this form is shown, the view must be refreshed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherMainForm_Shown(object sender, EventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        /// Opens a EditForm according to the row selected if the number of rows is not null
        /// </summary>
        /// <param name="sender"> The row of the datView which was clicked twice </param>
        /// <param name="e"></param>
        private void dataView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataView.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedIndex = dataView.SelectedRows[0].Index;

            if (viewAll == false)
            {
                var selectedLesson = lessons[selectedIndex];

                new LessonEditForm(loggedUser, selectedLesson, RefreshView).ShowDialog();
            }
            else
            {
                var selectedTestQuestion = testQuestions[selectedIndex];

                new QuestionEditForm(selectedTestQuestion, RefreshView).ShowDialog();
            }
        }

        /// <summary>
        /// Changes the view of the dataView
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of showing the data </param>
        /// <param name="e"></param>
        private void viewDataButton_Click(object sender, EventArgs e)
        {
            RefreshProperties();
            RefreshView();
        }

        /// <summary>
        ///  Opens an AddForm according to the tag of sender
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of opening an AddForm </param>
        /// <param name="e"></param>
        private void addDataButton_Click(object sender, EventArgs e)
        {
            var addNewItemButton = sender as Button;
            var textOfAddNewItemButton = addNewItemButton.Text;

            if (textOfAddNewItemButton == "Add New Lesson")
            {
                new LessonAddForm(loggedUser, RefreshView).ShowDialog();
            }
            else
            {
                new QuestionAddForm(RefreshView).ShowDialog();
            }
        }

        /// <summary>
        /// Opens the profile of the current user 
        /// </summary>
        /// <param name="sender"> The label responsible with serving the intent of opening the AboutForm </param>
        /// <param name="e"></param>
        private void nameLabel_Click(object sender, EventArgs e)
        {
            new AboutTeacherForm(loggedUser).ShowDialog();
        }
    }
}                        
