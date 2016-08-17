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
using System.Diagnostics;
using System.Windows.Forms;
using ICAL_Final.Managers;
using ICAL_Final.Resources;
using ICAL_Final.Database;
using ICAL_Final.Datalayer;
using ICAL_Final.Forms.Admin;
using ICAL_Final.Forms.Teacher;
using ICAL_Final.Forms.Student;
using ICAL_Final.Useful;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace ICAL_Final
{
    public partial class LoginForm : Form
    {
        private int idCurrentUser;
        private int timeOfFaceRecognition;
        private Timer timer;
        private Form nextForm;
        private Image<Bgr, byte> currentFrame;
        private Capture grabber;
        private ICALDatabaseDataSet.UsersRow[] users;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Checks if the input is valid
        /// </summary>
        /// <returns> The result of the check </returns>
        protected bool IsInputValid()
        {
            try
            {
                var username = usernameTextBox.Text;
                var password = passwordTextBox.Text;

                if (username.Length == 0)
                {
                    NotificationManager.LogException(Strings.AuthenticationFailed);
                    return false;
                }
                else if (password.Length == 0)
                {
                    NotificationManager.LogException(Strings.AuthenticationFailed);
                    return false;
                }

                return true;
            }
            catch
            {
                NotificationManager.LogException(Strings.AuthenticationFailed);
                return false;
            }
        }

        /// <summary>
        /// Refreshes the properties of the login controls after each attempt of authentification
        /// Toggles login steps visibility/ usability
        /// </summary>
        private void RefreshProperties()
        {
            loginButton.Enabled = (loginButton.Enabled) ? false : true;
            usernameTextBox.ReadOnly = (usernameTextBox.ReadOnly) ? false : true;
            passwordTextBox.ReadOnly = (passwordTextBox.ReadOnly) ? false : true;
            imageBoxFrameGrabber.Visible = (imageBoxFrameGrabber.Visible) ? false : true;
            startRecognitionButton.Visible = (startRecognitionButton.Visible) ? false : true;
        }

        /// <summary>
        ///  Attempts the first authentification if the method IsInputValid returns true
        /// </summary>
        /// <param name="sender"> The button responsible with serving the intent to login with the classic method(username&password) </param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                var username = usernameTextBox.Text;
                var password = EncryptionManager.Encrypt(passwordTextBox.Text);

                using (var userService = new UserService())
                {
                    users = userService.GetAfterUserAndPass(username, password);
                    if(users.Length < 1)
                    {
                        NotificationManager.LogException(Strings.AuthenticationFailed);
                    }
                    else
                    {                      
                            if(users[0].Type == 0 )
                            {
                                nextForm = new AdminMainForm(users[0]);
                                nextForm.Show();

                                Hide();
                            }
                            else if (users[0].Type == 1)
                            {
                                nextForm = new TeacherMainForm(users[0]);
                                nextForm.Show();

                                Hide();
                            }
                            else
                            {
                                NotificationManager.Alert(Strings.FirstAuthentificationSucceded);

                                idCurrentUser = users[0].Id;
                                RefreshProperties();
                            }                       
                    }
                }
                
            }
        }

        /// <summary>
        /// Opens the web camera and starts the timer for the second authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startRecognitionButton_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Sends an image taken with the web camera in every second 
        /// until the initialUser is recognised or the number of seconds reaches 30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeOfFaceRecognition++;

            if (timeOfFaceRecognition < 30)
            {
                currentFrame = grabber.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);

                var facialRecognition = new FacialRecognition(users[0]);

                var statusOfRecognition = facialRecognition.RecogniseStudent(currentFrame);
                if (statusOfRecognition == Strings.RecognitionSucceded)
                {
                    grabber.Dispose();

                    nextForm = new StudentMainForm(users[0]);
                    nextForm.Show();

                    Hide();

                    timer.Stop();
                }
                else
                {
                    messageLabel.Text = statusOfRecognition;
                }
            }
            else
            {
                NotificationManager.LogException(Strings.FaceRecognitionFailed);

                RefreshProperties();

                grabber.Dispose();

                timer.Stop();
            }
        }

        /// <summary>
        /// Opens the help file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: write that help system. The help.txt is still EMPTY.
            Process.Start("notepad.exe", Application.StartupPath + "/help.txt");
        }

    }
}
