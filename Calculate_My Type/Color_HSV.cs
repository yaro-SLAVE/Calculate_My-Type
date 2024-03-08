using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Color_HSV
    {
        private Hue h;
        private Satuation s;
        private Brightness v;

        public int H
        {
            get { return h.getHue(); }
        }

        public double S
        {
            get { return s.getSaturation(); }
        }

        public double V
        {
            get { return v.getBright(); }
        }

        public Color_HSV(Hue h, Satuation s, Brightness v)
        {
            this.h = h;
            this.s = s; 
            this.v = v;
        }

        public Color_HSV(int r, int g, int b)
        {
            h = new Hue(r, g, b);
            s = new Satuation(r, g, b);
            v = new Brightness(r, g, b);
        }

        public static Color_HSV operator +(Color_HSV color, Red r)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R + r.getRed(), color.convertToRGB().G, color.convertToRGB().B), new Satuation(color.convertToRGB().R + r.getRed(), color.convertToRGB().G, color.convertToRGB().B), new Brightness(color.convertToRGB().R + r.getRed(), color.convertToRGB().G, color.convertToRGB().B));
        }

        public static Color_HSV operator -(Color_HSV color, Red r)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R - r.getRed(), color.convertToRGB().G, color.convertToRGB().B), new Satuation(color.convertToRGB().R - r.getRed(), color.convertToRGB().G, color.convertToRGB().B), new Brightness(color.convertToRGB().R - r.getRed(), color.convertToRGB().G, color.convertToRGB().B));
        }

        public static Color_HSV operator +(Color_HSV color, Green g)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R, color.convertToRGB().G + g.getGreen(), color.convertToRGB().B), new Satuation(color.convertToRGB().R, color.convertToRGB().G + g.getGreen(), color.convertToRGB().B), new Brightness(color.convertToRGB().R, color.convertToRGB().G + g.getGreen(), color.convertToRGB().B));
        }

        public static Color_HSV operator -(Color_HSV color, Green g)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R, color.convertToRGB().G - g.getGreen(), color.convertToRGB().B), new Satuation(color.convertToRGB().R, color.convertToRGB().G - g.getGreen(), color.convertToRGB().B), new Brightness(color.convertToRGB().R, color.convertToRGB().G - g.getGreen(), color.convertToRGB().B));
        }

        public static Color_HSV operator +(Color_HSV color, Blue b)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B + b.getBlue()), new Satuation(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B + b.getBlue()), new Brightness(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B + b.getBlue()));
        }

        public static Color_HSV operator -(Color_HSV color, Blue b)
        {
            return new Color_HSV(new Hue(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B - b.getBlue()), new Satuation(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B - b.getBlue()), new Brightness(color.convertToRGB().R, color.convertToRGB().G, color.convertToRGB().B - b.getBlue()));
        }

        public static Color_HSV operator +(Color_HSV color, Satuation s)
        {
            return new Color_HSV(color.h, new Satuation(color.S + s.getSaturation()), color.v);
        }

        public static Color_HSV operator -(Color_HSV color, Satuation s)
        {
            return new Color_HSV(color.h, new Satuation(color.S - s.getSaturation()), color.v);
        }

        public static Color_HSV operator +(Color_HSV color, Brightness b)
        {
            return new Color_HSV(color.h, color.s, new Brightness(color.V + b.getBright()));
        }

        public static Color_HSV operator -(Color_HSV color, Brightness b)
        {
            return new Color_HSV(color.h, color.s, new Brightness(color.V - b.getBright()));
        }

        public static Color_HSV operator +(Color_HSV color, Hue h)
        {
            return new Color_HSV(new Hue(color.H + h.getHue()), color.s, color.v);
        }

        public static Color_HSV operator -(Color_HSV color, Hue h)
        {
            return new Color_HSV(new Hue(color.H - h.getHue()), color.s, color.v);
        }

        public string getColorHSV()
        {
            return String.Format("({0}, {1}, {2})", this.h.getHue().ToString(), this.s.getSaturation().ToString(), this.v.getBright().ToString());

        }

        public RGB convertToRGB()
        {
            double s = S / 100;
            double v = V / 100;
            double h = (double)(H);

            double c = s * v;
            double x = c * (1 - Math.Abs((h / 60) % 2 - 1));
            double m = v - c;

            double r1 = 0;
            double g1 = 0;
            double b1 = 0;

            if (0 <= h && h < 60)
            {
                r1 = c;
                g1 = x;
                b1 = 0;
            }
            else if (60 <= h && h < 120)
            {
                r1 = x;
                g1 = c;
                b1 = 0;
            }
            else if (120 <= h && h < 180)
            {
                r1 = 0;
                g1 = c;
                b1 = x;
            }
            else if (180 <= h && h < 240)
            {
                r1 = 0;
                g1 = x;
                b1 = c;
            }
            else if (240 <= h && h < 300)
            {
                r1 = x;
                g1 = 0;
                b1 = c;
            }
            else if (300 <= h && h < 360)
            {
                r1 = c;
                g1 = 0;
                b1 = x;
            }

            int r = 0;
            int g = 0;
            int b = 0;

            r = (int)((r1 + m) * 255);
            g = (int)((g1 + m) * 255);
            b = (int)((b1 + m) * 255);

            return new RGB(new Red(r), new Green(g), new Blue(b));
        }
    }
}
