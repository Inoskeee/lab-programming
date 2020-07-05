using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            double x;
            bool control;

            do
            {
                control = int.TryParse(Console.ReadLine(), out m);
                if (!control)
                {
                    Console.WriteLine("Вы ввели не целое число, попробуйте еще раз!");
                }
            } while (!control);

            do
            {
                control = int.TryParse(Console.ReadLine(), out n);
                if (!control)
                {
                    Console.WriteLine("Вы ввели не целое число, попробуйте еще раз!");
                }
            } while (!control);

            do
            {
                control = double.TryParse(Console.ReadLine(), out x);
                if (!control)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте еще раз!");
                }
            } while (!control);

            if (m != 1)
            {
                int res1 = n++ / --m;
                Console.WriteLine($"n++/--m = {res1}, n = {n}, m = {m} ");
            }
            else
            {
                Console.WriteLine("Попытка деления на ноль");
            }
            
            bool res2 = n-- < n / m++;
            Console.WriteLine($"n--<n/m++ = {res2}, n = {n}, m = {m}");
            bool res3 = --m > n;
            Console.WriteLine($"--m>n = {res3}, n = {n}, m = {m}");
            double res4 = Math.Pow(Math.Pow(Math.E, x)-Math.Sin(x), 2/3);
            Console.WriteLine($"(e^x-sin(x))^2/3 = {res4}, n = {n}, m = {m}");
            Console.ReadLine();

        }
    }
}
