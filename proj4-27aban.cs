using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj4_27aban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            Double a,b
                ;
            Console.WriteLine("enter your inventory");
            Double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter banks Interest:");
            Double y=Convert.ToDouble(Console.ReadLine());
            Double z = 0;
            for (j = 0; j<=x; j++)
            {
                z = calc(x, y);
                if (z >= (2 * x)) ;
                Console.WriteLine(z);
                Console.WriteLine(j);
            }
            
               
        }
        public static Double calc(Double f,Double r)
        {
            Double a = 0;
            int i;
            for (i = 0; i < f; i++)
            {
                a = (f + r);
            }
            return (a);
            Console.ReadKey();
        }

        }
            

    }

