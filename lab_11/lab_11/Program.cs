using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Задание 1\n2. Задание 2\n3. Задание 3\n0. Выйти");
            int input_0;
            while (!int.TryParse(Console.ReadLine(), out input_0) || (input_0 < 0 && input_0 > 3))
            {
                Console.WriteLine("Повторите ввод.");
            }

            //Коллекция 1
            List<Challenge> testObj = new List<Challenge>()
            {
                new Test("Иван", "Математика", "Производные", 13, 18),
                new Test("Дмитрий", "Дискретная математика", "Графы", 25, 18),
                new Exam("Алексей", "Программирование", 30, 1),
            };

            //Коллекция 2
            SortedDictionary<int, Challenge> objects = new SortedDictionary<int, Challenge>()
            {
                {1, new Test("Иван", "Математика", "Производные", 13, 18) },
                {2, new Test("Алексей", "Дискретная математика", "Графы", 25, 18) },
                {3, new Exam("Алексей", "Программирование", 30, 1) }
            };

            while (input_0 != 0)
            {
                int input;
                switch (input_0)
                {
                    case 0:
                        return;
                    case 1:
                        //Задание 1
                        Console.WriteLine("-----------------\n\n" +
                            "1. Вывод элементов\n" +
                            "2. Добавить элементы\n" +
                            "3. Удалить элементы\n" +
                            "4. Количество элементов\n" +
                            "5. Вывод элементов определенного типа\n" +
                            "6. Удаление элементов определенного типа\n" +
                            "7. Сортировка коллекции и поиск элемента\n" +
                            "8. Клонирование коллекции\n" +
                            "0. Выйти");
                        while (!int.TryParse(Console.ReadLine(), out input) || (input < 0 && input > 8))
                        {
                            Console.WriteLine("Повторите ввод.");
                        }
                        switch (input)
                        {
                            case 0:
                                return;
                            case 1:
                                Print(testObj);
                                break;
                            case 2:
                                AddEl(ref testObj);
                                break;
                            case 3:
                                RemoveEl(ref testObj);
                                break;
                            case 4:
                                CountSpecEl(testObj);
                                break;
                            case 5:
                                PrintSpecEl(testObj);
                                break;
                            case 6:
                                RemoveSpecEl(ref testObj);
                                break;
                            case 7:
                                testObj.Sort();
                                Console.WriteLine("Коллекция успешно отсортирована.");
                                Test forSearch = new Test("Сергей", "Дискретная математика", "Графы", 25, 18);
                                int search;
                                search = testObj.BinarySearch(forSearch);
                                if(search >= 0)
                                {
                                    Console.WriteLine($"Объект {forSearch} найден");
                                }
                                else
                                {
                                    Console.WriteLine($"Объект {forSearch} не найден");
                                }
                                break;
                            case 8:
                                List<Challenge> list = new List<Challenge>();
                                foreach(Challenge el in testObj)
                                {
                                    list.Add(el);
                                }
                                Console.Clear();
                                Console.WriteLine("Клон коллекции:");
                                Print(list);
                                break;
                        }
                        break;
                    case 2:
                        //Задание 2
                        Console.WriteLine("-----------------\n\n" +
                            "1. Вывод элементов\n" +
                            "2. Добавить элементы\n" +
                            "3. Удалить элементы\n" +
                            "4. Количество элементов\n" +
                            "5. Вывод элементов определенного типа\n" +
                            "6. Удаление элементов определенного типа\n" +
                            "7. Сортировка коллекции и поиск элемента\n" +
                            "8. Клонирование коллекции\n" +
                            "0. Выйти");
                        while (!int.TryParse(Console.ReadLine(), out input) || (input < 0 && input > 8))
                        {
                            Console.WriteLine("Повторите ввод.");
                        }
                        switch (input)
                        {
                            case 0:
                                return;
                            case 1:
                                Print(objects);
                                break;
                            case 2:
                                AddEl(ref objects);
                                break;
                            case 3:
                                RemoveEl(ref objects);
                                break;
                            case 4:
                                CountSpecEl(objects);
                                break;
                            case 5:
                                PrintSpecEl(objects);
                                break;
                            case 6:
                                RemoveSpecEl(ref objects);
                                break;
                            case 7:

                                Test forSearch = new Test("Алексей", "Дискретная математика", "Графы", 25, 18);
                                if (objects.Values.Contains(forSearch))
                                {
                                    Console.WriteLine($"Объект {forSearch} найден");
                                }
                                else
                                {
                                    Console.WriteLine($"Объект {forSearch} не найден");
                                }

                                break;
                            case 8:
                                SortedDictionary<int, Challenge> list = new SortedDictionary<int, Challenge>();
                                foreach(int keyValue in objects.Keys)
                                {
                                    list.Add(keyValue, objects[keyValue]);
                                }
                                Console.Clear();
                                Console.WriteLine("Клон коллекции:");
                                Print(list);
                                break;
                        }
                        break;
                    case 3:
                        //Задание 3

                        TestCollections tst = new TestCollections(150);

                        Test first = null;
                        Test middle = null;
                        Test last = null;

                        for (int i = 0; i < tst.Size; i++)
                        {

                            if (i == 0)
                            {
                                first = (Test)tst.listStudents[i].Clone();
                            }
                            else if (i == tst.Size / 2)
                            {
                                middle = (Test)tst.listStudents[i].Clone();
                            }
                            else if (i == tst.Size - 1)
                            {
                                last = (Test)tst.listStudents[i].Clone();
                            }

                        }


                        tst.PrintList();
                        tst.PrintDict();


                        Stopwatch stopWatch = new Stopwatch();

                        Console.WriteLine("Поиск в списке:");

                        if (tst.listStudents.Contains(first))
                        {
                            Console.WriteLine($"Элемент {first} найден");
                           
                            stopWatch.Restart();
                            tst.listStudents.Contains(first);
                            stopWatch.Stop();
                            long testList = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringList.Contains(first.ToString());
                            stopWatch.Stop();
                            long testLString = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.dictStudents.ContainsValue(first);
                            stopWatch.Stop();
                            long testDict = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringDict.ContainsValue(first);
                            stopWatch.Stop();
                            long testDString = stopWatch.Elapsed.Ticks;

                            Console.WriteLine($"Поиск первого элемента в List: {testList} \n" +
                                $"поиск первого элемента в SortedDict: {testDict} \n" +
                                $"поиск первого элемента в List<str>: {testLString} \n" +
                                $"поиск первого элемента в SortedDict<str, Test>: {testDString}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"Элемент {first} не найден");
                        }

                        if (tst.listStudents.Contains(middle))
                        {
                            Console.WriteLine($"Элемент {middle} найден");
                            stopWatch.Restart();
                            tst.listStudents.Contains(middle);
                            stopWatch.Stop();
                            long testList = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringList.Contains(middle.ToString());
                            stopWatch.Stop();
                            long testLString = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.dictStudents.ContainsValue(middle);
                            stopWatch.Stop();
                            long testDict = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringDict.ContainsValue(middle);
                            stopWatch.Stop();
                            long testDString = stopWatch.Elapsed.Ticks;

                            Console.WriteLine($"Поиск первого элемента в List: {testList} \n" +
                                $"поиск первого элемента в SortedDict: {testDict} \n" +
                                $"поиск первого элемента в List<str>: {testLString} \n" +
                                $"поиск первого элемента в SortedDict<str, Test>: {testDString}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"Элемент {middle} не найден");
                        }

                        if (tst.listStudents.Contains(last))
                        {
                            Console.WriteLine($"Элемент {last} найден");
                            stopWatch.Restart();
                            tst.listStudents.Contains(last);
                            stopWatch.Stop();
                            long testList = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringList.Contains(last.ToString());
                            stopWatch.Stop();
                            long testLString = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.dictStudents.ContainsValue(last);
                            stopWatch.Stop();
                            long testDict = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringDict.ContainsValue(last);
                            stopWatch.Stop();
                            long testDString = stopWatch.Elapsed.Ticks;

                            Console.WriteLine($"Поиск первого элемента в List: {testList} \n" +
                                $"поиск первого элемента в SortedDict: {testDict} \n" +
                                $"поиск первого элемента в List<str>: {testLString} \n" +
                                $"поиск первого элемента в SortedDict<str, Test>: {testDString}");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"Элемент {last} не найден");
                        }

                        Test nothing = new Test("a", "b", "c", 2, 1);

                        if (!tst.listStudents.Contains(nothing))
                        {
                            Console.WriteLine($"Элемент {nothing} не найден");
                            stopWatch.Restart();
                            tst.listStudents.Contains(nothing);
                            stopWatch.Stop();
                            long testList = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringList.Contains(nothing.ToString());
                            stopWatch.Stop();
                            long testLString = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.dictStudents.ContainsValue(nothing);
                            stopWatch.Stop();
                            long testDict = stopWatch.Elapsed.Ticks;

                            stopWatch.Restart();
                            tst.stringDict.ContainsValue(nothing);
                            stopWatch.Stop();
                            long testDString = stopWatch.Elapsed.Ticks;

                            Console.WriteLine($"Поиск первого элемента в List: {testList} \n" +
                                $"поиск первого элемента в SortedDict: {testDict} \n" +
                                $"поиск первого элемента в List<str>: {testLString} \n" +
                                $"поиск первого элемента в SortedDict<str, Test>: {testDString}");
                            Console.WriteLine("----------------------------------------------");
                        }

                        Console.WriteLine("Поиск в словаре:");

                        if (tst.dictStudents.Values.Contains(first)) Console.WriteLine($"Элемент {first} найден");
                        else Console.WriteLine($"Элемент {first} не найден");
                        if (tst.dictStudents.Values.Contains(middle)) Console.WriteLine($"Элемент {middle} найден");
                        else Console.WriteLine($"Элемент {middle} не найден");
                        if (tst.dictStudents.Values.Contains(last)) Console.WriteLine($"Элемент {last} найден");
                        else Console.WriteLine($"Элемент {last} не найден");

                        input_0 = -1;
                        break;
                }
            }
            Console.ReadLine();
        }

        //Задание 1
        static void Print(List<Challenge> list)
        {
            foreach(object el in list)
            {
                Challenge obj = el as Challenge;
                if(obj != null)
                {
                    obj.Show();
                }
            }
        }

        static void AddEl(ref List<Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите название предмета:");
            string subj = Console.ReadLine();
            Console.WriteLine("Введите количество вопросов испытания:");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Повторите ввод.");
            }
            Console.WriteLine("Введите результат испытания:");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Повторите ввод.");
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("Введите тему теста:");
                    string theme = Console.ReadLine();
                    list.Add(new Test(name, subj, theme, count, result));
                    break;
                case 2:
                    list.Add(new Exam(name, subj, count, result));
                    break;
            }
            Console.WriteLine("Объект успешно добавлен!");
        }

        static void RemoveEl(ref List<Challenge> list)
        {
            Console.WriteLine("Введите порядковый номер удаляемого элемента:");
            int currentEl;
            while (!int.TryParse(Console.ReadLine(), out currentEl) || !(currentEl >= 1 && currentEl <= list.Count))
            {
                Console.WriteLine("Повторите ввод.");
            }
            list.RemoveAt(currentEl-1);
            Console.WriteLine("Элемент успешно удален");
        }

        static List<Challenge> RemoveSpecEl(ref List<Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            List<Challenge> newList = new List<Challenge>();
            switch (input)
            {
                case 1:
                    foreach (Challenge el in list)
                    {
                        if (el is Exam)
                        {
                            newList.Add(el);
                        }
                    }
                    list =  newList;
                    break;
                case 2:
                    foreach (Challenge el in list)
                    {
                        if (el is Test)
                        {
                            newList.Add(el);
                        }
                    }
                    list = newList;
                    break;
            }
            Console.WriteLine("Элементы успешно удалены");
            return list;
        }

        static void CountSpecEl(List<Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            int count = 0;
            switch (input)
            {
                case 1:
                    foreach (object el in list)
                    {
                        Test obj = el as Test;
                        if (obj != null)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Количество элементов типа Test: " + count);
                    break;
                case 2:
                    foreach (object el in list)
                    {
                        Exam obj = el as Exam;
                        if (obj != null)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Количество элементов типа Exam: " + count);
                    break;
            }
        }

        static void PrintSpecEl(List<Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            switch (input)
            {
                case 1:
                    foreach (object el in list)
                    {
                        Test obj = el as Test;
                        if (obj != null)
                        {
                            obj.Show();
                        }
                    }
                    break;
                case 2:
                    foreach (object el in list)
                    {
                        Exam obj = el as Exam;
                        if (obj != null)
                        {
                            obj.Show();
                        }
                    }
                    break;
            }
        }

        //Задание 2
        static void Print(SortedDictionary<int, Challenge> list)
        {
            foreach (KeyValuePair<int, Challenge> keyValue in list)
            {
                Challenge obj = keyValue.Value as Challenge;
                if (obj != null)
                {
                    obj.Show();
                }
            }
        }
        static void AddEl(ref SortedDictionary<int, Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите название предмета:");
            string subj = Console.ReadLine();
            Console.WriteLine("Введите количество вопросов испытания:");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Повторите ввод.");
            }
            Console.WriteLine("Введите результат испытания:");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Повторите ввод.");
            }

            switch (input)
            {
                case 1:
                    Console.WriteLine("Введите тему теста:");
                    string theme = Console.ReadLine();
                    if (list.Count != 0)
                    {
                        list.Add(list.Keys.Max() + 1, new Test(name, subj, theme, count, result));
                    }
                    else
                    {
                        list.Add(1, new Test(name, subj, theme, count, result));
                    }
                    break;
                case 2:
                    if(list.Count != 0)
                    {
                        list.Add(list.Keys.Max() + 1, new Exam(name, subj, count, result));
                    }
                    else
                    {
                        list.Add(1, new Exam(name, subj, count, result));
                    }
                    break;
            }
            Console.WriteLine("Объект успешно добавлен!");
        }
        static void RemoveEl(ref SortedDictionary<int, Challenge> list)
        {
            Console.WriteLine("Введите ключ удаляемого элемента:");
            int currentEl;
            while (!int.TryParse(Console.ReadLine(), out currentEl) || !list.ContainsKey(currentEl))
            {
                Console.WriteLine("Повторите ввод.");
            }
            list.Remove(currentEl);
            Console.WriteLine("Элемент успешно удален");
        }
        static SortedDictionary<int, Challenge> RemoveSpecEl(ref SortedDictionary<int, Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            int count = 0;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            SortedDictionary<int, Challenge> newList = new SortedDictionary<int, Challenge>();
            switch (input)
            {
                case 1:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        if (keyValue.Value is Exam)
                        {
                            count += 1;
                            newList.Add(count, keyValue.Value);
                        }
                    }
                    list = newList;
                    break;
                case 2:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        if (keyValue.Value is Test)
                        {
                            count += 1;
                            newList.Add(count, keyValue.Value);
                        }
                    }
                    list = newList;
                    break;
            }
            Console.WriteLine("Элементы успешно удалены");
            return list;
        }
        static void CountSpecEl(SortedDictionary<int, Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            int count = 0;
            switch (input)
            {
                case 1:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        Test obj = keyValue.Value as Test;
                        if (obj != null)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Количество элементов типа Test: " + count);
                    break;
                case 2:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        Exam obj = keyValue.Value as Exam;
                        if (obj != null)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Количество элементов типа Exam: " + count);
                    break;
            }
        }
        static void PrintSpecEl(SortedDictionary<int, Challenge> list)
        {
            Console.Clear();
            Console.WriteLine("Выберите тип элемента:");
            Console.WriteLine("1.Test\n2.Exam");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || (input < 1 && input > 2))
            {
                Console.WriteLine("Повторите ввод.");
            }
            switch (input)
            {
                case 1:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        Test obj = keyValue.Value as Test;
                        if (obj != null)
                        {
                            obj.Show();
                        }
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<int, Challenge> keyValue in list)
                    {
                        Exam obj = keyValue.Value as Exam;
                        if (obj != null)
                        {
                            obj.Show();
                        }
                    }
                    break;
            }
        }


    }
}
