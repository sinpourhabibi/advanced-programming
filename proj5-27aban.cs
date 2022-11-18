using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proj5_27aban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double x=0,R;
            Console.WriteLine("Enter your numbers");
            Console.WriteLine("a is:");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b is");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c is");
            Double c = Convert.ToDouble(Console.ReadLine());
            R = a * (Math.Pow(x, 2)) + (b * x) + c;
            if (R == 0)
            {
             Console.WriteLine(Result1(a, b, c,x,R));
            }
            else if (R < 0)
            {
             Console.WriteLine(Result1(a, b, c, x,R));
            }
            else if (R == 0)
            {
             Console.WriteLine(Result1(a, b, c, x,R));
            }


        }
        private static Double Result1(Double p, Double q,Double r,Double z,Double D)
        {
            
            D = Math.Pow(q, 2) - (4 * p * r);
            if (D > 0)
            {
                z = -(q) + (Math.Sqrt(D)) / (2 * p);
            }
            else if (D < 0)
            {
                z = -(q) - (Math.Sqrt(D)) / (2 * p);
            }
            else if (D==0)
                
            {
                z=-(q) / (2 * p);
            }
            return z;
            Console.ReadKey();
        }       
    }
}
