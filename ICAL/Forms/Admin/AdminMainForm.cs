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
using ICAL_Final.Managers;

namespace ICAL_Final.Forms.Admin
{
    public partial class AdminMainForm : Form
    {
        private int viewAll;
        private ICALDatabaseDataSet.UsersRow loggedUser;
        private ICALDatabaseDataSet.UsersRow[] users;
        private ICALDatabaseDataSet.PsychologicalQuestionsRow[] psychologicalQuestions;
        private ICALDatabaseDataSet.MoodsRow[] moods;

        /// <summary>
        ///  Initializes a new instance of the form
        /// </summary>
        /// <param name="loggedUser"> Represents the user who is logged in </param>
        public AdminMainForm(ICALDatabaseDataSet.UsersRow loggedUser)
        {
            InitializeComponent();

            this.loggedUser = loggedUser;

            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.AutoGenerateColumns = true;
        }
 
        /// <summary>
        /// Refreshes the content of the dataView
        /// </summary>
        private void RefreshView()
        {
            if (viewAll == 0)
            {
                using (var userService = new UserService())
                {
                    users = userService.GetAll();

                    var viewModels = users.Select(s => new
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Username = s.Username,
                        Type = s.Type
                    }).ToArray();

                    dataView.DataSource = viewModels;
                }
            }
            else if (viewAll == 1)
            {
                using (var psychologicalQuestionService = new PsychologicalQuestionService())
                {
                    psychologicalQuestions = psychologicalQuestionService.GetAll();

                    var viewModels = psychologicalQuestions.Select(s => new
                    {
                        Id = s.Id,
                        Question = ImageManager.ConvertByteArrayToImage(s.Question),
                    }).ToArray();

                    dataView.DataSource = viewModels;
                } 
            }
            else
            {
                using (var moodService = new MoodService())
                {
                    moods = moodService.GetAll();

                    var viewModels = moods.Select(s => new
                    {
                        Id = s.Id,
                        Mood = s.Name,
                        Face = ImageManager.ConvertByteArrayToImage(s.Picture),
                    }).ToArray();

                    dataView.DataSource = viewModels;
                }
            }

            
        }

        /// <summary>
        /// Every time when this form is shown, the view must be refreshed
        /// </summary>
        /// <param name="sender"> The sender of the event </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void AdminMainForm_Shown(object sender, EventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        /// Opens a EditForm according to the row selected if the number of rows is not null
        /// </summary>
        /// <param name="sender"> The row of the datView which was clicked twice </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void dataView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataView.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedIndex = dataView.SelectedRows[0].Index;

            if (viewAll == 0)
            {
                var selectedUser = users[selectedIndex];

                new UserEditForm(selectedUser, RefreshView).ShowDialog();
            }
            else if (viewAll == 1)
            {
                var selectedQuestion = psychologicalQuestions[selectedIndex];

                new BlobTreeEditForm(selectedQuestion, RefreshView).ShowDialog();
                
            }
            else
            {
                var selectedMood = moods[selectedIndex];

                new MoodEditForm(selectedMood, RefreshView).ShowDialog();
            }
        }

        /// <summary>
        /// Changes the view of the dataView
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of showing the data </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void viewDataButton_Click(object sender, EventArgs e)
        {
            var viewDataButton = sender as Button;

            viewAll = int.Parse(viewDataButton.Tag.ToString());

            RefreshView();
        }

        /// <summary>
        /// Opens an AddForm according to the tag of sender
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent of opening an AddForm </param>
        /// <param name="e"> The <see cref="EventArgs"/> instance containing the event data </param>
        private void addDataButton_Click(object sender, EventArgs e)
        {
            var addDataButton = sender as Button;
            var tagOfAddDataButton = int.Parse(addDataButton.Tag.ToString());

            if (tagOfAddDataButton == 0)
            {
                new UserAddForm(RefreshView).ShowDialog();
            }
            else if (tagOfAddDataButton == 1)
            {
                new BlobTreeAddForm(RefreshView).ShowDialog();
            }
            else
            {
                new MoodAddForm(RefreshView).ShowDialog();
            }
        }
    }
}
