using System;


namespace lab_5
{
    class Program
    {

        static int InputMenu(int check = 1)
        {
            int Input;
            if (check == 1)
            {
                while (!int.TryParse(Console.ReadLine(), out Input) || Input > 3 || Input < 0)
                {
                    Console.WriteLine("Введите число от 0 до 3, чтобы выбрать пункт из меню.");
                }
            }
            else
            {
                while (!int.TryParse(Console.ReadLine(), out Input) || Input > 3 || Input < 1)
                {
                    Console.WriteLine("Введите число от 1 до 3, чтобы выбрать пункт из меню.");
                }
            }
            return Input;
        }
        static int InputSize()
        {
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
            {
                Console.WriteLine("Введите целое положительное число");
            }
            return size;
        }

        static int[] PrintMas(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив!");
            }
            else
            {
                Console.WriteLine("Массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            
            return arr;
        }
        static int[,] PrintMas(int[,] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив!");
            }
            else
            {
                Console.WriteLine("Массив: ");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
            return arr;
        }
        static int[][] PrintMas(int[][] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив!");
            }
            else
            {
                Console.WriteLine("Массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return arr;
        }

        static void AddColumns(ref int[,] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив.");
            }
            else if(arr.GetLength(1) == 1)
            {
                Console.WriteLine("В массиве только один столбец, пересоздайте массив.");
            }
            else
            {
                int newCol = arr.GetLength(1) / 2;
                int[,] new_arr = new int[arr.GetLength(0), newCol + arr.GetLength(1)];
                Console.WriteLine("Как хотите создать столбцы?\n1. Сгенерировать с помощью ДСЧ\n2. Ввести вручную");
                int check;
                while(!int.TryParse(Console.ReadLine(), out check) || check > 2 || check < 1)
                {
                    Console.WriteLine("Выберите один из пунктов меню.");
                }
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

                        if (i % 3 == 0)
                        {
                            Console.WriteLine("Введите элементы для нового столбца:");
                            for (int j = 0; j < arr.GetLength(0); j++)
                            {
                                int k;
                                while (!int.TryParse(Console.ReadLine(), out k))
                                {
                                    Console.WriteLine("Число должно быть целым!");
                                }
                                new_arr[j, i - 1] = k;
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
                                else
                                {
                                    new_arr[j, i - 1] = arr[j, i - (i / 2)];
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Столбцы были успешно добавлены!");
                arr = new_arr;
            }
            return;
        }//Добавить колонки
        static void AddRows(ref int[][] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив!");
            }
            else
            {
                int n;
                int k;
                Console.WriteLine("Введите номер, с которого будут добавлены строки:");
                while (!int.TryParse(Console.ReadLine(), out n) || n > arr.Length+1 || n < 1)
                {
                    if (n > arr.Length+1 || n < 1)
                    {
                        Console.WriteLine("Число выходит за границы массива!");
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть целым!");
                    }

                }
                n = n - 1;
                Console.WriteLine("Введите количество cтрок, которые хотите добавить:");
                while (!int.TryParse(Console.ReadLine(), out k))
                {
                    Console.WriteLine("Число должно быть целым!");
                }
                int[][] new_arr = new int[arr.Length+k][];

                Console.WriteLine("Как хотите создать строки?\n1. Сгенерировать с помощью ДСЧ\n2. Ввести вручную");
                int check;
                while (!int.TryParse(Console.ReadLine(), out check) || check > 2 || check < 1)
                {
                    Console.WriteLine("Выберите один из пунктов меню.");
                }
                if (check == 1)
                {
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
                }
                else//add row
                {
                    for (int i = 0; i < new_arr.Length; i++)
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
                            Console.WriteLine("Введите длину {0} строки:", i + 1);
                            new_arr[i] = new int[InputSize()];
                            for (int m = 0; m < new_arr[i].Length; m++)
                            {
                                Console.WriteLine("По очереди вводите элементы массива:");
                                int el;
                                while (!int.TryParse(Console.ReadLine(), out el))
                                {
                                    Console.WriteLine("Число должно быть целым!");
                                }
                                new_arr[i][m] = el;
                            }
                        }
                        else if (i <  n)
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
                Console.WriteLine("Строки были успешно добавлены!");
                arr = new_arr;
            }
            
            return;
        }//Добавить строки
        static void DeleteElem(ref int[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Массив пустой, пересоздайте массив!");
            }
            else
            {
                int n;
                int k;
                Console.WriteLine("Введите номер, с которого будут удалены элементы:");
                while (!int.TryParse(Console.ReadLine(), out n) || n > arr.Length || n < 1)
                {
                    if (n > arr.Length || n < 1)
                    {
                        Console.WriteLine("Число выходит за границы массива!");
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть целым положительным!");
                    }

                }
                n = n - 1;
                Console.WriteLine("Введите количество элементов, которые хотите удалить:");
                while (!int.TryParse(Console.ReadLine(), out k) || n + k > arr.Length || k < 0)
                {
                    if (n + k > arr.Length || k < 0)
                    {
                        Console.WriteLine("Количество элементов выходит за границы массива!");
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть целым положительным!");
                    }
                }
                int[] mas = new int[arr.Length - k];
                int c = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == n)
                    {
                        while (k > 0)
                        {
                            i++;
                            k--;
                        }
                    }
                    if (i == arr.Length)
                    {
                        break;
                    }
                    mas[c] = arr[i];
                    c++;
                }
                Console.WriteLine("Элементы были удалены!");
                arr = mas;
            }
            
            return;

        }//Удалить элементы

        static void RandGenerator(ref int[] arr)
        {
            Random rand = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
        }
        static void RandGenerator(ref int[,] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rand.Next(-100, 100);
                }
            }
        }
        static void RandGenerator(ref int[][] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j<arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-100,100);
                }
            }
        }

        static void MasCreate(ref int Input, out int[] arr)
        {
            Console.WriteLine("Введите размер массива:");
            int size = InputSize();
            arr = new int[size];
            Console.WriteLine("Выберите что хотите сделать:");
            Console.WriteLine("1. Сгенерировать массив\n2. Ввести с клавиатуры\n3. Выйти в меню");
            int check = 0;
            Input = InputMenu(check);
            switch (Input)
            {
                case 1:
                    RandGenerator(ref arr);
                    Console.WriteLine("Массив успешно сгенерирован!");
                    break;
                case 2:
                    Console.WriteLine("По очереди вводите элементы массива:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int k;
                        while (!int.TryParse(Console.ReadLine(), out k))
                        {
                            Console.WriteLine("Элемент массива должен быть целым числом!");
                        }
                        arr[i] = k;
                    }
                    break;
                case 3:
                    return;
            }

            //Input = -1;
            do
            {
                Console.WriteLine("Выберите что хотите сделать с массивом:");
                Console.WriteLine("1. Распечатать массив\n2. Удалить N элементов\n3. Выйти в меню");
                Input = InputMenu(check);
                switch (Input)
                {
                    case 1:
                        PrintMas(arr);
                        break;
                    case 2:
                        DeleteElem(ref arr);
                        break;
                    case 3:
                        return;
                }
            } while (Input != 3);
            return;
        }
        static void MasCreate(ref int Input, out int[,] arr)
        {
            Console.WriteLine("Введите количество строчек массива:");
            int row = InputSize();
            Console.WriteLine("Введите количество элементов в строке массива:");
            int col = InputSize();
            arr = new int[row, col];
            Console.WriteLine("Выберите что хотите сделать:");
            Console.WriteLine("1. Сгенерировать массив\n2. Ввести с клавиатуры\n3. Выйти в меню");
            int check = 0;
            Input = InputMenu(check);
            switch (Input)
            {
                case 1:
                    RandGenerator(ref arr);
                    Console.WriteLine("Массив успешно сгенерирован!");
                    break;
                case 2:
                    Console.WriteLine("По очереди вводите элементы массива:");
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for(int j=0; j<arr.GetLength(1); j++)
                        {
                            int k;
                            while (!int.TryParse(Console.ReadLine(), out k))
                            {
                                Console.WriteLine("Элемент массива должен быть целым числом!");
                            }
                            arr[i,j] = k;
                        }
                    }
                    break;
                case 3:
                    return;
            }

            do
            {
                Console.WriteLine("Выберите что хотите сделать с массивом:");
                Console.WriteLine("1. Распечатать массив\n2. Добавить столбцы в массив\n3. Выйти в меню");
                Input = InputMenu(check);
                switch (Input)
                {
                    case 1:
                        PrintMas(arr);
                        break;
                    case 2:
                        AddColumns(ref arr);
                        break;
                    case 3:
                        return;
                }
            } while (Input != 3);
            return;
        }
        static void MasCreate(ref int Input, out int[][] arr)
        {
            Console.WriteLine("Введите количество строчек массива:");
            int row = InputSize();
            arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите количество элементов в {0} строке массива:", i+1);
                arr[i] = new int[InputSize()];
            }
            Console.WriteLine("Выберите что хотите сделать:");
            Console.WriteLine("1. Сгенерировать массив\n2. Ввести с клавиатуры\n3. Выйти в меню");
            int check = 0;
            Input = InputMenu(check);
            switch (Input)
            {
                case 1:
                    RandGenerator(ref arr);
                    Console.WriteLine("Массив успешно сгенерирован!");
                    break;
                case 2:
                    Console.WriteLine("По очереди вводите элементы массива:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < arr[i].Length; j++)
                        {
                            int k;
                            while (!int.TryParse(Console.ReadLine(), out k))
                            {
                                Console.WriteLine("Элемент массива должен быть целым числом!");
                            }
                            arr[i][j] = k;
                        }
                    }
                    break;
                case 3:
                    return;
            }

            do
            {
                Console.WriteLine("Выберите что хотите сделать с массивом:");
                Console.WriteLine("1. Распечатать массив\n2. Добавить строки в массив\n3. Выйти в меню");
                Input = InputMenu(check);
                switch (Input)
                {
                    case 1:
                        PrintMas(arr);
                        break;
                    case 2:
                        AddRows(ref arr);
                        break;
                    case 3:
                        return;
                }
            } while (Input != 3);
            return;
        }
        static void Main(string[] args)
        {
            int Input;
            do
            {
                Console.WriteLine("Выберите массив, который вам нужно сформировать:");
                Console.WriteLine("1. Одномерный массив\n2. Двумерный массив\n3. Рваный массив\n0. Выйти из программы");
                Input = InputMenu();
                if (Input == 0)
                {
                    return;
                }
                switch (Input)
                {
                    case 1:
                        int[] massive;
                        MasCreate(ref Input, out massive);
                        break;
                    case 2:
                        int[,] massive2;
                        MasCreate(ref Input, out massive2);
                        break;
                    case 3:
                        int[][] massive3;
                        MasCreate(ref Input, out massive3);
                        break;
                }
            }
            while (Input != 0);
        }
    }
}
