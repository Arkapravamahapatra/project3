using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum, avg;
            Console.WriteLine("Enter first, second and third number");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            sum = a + b + c;
            avg = sum / 3;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
