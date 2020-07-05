using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    static class Program
    {
        public static int Col;
        public static int Row;
        public static int[] array;
        public static int[,] array_2;
        public static int[,] mas;
        public static int[][] array_3;
        public static int[][] massive;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void RandGeneration(ref int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
        }
        public static void RandGeneration(ref int[,] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
        }
        public static void RandGeneration(ref int[][] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rand.Next(1, 10)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-100, 100);
                }
            }
        }
        public static string PrintMas(int[] arr)
        {
            if (arr.Length == 0)
            {
                return "Массив пустой, пересоздайте массив!";
            }
            string OutPut = "";
            for (int i = 0; i < arr.Length; i++)
            {
                OutPut += arr[i]+" ";
            }
            Console.WriteLine();

            return OutPut;
        }
        public static string PrintMas(int[,] arr)
        {
            if (arr.Length == 0)
            {
                return "Массив пустой, пересоздайте массив!";
            }
            string OutPut = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    OutPut += arr[i, j] + " ";
                }
                OutPut += Environment.NewLine;
            }
            
            return OutPut;
        }
        public static string PrintMas(int[][] arr)
        {
            if (arr.Length == 0)
            {
                return "Массив пустой, пересоздайте массив!";
            }
            string OutPut = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    OutPut += arr[i][j] + " ";
                }
                OutPut += Environment.NewLine;
            }
            Console.WriteLine();
            return OutPut;
        }
        public static void DeleteElem(ref int[] arr, int n, int k)
        {
            k = k - 1;
            int[] mas = new int[arr.Length - n];
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= k)
                {
                    while (n > 0)
                    {
                        i++;
                        n--;
                    }
                }
                if (i == arr.Length)
                {
                    break;
                }
                mas[c] = arr[i];
                c++;
            }
            arr = mas;
        }
        public static void AddColumns(ref int[,] arr, int[,] mas, int check)
        {
            int newCol = arr.GetLength(1) / 2;
            int[,] new_arr = new int[arr.GetLength(0), newCol + arr.GetLength(1)];
            if (check == 1)
            {
                Random rand = new Random();
                for (int i = 1; i <= new_arr.GetLength(1); i++)
                {

                    if (i % 3 == 0)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            new_arr[j, i - 1] = rand.Next(-100, 100);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            if ((i - 1) % 3 == 0 && i != 1)
                            {
                                new_arr[j, i - 1] = arr[j, i - (i / 2)];
                            }
                            else if (i == 1)
                            {
                                new_arr[j, i - 1] = arr[j, i - 1];
                            }
                            else
                            {
                                new_arr[j, i - 1] = arr[j, i - (i / 2)];
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i <= new_arr.GetLength(1); i++)
                {
                    int count = 0;
                    if (i % 3 == 0)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            new_arr[j, i - 1] = mas[j,count];
                            
                        }
                        count++;
                    }
                    else
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            if ((i - 1) % 3 == 0 && i != 1)
                            {
                                new_arr[j, i - 1] = arr[j, i - (i / 2)];
                            }
                            else if (i == 1)
                            {
                                new_arr[j, i - 1] = arr[j, i - 1];
                            }
                            else
                            {
                                new_arr[j, i - 1] = arr[j, i - (i / 2)];
                            }
                        }
                    }
                }
            }
            arr = new_arr;
            return;
        }//Add Keyboard Input
        public static void AddRows(ref int[][] arr, int[][] mas, int n, int k, int check)
        {
            if(check == 1)
            {
                n = n - 1;
                int[][] new_arr = new int[arr.Length + k][];
                Random rand = new Random();
                for (int i = 0; i < new_arr.Length; i++)
                {
                    if (n == arr.Length && i == n)
                    {
                        new_arr[i] = new int[rand.Next(1, 10)];
                        for (int m = 0; m < new_arr[i].Length; m++)
                        {
                            new_arr[i][m] = rand.Next(-100, 100);
                        }
                    }
                    else
                    {
                        if (i == n)
                        {
                            new_arr[i + k] = arr[i];
                            for (int j = 0; j < new_arr[i + k].Length; j++)
                            {
                                new_arr[i + k][j] = arr[i][j];
                            }
                        }
                        if (i >= n && i < (n + k))
                        {
                            if (i == n)
                            {
                                new_arr[i + k] = arr[i];
                                for (int j = 0; j < new_arr[i + k].Length; j++)
                                {
                                    new_arr[i + k][j] = arr[i][j];
                                }
                            }
                            if (i >= n && i < (n + k))
                            {
                                new_arr[i] = new int[rand.Next(1, 10)];
                                for (int m = 0; m < new_arr[i].Length; m++)
                                {
                                    new_arr[i][m] = rand.Next(-100, 100);
                                }
                            }
                            else if (i < n)
                            {
                                new_arr[i] = arr[i];
                                for (int j = 0; j < new_arr[i].Length; j++)
                                {
                                    new_arr[i][j] = arr[i][j];
                                }

                            }
                            else
                            {
                                new_arr[i] = arr[i - k];
                                for (int j = 0; j < new_arr[i].Length; j++)
                                {
                                    new_arr[i][j] = arr[i - k][j];
                                }
                            }
                        }
                        else if (i < n)
                        {
                            new_arr[i] = arr[i];
                            for (int j = 0; j < new_arr[i].Length; j++)
                            {
                                new_arr[i][j] = arr[i][j];
                            }

                        }
                        else
                        {
                            new_arr[i] = arr[i - k];
                            for (int j = 0; j < new_arr[i].Length; j++)
                            {
                                new_arr[i][j] = arr[i - k][j];
                            }
                        }
                    }
                }
                arr = new_arr;
                return;
            }
            else
            {
                n = n - 1;
                int[][] new_arr = new int[arr.Length + k][];
                Random rand = new Random();
                for (int i = 0; i < new_arr.Length; i++)
                {
                    if (n == arr.Length && i == n)
                    {
                        new_arr[i] = mas[i-n];
                        for (int m = 0; m < new_arr[i].Length; m++)
                        {
                            new_arr[i][m] = mas[i-n][m];
                        }
                    }
                    else
                    {
                        if (i == n)
                        {
                            new_arr[i + k] = arr[i];
                            for (int j = 0; j < new_arr[i + k].Length; j++)
                            {
                                new_arr[i + k][j] = arr[i][j];
                            }
                        }
                        if (i >= n && i < (n + k))
                        {
                            if (i == n)
                            {
                                new_arr[i + k] = arr[i];
                                for (int j = 0; j < new_arr[i + k].Length; j++)
                                {
                                    new_arr[i + k][j] = arr[i][j];
                                }
                            }
                            if (i >= n && i < (n + k))
                            {
                                new_arr[i] = mas[i-n];
                                for (int m = 0; m < new_arr[i].Length; m++)
                                {
                                    new_arr[i][m] = mas[i-n][m];
                                }
                            }
                            else if (i < n)
                            {
                                new_arr[i] = arr[i];
                                for (int j = 0; j < new_arr[i].Length; j++)
                                {
                                    new_arr[i][j] = arr[i][j];
                                }

                            }
                            else
                            {
                                new_arr[i] = arr[i - k];
                                for (int j = 0; j < new_arr[i].Length; j++)
                                {
                                    new_arr[i][j] = arr[i - k][j];
                                }
                            }
                        }
                        else if (i < n)
                        {
                            new_arr[i] = arr[i];
                            for (int j = 0; j < new_arr[i].Length; j++)
                            {
                                new_arr[i][j] = arr[i][j];
                            }

                        }
                        else
                        {
                            new_arr[i] = arr[i - k];
                            for (int j = 0; j < new_arr[i].Length; j++)
                            {
                                new_arr[i][j] = arr[i - k][j];
                            }
                        }
                    }
                }
                arr = new_arr;
                return;
            }
        }//Добавить строки
    }
}
