using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Satuation
    {
        private double value;

        public Satuation(double value)
        {
            this.setSaturation(value);
        }

        public Satuation(int r, int g, int b)
        {
            setSaturation(r, g, b);
        }

        public void setSaturation(int r, int g, int b)
        {
            double r1 = (double)r / 255;
            double g1 = (double)g / 255;
            double b1 = (double)b / 255;

            double cmax = new[] { r1, g1, b1 }.Max();
            double cmin = new[] { r1, g1, b1 }.Min();

            double d = cmax - cmin;

            double s = 0;
            if (cmax == 0)
            {
                s = 0;
            }
            else
            {
                s = (double)((d / cmax) * 100);
            }

            this.setSaturation(s);
        }

            public void setSaturation(double sat)
        {
            if (sat < 0)
            {
                this.value = 0;
            }
            else if (sat > 100)
            {
                this.value = 100;
            }
            else
            {
                this.value = sat;
            }
        }

        public double getSaturation()
        {
            return this.value;
        }
    }
}
