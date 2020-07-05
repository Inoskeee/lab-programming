using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана последовательность целых чисел, за которой следует 0.  
              Найти максимальный элемент в этой последовательности.*/

            int n, max; //n - входное число, max - максимальный эл-т.
            bool check;
            Console.WriteLine("Введить последовательность чисел, кончающуюся нулем, чтобы найти максимальный элемент.");
            do
            {
                check = int.TryParse(Console.ReadLine(), out n);
                if (!check)
                {
                    Console.WriteLine("Вы ввели не целое число! Повторите ввод.");
                }
                else if (n==0)
                {
                    Console.WriteLine("Пустая последовательность! Повторите ввод.");
                }
            } while (!check || n==0);

            max = n;

            do
            {
                do
                {
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (!check)
                    {
                        Console.WriteLine("Вы ввели не целое число! Повторите ввод.");
                    }
                } while (!check);

                if (n > max)
                {
                    max = n;
                }
                else { }
            } while (n != 0);

            Console.WriteLine($"Максимальное число в последовательности = {max}");

            Console.WriteLine("Для выхода нажмите ESC");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
