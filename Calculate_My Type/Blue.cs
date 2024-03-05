using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Blue
    {
        private int value;

        public Blue(int blue)
        {
            if (blue < 0)
            {
                this.value = 0;
            }
            else if (blue > 255)
            {
                this.value = 255;
            }
            else
            {
                this.value = blue;
            }
        }

        public int getBlue()
        {
            return this.value;
        }

        public void setBlue(int blue)
        {
            if (blue < 0)
            {
                this.value = 0;
            }
            else if (blue > 255)
            {
                this.value = 255;
            }
            else
            {
                this.value = blue;
            }
        }
    }
}
