/*
# Derived Work from the project "Multiple face detection and recognition in real time" written by Sergio Andrés Guitérrez Rojas 
*/

using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using ICAL_Final.Managers;
using ICAL_Final.Datalayer;

namespace ICAL_Final.Useful
{
    public class MoodRecognition
    {
        private HaarCascade face;
        private Image<Gray, byte> currentResult = null;
        private Image<Gray, byte> grayCurrentFrame = null;
        private MCvAvgComp[][] facesDetected;
        private List<Image<Gray, byte>> moodsPeople = new List<Image<Gray, byte>>();
        private List<string> moods = new List<string>();
        private string recognisedMood;

        /// <summary>
        /// Initiliazes a new instance of the class
        /// </summary>
        public MoodRecognition()
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            Initialize();
        }

        /// <summary>
        ///  Initiliazes the list of the names and pictures of the moods
        /// </summary>
        private void Initialize()
        {
            using (var moodService = new MoodService())
            {
                var allMoods = moodService.GetAll();
                foreach (var mood in allMoods)
                {
                    moods.Add(mood.Name);
                    moodsPeople.Add(new Image<Gray, byte>(new Bitmap
                     (ImageManager.ConvertByteArrayToImage(mood.Picture))));
                }
            }  
        }

        /// <summary>
        ///  Recognise the mood(happy or sad)
        /// </summary>
        /// <param name="currentFrame"> Represents the image of the user taken with the web camera </param>
        /// <returns> The recognised mood </returns>
        public string RecogniseMood(Image<Bgr, byte> currentFrame)
        {
            grayCurrentFrame = currentFrame.Convert<Gray, byte>();
            facesDetected = grayCurrentFrame.DetectHaarCascade(face, 1.2, 10,
                HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

             if (facesDetected[0].Length == 1)
             {    
                 currentResult = currentFrame.Copy(facesDetected[0][0].rect).Convert<Gray, byte>
                   ().Resize(100, 100, INTER.CV_INTER_CUBIC);

                if (moodsPeople.ToArray().Length != 0)
                {
                     var mCvTermCriteria = new MCvTermCriteria(0, 0.001);

                     var eigenObjectRecognizer = new EigenObjectRecognizer(moodsPeople.ToArray(),
                     moods.ToArray(), 3000, ref mCvTermCriteria);

                     recognisedMood = eigenObjectRecognizer.Recognize(currentResult);
                }
            }
          
            return recognisedMood; 
        }
    }
}
