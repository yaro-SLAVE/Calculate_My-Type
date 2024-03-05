using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Color_HSV
    {
        private int hue;
        private int saturation;
        private int brightness;
        private int red;
        private int green;
        private int blue;

        public Color_HSV(int hue, int saturation, int brightness)
        {
            this.hue = hue;
            this.saturation = saturation;
            this.brightness = brightness;
        }

        public static Color_HSV operator+(Color_HSV color, int num)
        {

        }

        public string getColorHSV()
        {
            return String.Format("({0}, {1}, {2})", this.hue.ToString(), this.saturation.ToString(), this.brightness.ToString());

        }
    }
}
