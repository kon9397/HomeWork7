using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c);

            Console.ReadKey();
        }

        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine((a + b + c) / 3);
        }
    }
}
