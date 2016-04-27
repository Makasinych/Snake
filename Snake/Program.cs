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
            Point p1 = new Point( 1, 3, '*' );
           
            p1.Draw();

            Point p2 = new Point( 4, 5, '#' );
           
            p2.Draw();

            Point p3 = new Point(3, 1, '&');

            p3.Draw();

            List<char> numList = new List<char>();
            numList.Add('^');
            numList.Add('$');
            numList.Add('@');

            foreach(char i in numList)
            {          
                Console.WriteLine(i);               
            }

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.Remove('0');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            Console.ReadLine();

        }
    }
}
