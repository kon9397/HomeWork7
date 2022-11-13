using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество денег");
            double userMoney = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите курс");
            double currency = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат");
            Console.WriteLine(ConvertCurrency(userMoney, currency));

            Console.ReadKey();
        }

        static double ConvertCurrency(double userMoney, double currency)
        {
            return userMoney * currency;

        }
    }
}
