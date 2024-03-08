using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_My_Type
{
    public partial class Form1 : Form
    {
        private int r;
        private int g;
        private int b;
        private int h;
        private double s;
        private double v;
        private Color_HSV hsv;

        public Form1()
        {
            InitializeComponent();

            this.deleteEvents();

            hField.Value = Properties.Settings.Default.h;
            sBar.Value = (int)Properties.Settings.Default.s;
            vBar.Value = (int)Properties.Settings.Default.v;

            h = (int)hField.Value;
            s = sBar.Value;
            v = vBar.Value;
            hsv = new Color_HSV(new Hue(h), new Satuation(s), new Brightness(v));
            this.selectColor();

            rField.Value = hsv.convertToRGB().R;
            gField.Value = hsv.convertToRGB().G;
            bField.Value = hsv.convertToRGB().B;
            r = hsv.convertToRGB().R;
            g = hsv.convertToRGB().G;
            b = hsv.convertToRGB().B;
            this.addEvents();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rField_ValueChanged(object sender, EventArgs e)
        {
            if (r > (int)rField.Value)
            {
                hsv = hsv - new Red(r - (int)rField.Value);
            }
            else
            {
                hsv = hsv + new Red((int)rField.Value - r);
            }

            this.deleteEvents();
            r = (int)rField.Value;
            hField.Value = hsv.H;
            sBar.Value = (int)hsv.S;
            vBar.Value = (int)hsv.V;
            h = hsv.H;
            s = hsv.S;
            v = hsv.V;

            this.addEvents();

            this.selectColor();
        }

        private void gField_ValueChanged(object sender, EventArgs e)
        {
            if (g > (int)gField.Value)
            {
                hsv = hsv - new Green(g - (int)gField.Value);
            }
            else
            {
                hsv = hsv + new Green((int)gField.Value - g);
            }

            this.deleteEvents();
            g = (int)gField.Value;
            hField.Value = hsv.H;
            sBar.Value = (int)hsv.S;
            vBar.Value = (int)hsv.V;
            h = hsv.H;
            s = hsv.S;
            v = hsv.V;
            this.addEvents();

            this.selectColor();
        }

        private void bField_ValueChanged(object sender, EventArgs e)
        {
            if (b > (int)bField.Value)
            {
                hsv = hsv - new Blue(b - (int)bField.Value);
            }
            else
            {
                hsv = hsv + new Blue((int)bField.Value - b);
            }

            this.deleteEvents();
            b = (int)bField.Value;
            hField.Value = hsv.H;
            sBar.Value = (int)hsv.S;
            vBar.Value = (int)hsv.V;
            h = hsv.H;
            s = hsv.S;
            v = hsv.V;
            this.addEvents();

            this.selectColor();
        }

        private void hField_ValueChanged(object sender, EventArgs e)
        {
            if (h > (int)hField.Value)
            {
                hsv = hsv - new Hue(h - (int)hField.Value);
            }
            else
            {
                hsv = hsv + new Hue((int)hField.Value - h);
            }

            this.deleteEvents();
            h = (int)hField.Value;
            rField.Value = hsv.convertToRGB().R;
            gField.Value = hsv.convertToRGB().G;
            bField.Value = hsv.convertToRGB().B;
            r = hsv.convertToRGB().R;
            g = hsv.convertToRGB().G;
            b = hsv.convertToRGB().B;
            this.addEvents();

            this.selectColor();
        }

        private void sBar_ValueChanged(object sender, EventArgs e)
        {
            if (s > sBar.Value)
            {
                hsv = hsv - new Satuation(s - sBar.Value);
            }
            else
            {
                hsv = hsv + new Satuation(sBar.Value - s);
            }

            this.deleteEvents();
            s = sBar.Value;
            rField.Value = hsv.convertToRGB().R;
            gField.Value = hsv.convertToRGB().G;
            bField.Value = hsv.convertToRGB().B;
            r = hsv.convertToRGB().R;
            g = hsv.convertToRGB().G;
            b = hsv.convertToRGB().B;
            this.addEvents();

            this.selectColor();
        }

        private void vBar_ValueChanged(object sender, EventArgs e)
        {
            if (v > vBar.Value)
            {
                hsv = hsv - new Brightness(v - vBar.Value);
            }
            else
            {
                hsv = hsv + new Brightness(vBar.Value - v);
            }

            this.deleteEvents();
            v = vBar.Value;
            rField.Value = hsv.convertToRGB().R;
            gField.Value = hsv.convertToRGB().G;
            bField.Value = hsv.convertToRGB().B;
            r = hsv.convertToRGB().R;
            g = hsv.convertToRGB().G;
            b = hsv.convertToRGB().B;
            this.addEvents();

            this.selectColor();
        }

        private void deleteEvents()
        {
            this.hField.ValueChanged -= this.hField_ValueChanged;
            this.sBar.ValueChanged -= this.sBar_ValueChanged;
            this.vBar.ValueChanged -= this.vBar_ValueChanged;
            this.rField.ValueChanged -= this.rField_ValueChanged;
            this.gField.ValueChanged -= this.gField_ValueChanged;
            this.bField.ValueChanged -= this.bField_ValueChanged;
        }

        private void addEvents()
        {
            this.hField.ValueChanged += this.hField_ValueChanged;
            this.sBar.ValueChanged += this.sBar_ValueChanged;
            this.vBar.ValueChanged += this.vBar_ValueChanged;
            this.rField.ValueChanged += this.rField_ValueChanged;
            this.gField.ValueChanged += this.gField_ValueChanged;
            this.bField.ValueChanged += this.bField_ValueChanged;
        }

        public void selectColor()
        {
            Properties.Settings.Default.h = (int)hField.Value;
            Properties.Settings.Default.s = sBar.Value;
            Properties.Settings.Default.v = vBar.Value;
            Properties.Settings.Default.Save();
            resultBox.BackColor = Color.FromArgb(255, hsv.convertToRGB().R, hsv.convertToRGB().G, hsv.convertToRGB().B);
            resultRGB.Text = hsv.convertToRGB().getRGB();
        }
    }
}
