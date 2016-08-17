/*
# Derived Work from the project "Multiple face detection and recognition in real time" written by Sergio Andrés Guitérrez Rojas 
*/

using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ICAL_Final.Managers;
using ICAL_Final.Database;
using ICAL_Final.Resources;

namespace ICAL_Final.Useful
{
    public class FacialRecognition
    {
        private string recognisedPerson;
        private HaarCascade face;
        private Image<Gray, byte> currentResult = null;
        private Image<Gray, byte> grayCurrentFrame = null;
        private MCvAvgComp[][] facesDetected;
        private List<Image<Gray, byte>> facesOfUsernames = new List<Image<Gray, byte>>();
        private List<string> usernames = new List<string>();
        private ICALDatabaseDataSet.UsersRow initialUser;

        /// <summary>
        /// Initiliazes a new instance of the class
        /// </summary>
        /// <param name="initialUser"> The user who passed the first step of the authentification </param>
        public FacialRecognition(ICALDatabaseDataSet.UsersRow initialUser)
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            this.initialUser = initialUser;

            Initialize();
        }

        /// <summary>
        ///  Initiliazes the list of the names and faces of the users
        /// </summary>
        private void Initialize()
        {
             usernames.Add(initialUser.Username);
             facesOfUsernames.Add(new Image<Gray, byte>(new Bitmap
                 (ImageManager.ConvertByteArrayToImage(initialUser.Face))));
        }

        /// <summary>
        /// Recognises if the initialUser is the same with the one in the currentFrame 
        /// and check if there is only one person in front of the camera
        /// </summary>
        /// <param name="currentFrame"> Represents the image of the user taken with the web camera </param>
        /// <returns> The result of the recognition </returns>
        public string RecogniseStudent(Image<Bgr, byte> currentFrame)
        {
            grayCurrentFrame = currentFrame.Convert<Gray, byte>();
            facesDetected = grayCurrentFrame.DetectHaarCascade(face, 1.2, 10, 
                HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            if (facesDetected[0].Length == 1)
            {
                currentResult = currentFrame.Copy(facesDetected[0][0].rect).Convert<Gray, byte>
                    ().Resize(100, 100, INTER.CV_INTER_CUBIC);

                var mCvTermCriteria = new MCvTermCriteria(0, 0.001);

                var eigenObjectRecognizer = new EigenObjectRecognizer(facesOfUsernames.ToArray(),
                     usernames.ToArray(), 3000, ref mCvTermCriteria);

                recognisedPerson = eigenObjectRecognizer.Recognize(currentResult);

                return (recognisedPerson == initialUser.Username) 
                    ? Strings.RecognitionSucceded : Strings.NotSamePerson;
            }
            else
            {
                return (facesDetected[0].Length > 1) ? Strings.MoreFaces : Strings.NoFaces;
            }

        }
    }
}
