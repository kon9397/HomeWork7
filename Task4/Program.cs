using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            Method(n);
        }

        static void Method(int n)
        {
            if(n < 0)
            {
                Console.WriteLine("Число отрицательное");
            } else
            {
                Console.WriteLine("Число положительное");
            }

            int flag = 0;

            if (n == 0 || n == 1) flag = 1;

            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag == 0)
            {
                Console.WriteLine($"{n} простое число");
            } else
            {
                Console.WriteLine($"{n} не простое число");
            }
            
            for(int i = 1; i <= 9; i++)
            {
                if(i == 2)
                {
                    Console.WriteLine(checkModule(n, i));
                    continue;
                }
                if (i == 3)
                {
                    Console.WriteLine(checkModule(n, i));
                    continue;
                }
                if (i == 5)
                {
                    Console.WriteLine(checkModule(n, i));
                    continue;
                }
                if (i == 6)
                {
                    Console.WriteLine(checkModule(n, i));
                    continue;
                }
                if (i == 9)
                {
                    Console.WriteLine(checkModule(n, i));
                    continue;
                }

            }

            Console.ReadKey();
        }

        static string checkModule(int n, int div)
        {
            if(n % div == 0)
            {
                return $"Число {n} делится без остатка на {div}";
            } else
            {
                return $"Число {n} делится на {div} c остатком {n % div}";
            }
        }
    }
}
