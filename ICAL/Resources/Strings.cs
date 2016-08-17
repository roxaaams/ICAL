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

namespace ICAL_Final.Resources
{
    static class Strings
    {
        /// <summary>
        ///  Keeps all the strings which will be used in the app
        /// </summary>
        /// 
    
        public static string Title { get { return "ICAL - Intelligent Computer Assisted Learning"; } }
        public static string Version { get { return "1.0.0.0"; } }
       
        // Login form.
        public static string AuthenticationFailed { get { return "Invalid username or password."; } }
        public static string FaceRecognitionFailed { get { return "Could not recognition your face. Please try again."; } }
        public static string FirstAuthentificationSucceded { get { return "The first step of authentification went well. In order to go futher it is essential to start the face recognition"; } }
        public static string SecondAuthentificationSucceded { get { return "Connection succeded. Now you can start the learning process."; } }
        public static string MoreFaces { get { return "More than one person"; } }
        public static string NoFaces { get { return "No faces in the current frame"; } }
        public static string RecognitionSucceded { get { return "Recognition succeded"; } }
        public static string NotSamePerson { get { return "The person in the camera is not the same with the introduced username";  } }

        // Management
        public static string InvalidData { get { return "Invalid data."; } }
        public static string TakenUsername { get { return "The username is already taken. Please try again."; } }
        public static string SamePasswords { get { return "The old password and the new one are the same."; } }
        public static string DifferentPasswords { get { return "The passwords are not the same."; } }
        public static string UpdateError { get { return "Could not save your changes."; } }
        public static string AddNewUserError { get { return "Could not add a new user.";  } }
        public static string ConvertImageFailed { get { return "Could not convert the image into bytes array"; } }
        public static string DeleteConfirmation { get { return "Are you sure that you want to delete this?"; } }
        public static string DeleteSucces { get { return "The deletion was performed succesfully."; } }
        public static string ConfirmationTitle { get { return "Confirmation"; } }

        //OpenFileDialog
        public static string Filters { get { return "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|BMP files (*.bmp)|*.bmp"; } }
        public static string NewFace { get { return "Upload a picture with the face of the user"; } }
        public static string NewMood { get { return "Upload a new face"; } }
        public static string NewBlobTree { get { return "Upload a new blob tree"; } }
        public static string NewPictureForLesson { get { return "Upload a new picture for the lesson"; } }
        public static string NoFile { get { return "No uploaded file"; } }

        // Lesson Form
        public static string NotAllowedToGoFurther { get { return "You aren't allowed to take the tests in this situation."; } }

        //Psycological Test
        public static string SadMood { get { return "Oh, you seem really sad from your answers. Maybe you had a bad day or you actually didn't understand the lessons. We suggest you to repeat this chapter. "; } }
        public static string HappyMood { get { return "Awesome! It's obvious that you're in a great mood. Let's go to the tests."; } }
        public static string NoAnswer { get { return "We cannot know you better if you leave the box empty. :( So please write a number in the box. :) "; } }
        public static string NotSureAboutTheMood { get { return "Well done! We feel like we started to know you and that's really cool. :) Let's see one more drawing."; } }

        //Evaluation
        public static string WellDoneNextToHarderTest { get { return "Awesome! You passed the test! Let's try one harder this time."; } }
        public static string NotPassedHarderTest { get { return "Sadly, you didn't passed this harder test. Despite this, we think you're ready for the next chapter."; } }
        public static string PassedHardestTest { get { return "You passed the hardest test, MASTER! You're more than ready for the next chapter."; } }
        public static string WellDoneHarderTest { get { return "Awesome! You passed the test! Let's try the hardest now."; } }
        public static string NotPassedMediumTest { get { return "Ouch! This was a little bit too hard. But don't worry. The next test will be easier."; } }
        public static string NotPassedEasyTest { get { return "Ouch again! Sadly, you'll have to repeat this chapter."; } }
        public static string PassedEasyTest { get { return "Well done, but this test was just for fun. Now you'll have to repeat this chapter."; } }
    }
}
