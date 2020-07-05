using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Программа считает выражение со степенями двойки по формуле
              Р = (х-1)/(x-2)*(x-3)/(x-4)...*/
            int x;
            double numerator, denominator;  //x - число, numerator - числитель, denominator - знаменатель.
            bool check;

            numerator = 1;
            denominator = 1;

            Console.WriteLine("Введите любое целое число, чтобы посчитать выражение.");
            do
            {
                check = int.TryParse(Console.ReadLine(), out x);
                if (!check)
                {
                    Console.WriteLine("Вы ввели не целое число! Повторите ввод.");
                }
               
            } while (!check);

            for (int i = 1; i <= 6;i++)
            {
                numerator *= (x - (Math.Pow(2, i) - 1));
                denominator *= (x - Math.Pow(2, i));
            }

            if (denominator != 0)
            {
                double result = numerator / denominator;
                Console.WriteLine($"Число = {result}");
            }
            else
            {
                Console.WriteLine("Попытка деления на ноль.");
            }

            Console.WriteLine("Для выхода нажмите ESC");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
