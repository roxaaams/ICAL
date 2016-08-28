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
using ICAL_Final.Resources;

namespace ICAL_Final.Managers
{
    static  class NotificationManager
    {
        /// <summary>
        ///  Shows a MessageBox which alerts the user
        /// </summary>
        /// <param name="message"> The message in the box </param>
        public static void Alert(string message)
        {
            MessageBox.Show(message, Strings.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows a MessageBox which tells the user that there is a login exception
        /// </summary>
        /// <param name="message"> The message in the box </param>
        public static void LogException(string message)
        {
            MessageBox.Show(message, Strings.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        ///  Shows a MessageBox which tells the user that there is a login exception
        /// </summary>
        /// <param name="exception"> The exception of the login</param>
        public static void LogException(Exception exception)
        {
            MessageBox.Show(exception.Message, Strings.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        ///  Shows a MessageBox which asks the user to confirm the deletion
        /// </summary>
        /// <param name="message"> The message in the box </param>
        /// <returns> The dialog result </returns>
        public static bool ConfirmationDelete(string message)
        {
            return (MessageBox.Show(message, Strings.Title, MessageBoxButtons.YesNo) == DialogResult.Yes);
        }
    }
}
