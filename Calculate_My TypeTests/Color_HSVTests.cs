using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate_My_Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type.Tests
{
    [TestClass()]
    public class Color_HSVTests
    {
        [TestMethod()]
        public void addRedTest()
        {
            var color = new Color_HSV(new Hue(250, 0, 0), new Satuation(250, 0, 0), new Brightness(250, 0, 0));
            var red = new Red(5);

            var color1 = color + red;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(100, color1.S);
            Assert.AreEqual(100, color1.V);
        }

        [TestMethod()]
        public void addGreenTest()
        {
            var color = new Color_HSV(new Hue(0, 250, 0), new Satuation(0, 250, 0), new Brightness(0, 250, 0));
            var green = new Green(5);

            var color1 = color + green;

            Assert.AreEqual(120, color1.H);
            Assert.AreEqual(100, color1.S);
            Assert.AreEqual(100, color1.V);
        }

        [TestMethod()]
        public void addBlueTest()
        {
            var color = new Color_HSV(new Hue(0, 0, 250), new Satuation(0, 0, 250), new Brightness(0, 0, 250));
            var blue = new Blue(5);

            var color1 = color + blue;

            Assert.AreEqual(240, color1.H);
            Assert.AreEqual(100, color1.S);
            Assert.AreEqual(100, color1.V);
        }

        [TestMethod()]
        public void removeRedTest()
        {
            var color = new Color_HSV(new Hue(5, 0, 0), new Satuation(5, 0, 0), new Brightness(5, 0, 0));
            var red = new Red(5);

            var color1 = color - red;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void removeGreenTest()
        {
            var color = new Color_HSV(new Hue(0, 5, 0), new Satuation(0, 5, 0), new Brightness(0, 5, 0));
            var green = new Green(5);

            var color1 = color - green;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void removeBlueTest()
        {
            var color = new Color_HSV(new Hue(0, 0, 5), new Satuation(0, 0, 5), new Brightness(0, 0, 5));
            var blue = new Blue(5);

            var color1 = color - blue;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void convertToRGBTest()
        {
            var color = new Color_HSV(new Hue(0), new Satuation(100), new Brightness(100));

            Assert.AreEqual(255, color.convertToRGB().R);
            Assert.AreEqual(0, color.convertToRGB().G);
            Assert.AreEqual(0, color.convertToRGB().B);
        }

        [TestMethod()]
        public void addSaturationTest()
        {
            var color = new Color_HSV(new Hue(0), new Satuation(99), new Brightness(0));
            var sat = new Satuation(1);
            var color1 = color + sat;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(100, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void addBrightnessTest()
        {
            var color = new Color_HSV(new Hue(0), new Satuation(0), new Brightness(99));
            var bright = new Brightness(1);
            var color1 = color + bright;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(100, color1.V);
        }

        [TestMethod()]
        public void addHueTest()
        {
            var color = new Color_HSV(new Hue(358), new Satuation(0), new Brightness(0));
            var hue = new Hue(1);
            var color1 = color + hue;

            Assert.AreEqual(359, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void removeSaturationTest()
        {
            var color = new Color_HSV(new Hue(0), new Satuation(1), new Brightness(0));
            var sat = new Satuation(1);
            var color1 = color - sat;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void removeBrightnessTest()
        {
            var color = new Color_HSV(new Hue(0), new Satuation(0), new Brightness(1));
            var bright = new Brightness(1);
            var color1 = color - bright;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }

        [TestMethod()]
        public void removeHueTest()
        {
            var color = new Color_HSV(new Hue(1), new Satuation(0), new Brightness(0));
            var hue = new Hue(1);
            var color1 = color - hue;

            Assert.AreEqual(0, color1.H);
            Assert.AreEqual(0, color1.S);
            Assert.AreEqual(0, color1.V);
        }
    }
}