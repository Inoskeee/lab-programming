using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class Program
    {
        public static void Input(out int a, out int b, out int c)
        {
            while (!int.TryParse(Console.ReadLine(), out a) || a == 0)
            {
                Console.WriteLine("Значение а не может быть 0 или символом, повторите попытку:");
            }
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Вы ввели не число, повторите ввод");
            }
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Вы ввели не число, повторите ввод");
            }
        }

        static void Input(out int a)
        {
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Вы ввели не число, повторите ввод");
            }
        }

        static void Main(string[] args)
        {
            int count;

            Console.WriteLine("Выберите пункт меню.");
            Console.WriteLine("1.Часть 1.\n2.Часть 2.\n0.Выйти");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 0 || count > 3)
            {
                Console.WriteLine("Неверный ввод, повторите!");
            }
            switch (count)
            {
                case 0:
                    return;
                case 1:
                    int a, b, c;
                    int a1, b1, c1;

                    Console.WriteLine("По очереди введите элементы a, b, c для первого уравнения.");
                    Input(out a, out b, out c);
                    Uravnenie uravnenie = new Uravnenie(a, b, c);
                    Console.WriteLine("По очереди введите элементы a, b, c для второго уравнения.");
                    Input(out a1, out b1, out c1);
                    Uravnenie uravnenie_2 = new Uravnenie(a1, b1, c1);

                    Console.WriteLine(uravnenie.Show());
                    uravnenie.Calculate();
                    Console.WriteLine($"\nКорни уравнения: x1 = {uravnenie.X1}, x2 = {uravnenie.X2}");
                    Console.WriteLine(Uravnenie.Calculate(new Uravnenie(a, b, c)));
                    Console.WriteLine("Унарные операции:\n");
                    uravnenie++;
                    Console.WriteLine("++:");
                    Console.WriteLine(uravnenie.Show());
                    Console.WriteLine("\n");
                    uravnenie--;
                    Console.WriteLine("--:");
                    Console.WriteLine(uravnenie.Show());
                    Console.WriteLine("\n(double):");
                    double x = (double)uravnenie;
                    Console.WriteLine($"\nx = {x}");
                    Console.WriteLine("(bool):");
                    bool advise = (bool)uravnenie;
                    Console.WriteLine($"Решения существуют: {advise}\n");

                    Console.WriteLine(@"Уравнения равны: {0}", uravnenie == uravnenie_2);

                    Console.WriteLine(@"Объектов создано: {0}", Uravnenie.count);

                    break;
                case 2:

                    int size, size1;
                    a = 0;
                    b = 0;
                    c = 0;
                    Console.WriteLine("Введите размер для списка генерируемых уравнений:");
                    Input(out size);
                    Console.WriteLine("Введите размер для списка генерируемых уравнений:");
                    Input(out size1);
                    if (size1 > 0)
                    {
                        Console.WriteLine("Вводите по очереди элементы a, b, c для уравнений:");
                        Input(out a, out b, out c);
                    }


                    UravnenieArray arr = new UravnenieArray();
                    UravnenieArray random_arr = new UravnenieArray(size);
                    UravnenieArray keyboard_arr = new UravnenieArray(size1, a, b, c);

                    Console.WriteLine("Конструктор без параметров:\n");
                    Console.WriteLine(arr.Show());
                    Console.WriteLine("\nКонструктор с рандомными значениями:\n");
                    Console.WriteLine(random_arr.Show());
                    Console.WriteLine("\nКонструктор с элементами с клавиатуры:\n");
                    Console.WriteLine(keyboard_arr.Show());



                    if (size1 != 0)
                    {
                        Uravnenie large = keyboard_arr.Check();
                        Console.WriteLine($"\nУравнение с наибольшим корнем:");
                        Console.WriteLine(large.Show());
                        large.Calculate();
                        if ((bool)large)
                        {
                            Console.WriteLine($"\nКорни уравнения: x1 = {large.X1}, x2 = {large.X2}");
                            Console.WriteLine($"\nНаибольший корень по абсолютному значению:");
                            if (Math.Abs(large.X1) > Math.Abs(large.X1))
                            {
                                Console.WriteLine(Math.Abs(large.X1));
                            }
                            else
                            {
                                Console.WriteLine(Math.Abs(large.X2));
                            }
                        }

                    }

                    break;
            }
            Console.ReadLine();
        }
    }
}
