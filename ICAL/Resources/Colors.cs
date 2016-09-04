using System.Drawing;
using System.Globalization;

namespace ICAL_Final.Resources
{
    static class Colors
    {
        /// <summary>
        ///  Keeps the colors which will be used in the app
        /// </summary>
        /// 

        public static Color greenColor = Color.FromArgb(int.Parse("#8BC34A".Replace("#", ""),
                         NumberStyles.AllowHexSpecifier));

        public static Color redColor = Color.FromArgb(int.Parse("#f44336".Replace("#", ""),
                         NumberStyles.AllowHexSpecifier));
    }
}
