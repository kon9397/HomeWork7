using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак:");
            string userSign = Console.ReadLine();

            switch(userSign)
            {
                case "+":
                    Add(a, b);
                    break;
                case "-":
                    Sub(a, b);
                    break;
                case "*":
                    Mul(a, b);
                    break;
                case "/":
                    Div(a, b);
                    break;
                default:
                    Console.WriteLine("Неизвестный знак. Запустите программу еще раз!");
                    break;

            }

            Console.ReadKey();
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Div(int a, int b)
        {
            if(b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!"); return;
            }

            Console.WriteLine(a / b);
        }
    }
}
