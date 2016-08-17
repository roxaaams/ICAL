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
using ICAL_Final.Useful;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace ICAL_Final.Forms.Student
{
    public partial class LessonForm : Form
    {
        private int idChapter;
        private int indexOfLesson = 0;
        private int sumOfEmotionsPhases;
        private Image<Bgr, byte> currentFrame;
        private Capture grabber;
        private Action refreshCallBack;
        private ICALDatabaseDataSet.LessonsRow[] lessons;
        private ICALDatabaseDataSet.UsersRow loggedUser;

        /// <summary>
        /// Initiliazes a new instance of the form
        /// </summary>
        /// <param name="idChapter"> Used to know which chapter will be shown </param>
        /// <param name="loggedUser"> Used to check whether the person who will take the evaluation is the same with the one who logged or not </param>
        /// <param name="callBack"> Used to call a private method from another form</param>
        public LessonForm(int idChapter, ICALDatabaseDataSet.UsersRow loggedUser, Action callBack = null)
        {
            InitializeComponent();

            this.idChapter = idChapter;
            this.loggedUser = loggedUser;
            refreshCallBack = callBack;

            Initialize();
        }

        /// <summary>
        /// Shows the lessons on the form
        /// </summary>
        private void Initialize()
        {
            chapterLabel.Text = "CHAPTER " + idChapter.ToString();

            sumOfEmotionsPhases = 0;

            using (var lessonService = new LessonService())
            {
                lessons = lessonService.GetAfterChapter(idChapter);

                lessonTextBox.Text = lessons[0].Lesson;
                if (lessons[0].Picture != null)
                {
                    lessonPictureBox.Image = ImageManager.ConvertByteArrayToImage(lessons[0].Picture);
                }

                foreach (var lesson in lessons)
                {
                    lessonsListBox.Items.Add(lesson.Title);
                }

                lessonsListBox.SelectedIndex = indexOfLesson;
            }

        }

        /// <summary>
        /// Checks if the user in front of the camera is the same with the one who is logged in
        /// if the result is positive, detects the mood from the same image taken by the web camera and takes the user to the psycological question
        /// else, informs the user as to why he/she cannot go any further with the evaluation
        /// </summary>
        private void FaceAndMoodRecognition()                               
        {
            grabber = new Capture();
            grabber.QueryFrame();

            currentFrame = grabber.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);

            var facialRecognition = new FacialRecognition(loggedUser);

            var statusOfRecognition = facialRecognition.RecogniseStudent(currentFrame);
            if (statusOfRecognition == Strings.RecognitionSucceded)
            {
                var moodRecognition = new MoodRecognition();

                var mood = moodRecognition.RecogniseMood(currentFrame);
                sumOfEmotionsPhases = (mood == "happy") ? (sumOfEmotionsPhases + 1) : (sumOfEmotionsPhases - 1);

                grabber.Dispose();

                new PsychologicalQuestionForm(sumOfEmotionsPhases, GoToTheEvaluation, Initialize).ShowDialog();
            }
            else
            {
                NotificationManager.Alert(statusOfRecognition + " " + Strings.NotAllowedToGoFurther);
            }
            
        }

        /// <summary>
        /// Takes the user to the evaluation form
        /// </summary>
        private void GoToTheEvaluation()
        {
            new TestQuestionForm(idChapter, loggedUser, refreshCallBack).ShowDialog();
            Close();
        }

        /// <summary>
        ///  Shows the next lesson and if the user is at the last lesson, verifies if the same person is still in front of the webcam
        /// </summary>
        /// <param name="sender"> The button responsible with serving the main intent of showing the next lesson </param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (indexOfLesson < lessons.Length - 1)
            {
                indexOfLesson++;

                lessonTextBox.Text = lessons[indexOfLesson].Lesson;
                if (lessons[indexOfLesson].Picture != null)
                {
                    lessonPictureBox.Image = ImageManager.ConvertByteArrayToImage(lessons[indexOfLesson].Picture);
                }

                if (indexOfLesson == lessons.Length - 1)
                {
                    nextButton.Text = "Evaluation";
                }

                lessonsListBox.SelectedIndex = indexOfLesson;
                previousButton.Enabled = true;
            }
            else
            {
                FaceAndMoodRecognition();
            }
        }

        /// <summary>
        ///  Shows the previous lesson
        /// </summary>
        /// <param name="sender"> The button responsible with serving the main intent of showing the previous lesson </param>
        /// <param name="e"></param>
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (indexOfLesson > 0)
            { 
                indexOfLesson--;

                lessonTextBox.Text = lessons[indexOfLesson].Lesson;
                if (lessons[indexOfLesson].Picture != null)
                {
                    lessonPictureBox.Image = ImageManager.ConvertByteArrayToImage(lessons[indexOfLesson].Picture);
                }

                lessonsListBox.SelectedIndex = indexOfLesson;
                nextButton.Text = "Next Lesson";
            }   
            else
            {
                previousButton.Enabled = false;
            }
              
        }

        /// <summary>
        /// Changes the lesson according to the selected item from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lessonsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexOfLesson = lessonsListBox.SelectedIndex;

            lessonTextBox.Text = lessons[indexOfLesson].Lesson;
            if (lessons[indexOfLesson].Picture != null)
            {
                lessonPictureBox.Image = ImageManager.ConvertByteArrayToImage(lessons[indexOfLesson].Picture);
            }

            if (indexOfLesson == 0)
            {
                previousButton.Enabled = false;
            }
            else if (indexOfLesson == lessons.Length - 1)
            {
                nextButton.Text = "Evaluation";
                previousButton.Enabled = true;
            }
        }
    }
}
