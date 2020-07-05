using System;

namespace _3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, SN, SE, Y, c; //Объявление переменных

            for (X = 0.1; X <= 1; X += 0.1) //Изменение значения Х
            {
                c = 0; //Начальное присваивание
                SN = 0;
                SE = 0;
                double a = X;
                for(int n=0; n<=40; n++) //Нахождение функции при заданном значении n
                {
                    c= a/(2*n+1);
                    a = a * -X * X;
                    SN += c;
                    
                }
                
                c = 1; //с=1, для вхождения в следующий цикл
                int k = 0; //счетчик, для подсчета функции в цикле
                a = X;
                while (Math.Abs(c)>0.0001) //нахождение функции с заданной точностью
                {
                    c = a / (2 * k + 1);
                    a = a * -X * X;
                    SE += c;
                    k++;
                }

                Y = Math.Atan(X); //реальное значение функции
                Console.WriteLine($"X={X}, SN={Math.Round(SN, 3)}, SE={Math.Round(SE, 3)}, Y={Math.Round(Y, 3)}");
            }
            Console.WriteLine("Для выхода нажмите ESC");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
