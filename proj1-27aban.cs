using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number?");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(result1(x));
            Console.WriteLine(result2(x));



        }
        private static double result1(Double a)
        {
            Double A;
            A = Math.Pow(a, 2);
            return (A);
            Console.ReadKey();
        }
        private static double result2(Double b)
        {
            Double B;
            B = Math.Pow(b, 3);
            return (B);
            Console.ReadKey();
        }
    }
}
