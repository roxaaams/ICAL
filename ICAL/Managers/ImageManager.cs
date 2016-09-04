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
using System.IO;
using System.Windows.Forms;
using ICAL_Final.Resources;

namespace ICAL_Final.Managers
{
    static class ImageManager
    {
        /// <summary>
        /// Scales a given image
        /// </summary>
        /// <param name="source"> The image which must be scaled </param>
        /// <param name="maxWidth"> The maximal width of the image </param>
        /// <param name="maxHeight"> The maximal height of the image </param>
        /// <returns> The result of the scale </returns>
        public static Image ScaleImage(Image source, int maxWidth, int maxHeight)
        {
            var maxRatio = maxWidth / (float)maxHeight;
            var imageRatio = source.Width / (float)source.Height;

            if (source.Width > maxWidth)
            {
                return new Bitmap(source, new Size(maxWidth, (int)Math.Round(maxWidth / imageRatio, 0)));
            }

            if (source.Height > maxHeight)
            {
                return new Bitmap(source, new Size((int)Math.Round(maxWidth * imageRatio, 0), maxHeight));
            }

            return source;
        }

        /// <summary>
        ///  Converts a given image into a byte array
        /// </summary>
        /// <param name="imageToConvert"> The image which must be converted </param>
        /// <param name="formatOfImage"> The format of the image which must be converted </param>
        /// <returns> The result of the conversion </returns>
        public static byte[] ConvertImageToByteArray(Image imageToConvert, ImageFormat formatOfImage)
        {
            byte[] result;

            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    imageToConvert.Save(memoryStream, formatOfImage);

                    result = memoryStream.ToArray();
                }
            }
            catch (Exception e)
            {
                NotificationManager.Alert(e.ToString());
                throw;
            }

            return result;
        }

        /// <summary>
        /// Converts a given byte array into an image
        /// </summary>
        /// <param name="source"> The byte array which must be converted </param>
        /// <returns> The result of the conversion </returns>
        public static Image ConvertByteArrayToImage(byte[] source)
        {
            Image newImage;

            using (var memoryStream = new MemoryStream(source, 0, source.Length))
            {
                memoryStream.Write(source, 0, source.Length);

                newImage = Image.FromStream(memoryStream, true);
            }
               
            return newImage;
        }

        /// <summary>
        ///  Opens a fileDialog for uploading images
        /// </summary>
        /// <param name="titleOfFileDialog"> The title of the OpenFileDialog</param>
        /// <returns> Resulting file name </returns>
        public static string UploadImage(string titleOfFileDialog)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = titleOfFileDialog;
                openFileDialog.Filter = Strings.Filters;

                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                {
                    return openFileDialog.FileName;
                }
            }

            return Strings.NoFile;
        }
    }
}
