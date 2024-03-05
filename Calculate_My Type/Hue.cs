using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Hue
    {
        public int value;

        public Hue(int value)
        {
            this.setHue(value);
        }

        public Hue(Red r, Green g, Blue b)
        {
            this.setHue(r, g, b);
        }

        public void setHue(Red r, Green g, Blue b)
        {
            double r1 = r.getRed() / 255;
            double g1 = g.getGreen() / 255;
            double b1 = b.getBlue() / 255;
            
            double cmax = new[] { r1, g1, b1 }.Max();
            double cmin = new[] { r1, g1, b1 }.Min();

            double d = cmax - cmin;

            int hue = 0;
            if (d == 0)
            {
                hue = 0;
            } else
            {
                if (cmax == r1)
                {
                    hue = 60 * (((g1 - b1) / d) % 6);
                }
                else if (cmax == g1)
                {
                    hue = 60 * (((b1 - r1) / d) + 2);
                }
                else if (cmax == b1)
                {
                    hue = 60 * (((r1 - g1) / d) + 4);
                }
            }

            this.value = hue;
        }

        public void setHue(int hue)
        {
            if (hue < 0)
            {
                this.value = 0;
            }
            else if (hue > 360)
            {
                this.value = 360;
            }
            else
            {
                this.value = hue;
            }
        }

        public int getHue()
        {
            return this.value;
        }
    }
}
