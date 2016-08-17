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
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ICAL_Final.Managers
{
    static class EncryptionManager
    {
        private static string EncryptionKey { get { return "ICALIDKYET2016"; } }

        /// <summary>
        /// Encrypts the data
        /// </summary>
        /// <param name="password"> A password from the user </param>
        /// <returns> The result of the encryption </returns>
        public static string Encrypt(string password)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);

            using (var encryptor = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = key.GetBytes(32);
                encryptor.IV = key.GetBytes(16);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(clearBytes, 0, clearBytes.Length);
                        cryptoStream.Close();
                    }

                    password = Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return password;
        }

        /// <summary>
        /// Decrypts the data
        /// </summary>
        /// <param name="password"> A password from the database </param>
        /// <returns> The result of the decryption </returns>
        public static string Decrypt(string password)
        {
            byte[] cipherBytes = Convert.FromBase64String(password);

            using (var encryptor = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = key.GetBytes(32);
                encryptor.IV = key.GetBytes(16);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                        cryptoStream.Close();
                    }

                    password = Encoding.Unicode.GetString(memoryStream.ToArray());
                }
            }

            return password;
        }
    }
}
