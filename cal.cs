using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    abstract public class cal
    {
        public abstract void CalArea();  //  Abstract class: Abstract means which does not have implementation

    }

    public class rect : cal
    {
        private int l;
        private int b;
        private double r;

        public rect(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalArea()
        {
            r = l * b;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is {r}";
        }





    }

}
