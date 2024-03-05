using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Red
    {
        private int value;

        public Red(int red)
        {
            this.setRed(red);
        }

        public int getRed()
        {
            return value;
        }

        public void setRed(int red)
        {
            if (red < 0)
            {
                this.value = 0;
            }
            else if (red > 255)
            {
                this.value = 255;
            }
            else
            {
                this.value = red;
            }
        }
    }
}
