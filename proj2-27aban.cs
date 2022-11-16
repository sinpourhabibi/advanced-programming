using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj2_27aban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age as year?");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("year of your age is: " + (year(x)));
            Console.WriteLine("month of your age is: " + (month(x)));
            Console.WriteLine("week of your age is: " + (week(x)));
            Console.WriteLine("and day is " + (day(x)));

        }
        private static int year(int y)
        {
            int Y;
                Y = y / 365;
            return (Y);
            Console.ReadKey();
            }
        private static int month(int m)
        {
            int M, a;
            a = m % 365;
            M=a/30;
            return (M);
            Console.ReadKey();
        }
        private static int week(int w)
        {
            int W, c, b;
            b=w % 365;
            c = b % 30;
            W = c / 7;
            return (W);
            Console.ReadKey();

        }
        private static int day (int d)
        {
            int D,f,j,i;
            i = d % 365;
            j = i % 30;
            f = j % 7;
            D = f % 7;
            return (D);
            Console.ReadKey();
        }
    }
}
