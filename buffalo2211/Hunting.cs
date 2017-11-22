using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffalo2211
{
    class Hunting
    {
        int number; //num bufalos
        int size; //size of playground
        Buffalo[] b;
        public Hunting(int number, int size)
        {
            this.number = number;
            this.size = size;
            b = new Buffalo[number];
            for (int i = 0; i < number; i++)
            {
                b[i] = new Buffalo(size);
            }
        }//*
        public string AllData()
        {
            string s = " ";
            for(int x = 0; x < size; x++)
            {
                s += x + " ";
            }
            s += "\n";
            for (int y = 0; y < size; y++)
            {
                s += y + " ";
                for(int x = 0; x < size; x++)
                {
                    char one = '-';
                    for (int i = 0; i < number; i++)
                    {if (b[i].Distance(x,y)==0)
                        if (!b[i].IsAlive) one = '+'; //dead
                        else one = '*'; //alive
                    }//endfor i
                    s += one + " ";
                }//endfor x
                s += "\n";
            }//endfor y
                return s;
        }//*
        public void Shot(int xs, int ys)
        {
            //invalid shot
            if (xs < 0 || ys < 0 || xs > size || ys > size) return;
            for (int i = 0; i < number; i++)
            {
                if (b[i].Distance(xs, ys) == 0)
                {
                    b[i].IsAlive = false;
                }

            }
          /*  for(int i=0; i < number; i++)
            {
                if (b[i].IsAlive) b[i].Move();
            } */
        }
        public string Distances(int x1, int y1)
        {
            if (x1 < 0 || y1 < 0 || x1 > size || y1 > size)
                return "";
            string s = " ";
            s += " Shot (" + x1 + "," + y1 + ")";
            for (int i = 0; i < number; i++)
            {
                s += "Buffalo " + i + ":";
                if (!b[i].IsAlive) { s += " is dead"; }
                else
                {
                    s += b[i].Distance(x1, y1);
                }//endfor
                s += "\n";
            }//*
            return s;
            

        }
        public bool buffalosWin()
        {
            for(int i = 0; i < number; i++)
            {
                if(b[i].IsAlive && b[i].Distance(size, size) == 0)
                {
                    return true;
                }
            } return false;
        }
        public bool playerWin()
        {
            for (int i = 0; i < number; i++)
            {
                if (b[i].IsAlive) return false;
                            }
            return true;
        }
    }//end class
}
