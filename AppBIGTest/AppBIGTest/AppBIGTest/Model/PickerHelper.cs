using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AppBIGTest
{
    public static class PickerHelper
    {
        static Dictionary<string, Color> colors = new Dictionary<string, Color>();

        public static Color GetColor(string color)

        {

            colors.Clear();

            colors.Add("White", Color.White);

            colors.Add("Red", Color.Red);

            colors.Add("Green", Color.Green);

            colors.Add("Yellow", Color.Yellow);

            colors.Add("Blue", Color.Blue);

            colors.Add("SkyBlue", Color.SkyBlue);

            colors.Add("Black", Color.Black);

            colors.Add("Gray", Color.Gray);

            return colors[color.ToString()];

        }
    }
}
