using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffalo2211
{
    class Buffalo
    {
        //position 
        static Random R = new Random();
        int x; int y;
        int size;
        private bool isAlive;
        public bool IsAlive {
            get { return isAlive; }
                 set { isAlive = value; }
        }

        public Buffalo(int size)
        {
            this.size = size;
            Move(); //x = 0; y = 0;
            isAlive = true;
        }//*
        public void Move()
        {
            int xold = x, yold = y;
                { 
                    int d = R.Next(0, 3);
                    if (d == 0) { x = Math.Min(x+1, size); } // --
                  else  if (d == 1) { x = Math.Min(x + 1, size); y = Math.Min(y + 1, size); } //\
                  else  if (d == 2) { y = Math.Min(y + 1, size); } // |
                } // while (x > size || y > size) ; // old condition was not perfect because we only increased x and y without decreasing it
            } //**
        public double Distance(int xs,int ys)
        {
            return Math.Sqrt((x - xs) * (x - xs) + (y - ys) * (y - ys));
        }
           
        public string print()
        {
            return "(" + x + "," + y + ") " + IsAlive;
        }
    }//endClass
}
