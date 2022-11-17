using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj3_27aban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            int z=Convert.ToInt32((maghsum(x, y)));
            Console.WriteLine(z);

        }
        private static Double maghsum(Double b, Double m)
        {
            Double i, e, c, j;

            for (i = 1; i >= b; i++)
            {

                for (j = m; i <= 1; j--)
                {
                    e = m % j;
                    c = b % i;
                    if (c == 0 && e == 0 && i == j) ;

                    
                }
                
            }
            return (i);

            Console.ReadKey();
        }
        }
    }

