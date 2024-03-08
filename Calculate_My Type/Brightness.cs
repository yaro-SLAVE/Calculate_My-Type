using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Brightness
    {
        private double value;

        public Brightness(double bright)
        {
            this.setBrightness(bright);
        }

        public Brightness(int r, int g, int b)
        {
            setBrightness(r, g, b);
        }

        public void setBrightness(int r, int g, int b)
        {
            double r1 = (double)r / 255;
            double g1 = (double)g / 255;
            double b1 = (double)b / 255;

            double cmax = new[] { r1, g1, b1 }.Max();

            this.setBrightness((double)(cmax * 100));
        }

        public void setBrightness(double bright)
        {
            if (bright < 0)
            {
                this.value = 0;
            }
            else if (bright > 100)
            {
                this.value = 100;
            }
            else
            {
                this.value = bright;
            }
        }

        public double getBright()
        {
            return value;
        }
    }
}
