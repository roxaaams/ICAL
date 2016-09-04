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

using System.Windows.Forms;
using ICAL_Final.Resources;

namespace ICAL_Final.Forms.About
{
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the form
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            InitializeInfo();
        }
        
        /// <summary>
        /// Shows the assembly info on the form
        /// </summary>
        private void InitializeInfo()
        {
            Text = string.Format("About {0}", Strings.AssemblyTitle);
            labelProductName.Text = Strings.AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", Strings.AssemblyVersion);
            labelCopyright.Text = Strings.AssemblyCopyright;
            labelCompanyName.Text = Strings.AssemblyCompany;
            textBoxDescription.Text = Strings.AssemblyDescription;
        }
    }
}
