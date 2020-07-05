using System;


namespace lab_4
{
    class Program
    {
        static int InputArr()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (input < 0 || input > 2)
                {
                    Console.WriteLine("Введите число от 0 до 2.");
                }
                else
                {
                    Console.WriteLine("Введите целое положительное число");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }
        static int InputSize()
        {
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (size <= 0)
                {
                    Console.WriteLine("Количество элементов не может быть отрицательным или нулевым.");
                }
                else
                {
                    Console.WriteLine("Нужно ввести целое число, повторите ввод.");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return size;
        }
        static int InputMenu()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (input < 0 || input > 7)
                {
                    Console.WriteLine("Введите число от 1 до 8.");
                }
                else
                {
                    Console.WriteLine("Введите целое положительное число");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }

        static void BinarySearch(int[] arr, int size)
        {
            for(int i = 0; i<size-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine("Массив не отсортирован! Желаете отсортировать массив?(Y/N)");
                    string sort;
                    do
                    {
                        sort = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Выберите хотите ли отсортировать массив - Y(yes) N(no)");
                    } while (sort != "Y" && sort != "N" && sort !="y" && sort != "n" );
                    if (sort == "Y" || sort == "y")
                    {
                        SortArr(ref arr, size);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Без сортировки эта функция невозможна.");
                        return;
                    }
                }
            }//сортируем массив
            int middle;
            int left = 0;
            int right = size - 1;
            //Console.WriteLine("Введите элемент, который хотите найти:");
            int numberForFind = SearchEl(arr, size);
            //while (!int.TryParse(Console.ReadLine(), out numberForFind))
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Введите целое положительное число");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            int count = 0;
            do
            {
                count++;
                middle = (left + right) / 2;
                if (arr[middle] < numberForFind)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            } while (left != right);
            if (arr[left] == numberForFind)
            {
                Console.WriteLine("Элемент: {0}, его номер {1}", numberForFind, left + 1);
                Console.WriteLine("\bДля поиска потребовалось {0} сравнений", count);
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }
            
        }//Бинарный поиск
        static int SearchEl(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    return arr[i];
                }
            }
            return 1;
        }//Поиск элемента
        static void Transposition(ref int[] arr, int size)
        {
            int el;
            int count = 0;
            for(int i = 0; i<size; i++)
            {
                if (arr[i] > 0)
                {
                    el = arr[count];
                    arr[count] = arr[i];
                    arr[i] = el;
                    count++;
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Перестановка выполнена успешно!");
            return;
        }//Меняем местами
        static void SortArr(ref int[] arr, int size)
        {
            int j, el;
            for(int i = 1; i<size; i++)
            {
                el = arr[i];
                j = i - 1;
                while(j>=0 && el < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = el;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив успешно отсортирован!");
            return;
        }//Сортировка массива
        static void AddArr(ref int[] arr, ref int size)
        {
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) || k<0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите целое положительное число.");//Remake
                Console.ForegroundColor = ConsoleColor.White;
            }
            int newSize = size + k;
            int[] newArr = new int[newSize];
            for(int i = newSize; i > k; i--)
            {
                newArr[i-1] = arr[i - k-1];
            }
            Console.WriteLine("Вводите по очереди элементы массива.");
            for(int i = 0; i<k; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out newArr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нужно ввести целое число, повторите ввод");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            arr = newArr;
            size = newSize;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Указанные элементы были успешно добавлены в массив!");
            return;
        }  // Добавление элемента
        static void DeleteArr(ref int[] arr, ref int size)
        {
            Console.WriteLine("Введите номер элемента массива, который хотите удалить");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number >= size+1 || number < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (number >= size+1 || number < 1)
                {
                    Console.WriteLine("Номер выходит за границы массива. Повторите ввод.");
                }
                else
                {
                    Console.WriteLine("Введите целое положительное число.");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            for(int i = number-1; i < size-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            size = size - 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Указанный элемент был успешно удален из массива!");
            return;
        }//Удаление элемента
        static void OutputArr(ref int[] arr, int size)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }//Вывод элемента
        static void RandGeneration(ref int[] arr, int size)
        {
            Random a = new Random();
            for (int i = 0; i<size; i++)
            {
                arr[i] = a.Next(-100, 100);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив успешно сгенерирован!");
            return;

        } //Генерация массива
        static void InputElement(ref int[] arr, int size)
        {
            Console.WriteLine("Вводите по очереди элементы массива");
            for(int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нужно ввести целое число, повторите ввод");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return;
        } //Ввод с клавиатуры
        static void Main(string[] args)
        {
            int input=-1;
            while (input != 0)
            {
                Console.WriteLine("Добро пожаловать в программу обработки массивов!");
                Console.WriteLine("Выберите, как хотите получить массив:\n1.Сгенерировать массив\n2.Ввести с клавиатуры\n0.Выйти из программы");
                input = InputArr();
                if(input == 0)
                {
                    return;
                } //Проверка на выход
                Console.WriteLine("Введите количество элементов массива");

                int size = InputSize();
                
                int[] arr = new int[size];

                switch (input)
                {
                    case 1:
                        RandGeneration(ref arr, size);
                        break;
                    case 2:
                        InputElement(ref arr, size);
                        break;
                    default:
                        break;
                }

                while (input != 8)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nВыберите, что хотите сделать с массивом:\n1.Вывести массив" +
                    "\n2.Добавить элемент\n3.Удалить элемент\n4.Поменять местами элементы\n5.Отсортировать массив" +
                    "\n6.Поиск первого четного элемента массива\n7.Поиск первого четного элемента массива(Бинарный)\n8.Выйти в меню");
                    input = InputMenu();
                    if (input == 8)
                    {
                        break;
                    } //Проверка на выход

                    switch (input)
                    {
                        case 1:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            OutputArr(ref arr, size);//Вывод элемента
                            break;
                        case 2:
                            Console.WriteLine("Введите количество элементов, которые хотите добавить в массив");
                            AddArr(ref arr, ref size);
                            break;
                        case 3:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            DeleteArr(ref arr, ref size);//Удаление элемента
                            break;
                        case 4:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            Transposition(ref arr, size);
                            break;
                        case 5:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            SortArr(ref arr, size);
                            break;
                        case 6:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            int number = SearchEl(arr, size);
                            if (number % 2 == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Первый четный элемент массива = {number}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Четных элементов в массиве нет.");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 7:
                            if (size == 0)
                            {
                                Console.WriteLine("Массив является пустым, добавьте в него элементы.");
                                break;
                            }
                            BinarySearch(arr, size);//Поиск бинарный
                            break;
                        default:
                            break;
                    }
                }  
            }
            Console.ReadLine();
        }
    }
}
