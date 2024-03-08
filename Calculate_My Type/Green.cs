using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Green
    {
        private int value;

        public Green(int green)
        {
            this.setGreen(green);
        }

        public int getGreen()
        {
            return this.value;
        }

        public void setGreen(int green)
        {
            if (green < 0)
            {
                this.value = 0;
            }
            else if (green > 255)
            {
                this.value = 255;
            }
            else
            {
                this.value = green;
            }
        }
    }
}
