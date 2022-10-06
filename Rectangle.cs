using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        //variables
        private int length;
        private int width;

        //Default constructor
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        //parameterised constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetCurrentLength()
        {
            return this.length;
        }

        public int SetNewLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetCurrentWidth()
        {
            return this.width;
        }
        public int SetNewWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }
        public int GetArea()
        {
            return this.length * this.width;
        }

    }
}
