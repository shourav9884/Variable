using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable
{
    class Math
    {
        int x, y;

        int getx()
        {
            return x;
        }
        int gety()
        {
            return y;
        }
        public void setxy(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
       public Math(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Add()
        {
            return this.x + this.y;
        }
    }
}
