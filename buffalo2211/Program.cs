using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffalo2211
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunting field = new Hunting(10, 5);
            int x = -1, y = -1;
            int j = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(field.AllData());
                Console.WriteLine(field.Distances(x, y));
                Console.WriteLine("Shoot x, enter, e, enter");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                field.Shot(x, y);
            } while (!field.playerWin() && !field.buffalosWin());
            if (field.playerWin()) Console.WriteLine("PLAYER WINS");
            else if (field.buffalosWin()) Console.WriteLine("BUFFALOS WINS");
            else Console.WriteLine("THIS IS IMPOSSIBLE");
            Console.WriteLine(field.AllData());
            /*int number = 10; //num bufalos
            int size = 5; //size of playground
            Buffalo[] b = new Buffalo[number];
            for(int i = 0; i<number; i++)
            {
                b[i] = new Buffalo(size);
                Console.WriteLine(b[i].print());
            }*/
            Console.WriteLine("\nThe end. ");
            Console.ReadKey();

        }
    }
}
