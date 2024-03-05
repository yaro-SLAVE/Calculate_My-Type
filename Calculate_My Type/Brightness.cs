using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Brightness
    {
        private int value;

        public Brightness(int bright)
        {
            this.setBrightness(bright);
        }

        public void setBrightness(int bright)
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

        public int getBright()
        {
            return value;
        }
    }
}
