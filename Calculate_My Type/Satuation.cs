using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Type
{
    public class Satuation
    {
        private int value;

        public Satuation(int value)
        {
            this.setSaturation(value);
        }

        public void setSaturation(int sat)
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

        public int getSaturation()
        {
            return this.value;
        }
    }
}
