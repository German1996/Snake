using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1= new Point(1,3,'*');
            p1.Draw();
            

            Point p2 = new Point(4,5,'%');
            p2.Draw();

            Point p3 = new Point(1, 2, '#');
            Point p4 = new Point(6, 7, '^');

            List<int> nunList = new List<int>();
            nunList.Add(0);
            nunList.Add(1);
            nunList.Add(2);

            int x = nunList[0];
            int y = nunList[1];
            int z = nunList[2];

            foreach(int i in nunList)
            {
                Console.WriteLine(i);
            }

            

            List < Point > pList= new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            

            List<char> sym = new List<char>();
            sym.Add('*');
            sym.Add('#');
            sym.Add('^');

            foreach (char symbol in sym)
            {
                Console.WriteLine(symbol);
            }


            Console.ReadLine();

        }
                
    }
}
