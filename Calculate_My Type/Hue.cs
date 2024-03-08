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
        private Red r;
        private Green g;
        private Blue b;

        public Hue(int value)
        {
            this.setHue(value);
        }

        public Hue(int r, int g, int b)
        {
            this.r = new Red(r);
            this.g = new Green(g);
            this.b = new Blue(b);
            this.setHue(this.r.getRed(), this.g.getGreen(), this.b.getBlue());
        }

        public void setHue(int r, int g, int b)
        {
            double r1 = (double)r / 255;
            double g1 = (double)g / 255;
            double b1 = (double)b / 255;
            
            double cmax = new[] { r1, g1, b1 }.Max();
            double cmin = new[] { r1, g1, b1 }.Min();

            double d = cmax - cmin;

            int hue = 0;
            if (d == 0)
            {
                hue = 0;
            } 
            
            else
            {
                if (cmax == r1)
                {
                    hue = (int)(60 * (((g1 - b1) / d) % 6));
                }
                else if (cmax == g1)
                {
                    hue = (int)(60 * (((b1 - r1) / d) + 2));
                }
                else if (cmax == b1)
                {
                    hue = (int)(60 * (((r1 - g1) / d) + 4));
                }
            }

            this.setHue(hue);
        }

        public void setHue(int hue)
        {
            if (hue < 0)
            {
                this.value = 0;
            }
            else if (hue > 359)
            {
                this.value = 359;
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

        public int getRed()
        {
            return r.getRed();
        }

        public int getGreen()
        {
            return g.getGreen();
        }

        public int getBlue()
        {
            return b.getBlue();
        }
    }
}
