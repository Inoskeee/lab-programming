using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана последовательность из n целых чисел. 
              Найти сумму нечетных элементов этой последовательности.*/

            int n, m, count; //n - количество чисел, m - числа последовательности, count - сумма нечетных эл-тов.
            bool check;
            Console.WriteLine("Введите количество элементов последовательности");
            do
            {
                check = int.TryParse(Console.ReadLine(), out n);
                if (!check)
                {
                    Console.WriteLine("Это не целое число! Повторите ввод:");
                }
                else if (n < 0)
                {
                    Console.WriteLine("Количество чисел не может быть отрицательным! Повторите ввод: ");
                }
                else if (n==0)
                {
                    Console.WriteLine("Последовательность пуста, введите положительное число: ");
                }

            } while(!check || n<=0);

            count = 0;

            Console.WriteLine("Введите ряд целых чисел");

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    check = int.TryParse(Console.ReadLine(), out m);
                    if (!check)
                    {
                        Console.WriteLine("Это не целое число! Повторите ввод.");
                    }
                } while (!check);

                if (m % 2 != 0)
                {
                    count += m;
                }
                else
                {

                }
            }

            Console.WriteLine($"Сумма нечетных элементов последовательности = {count}");
    
            Console.WriteLine("Для выхода нажмите ESC");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }


        }
    }
}
