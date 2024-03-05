using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class RGB
    {
        private Red r;
        private Green g;
        private Blue b;

        public RGB(Red r, Green g, Blue b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static RGB operator +(RGB rgb, Green g)
        {
            return new RGB(rgb.r, new Green(rgb.g.getGreen() + g.getGreen()), rgb.b);
        }

        public static RGB operator -(RGB rgb, Green g)
        {
            return new RGB(rgb.r, new Green(rgb.g.getGreen() - g.getGreen()), rgb.b);
        }

        public static RGB operator +(RGB rgb, Red r)
        {
            return new RGB(new Red(rgb.r.getRed() + r.getRed()), rgb.g, rgb.b);
        }

        public static RGB operator -(RGB rgb, Red r)
        {
            return new RGB(new Red(rgb.r.getRed() - r.getRed()), rgb.g, rgb.b);
        }

        public static RGB operator +(RGB rgb, Blue b)
        {
            return new RGB(rgb.r, rgb.g, new Blue(rgb.b.getBlue() + b.getBlue()));
        }

        public static RGB operator -(RGB rgb, Blue b)
        {
            return new RGB(rgb.r, rgb.g, new Blue(rgb.b.getBlue() - b.getBlue()));
        }

        public string getRGB()
        {
            return "(" + r.getRed().ToString() + ", " + g.getGreen().ToString() + ", " + b.getBlue().ToString() + ")";
        }
    }
}
