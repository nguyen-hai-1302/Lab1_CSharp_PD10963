using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            Calculator cal = new Calculator(a, b);
            int equal1 = cal.plus(a, b);
            System.Console.WriteLine(equal1);
            int equal2 = cal.minus(a, b);
            System.Console.WriteLine(equal2);
            int equal3 = cal.multiply(a, b);
            System.Console.WriteLine(equal3);
            double equal4 = cal.divide(a, b);
            System.Console.WriteLine(equal4);
            Console.ReadKey();
        }
    }
}
