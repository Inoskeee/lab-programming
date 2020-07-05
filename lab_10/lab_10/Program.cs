using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Challenge[] array = new Challenge[4];

            Test quest = new Test("Иван", "Математика", "Производные", 13, 18);
            array[0] = quest;
            Test test = new Test("Дмитрий", "Дискретная математика", "Графы", 25, 18);
            array[1] = test;
            Exam exam = new Exam("Алексей", "Программирование", 30, 1);
            array[2] = exam;
            ExitExam exExam = new ExitExam("Артем", "Физика", 25, 23, 1);
            array[3] = exExam;

            for (int i = 0; i<array.Length; i++)
            {
                array[i].Show();
            }
            Console.WriteLine("Введите название предмета:");
            string subject = Console.ReadLine();
            Console.WriteLine(Students(array, subject));
            Console.WriteLine(Students_Count(array) + " cтудентов");
            Console.WriteLine(Students_Fail(array) + " cтудентов");

            Console.ReadKey();
            Console.Clear();
            //Сортировка объектов
            Test_Sort();

            Console.ReadKey();
            Console.Clear();
            //Клонирование объектов
            Clone_Test();
            Console.ReadKey();
        }

        //Имена студентов, сдавших все (заданный) экзамены на отлично (хорошо и отлично).
        public static string Students(Challenge[] arr, string exam)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Имена студентов, сдавших экзамены по предмету "+exam+" на отлично");
            for(int i = 0; i < arr.Length; i++)
            {
                Exam ex = arr[i] as Exam;
                if (ex != null)
                {
                    if(ex.Subject == exam && (ex.Marker == "Хорошо" || ex.Marker == "Отлично"))
                    {
                        return ex.Name;
                    }
                }
            }
            return "";
        }
        public static string Students(Challenge[] arr)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Имена студентов, сдавших все экзамены на отлично");
            string name = "";
            List<string> names = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                Exam ex = arr[i] as Exam;
                if (ex != null)
                {
                    if (ex.Marker == "Хорошо" || ex.Marker == "Отлично")
                    {
                        if (!names.Contains(ex.Name))
                        {
                            names.Add(ex.Name);
                        }
                    }
                    else
                    {
                        if (!names.Contains(ex.Name))
                        {
                            names.Remove(ex.Name);
                        }
                    }
                }
            }
            for(int k = 0; k<names.Count; k++)
            {
                name = names[k];
            }
            return name;
        }

        //Количество студентов, сдавших все экзамены на отлично.
        public static int Students_Count(Challenge[] arr)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Количество студентов, сдавших все экзамены на отлично");
            List<string> names = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                Exam ex = arr[i] as Exam;
                if (ex != null)
                {
                    if (ex.Marker == "Хорошо" || ex.Marker == "Отлично")
                    {
                        if (!names.Contains(ex.Name))
                        {
                            names.Add(ex.Name);
                        }
                    }
                    else
                    {
                        if (!names.Contains(ex.Name))
                        {
                            names.Remove(ex.Name);
                        }
                    }
                }
            }
            return names.Count;
        }

        //Количество студентов, не сдавших хотя бы один экзамен.
        public static int Students_Fail(Challenge[] arr)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Количество студентов, не сдавших хотя бы один экзамен");
            List<string> names = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                Exam ex = arr[i] as Exam;
                if (ex != null)
                {
                    if (ex.Done == false)
                    {
                        if (!names.Contains(ex.Name))
                        {
                            names.Add(ex.Name);
                        }
                    }
                }
            }
            return names.Count;
        }

        //Различные сортировки объектов

        static void Exam_Sort()
        {
            Console.WriteLine("Сортировка по результату теста.");

            Exam[] array = new Exam[4];
            array[0] = new Exam("Алексей", "Программирование", 30, 44);
            array[1] = new Exam("Дмитрий", "Программирование", 30, 7);
            array[2] = new Exam("Иван", "Программирование", 30, 1);
            array[3] = new Exam("Сергей", "Программирование", 30, 4);

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Show();
            }
        }
        static void Test_Sort()
        {
            Console.WriteLine("Сортировка по имени");

            Test[] array = new Test[4];
            array[0] = new Test("Алексей", "Математика", "Производные", 13, 18);
            array[1] = new Test("Антон", "Математика", "Производные", 13, 18);
            array[2] = new Test("Михаил", "Математика", "Производные", 13, 18);
            array[3] = new Test("Василий", "Математика", "Производные", 13, 18);

            Array.Sort(array, new SortByName());

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Show();
            }
        }

        //Клонирование объектов

        static void Clone_Test()
        {
            Console.WriteLine("Клонирование объектов");

            Test[] array = new Test[4];
            array[0] = new Test("Алексей", "Математика", "Производные", 15, 10);
            array[1] = new Test("Антон", "История", "19 век", 13, 11);
            array[2] = new Test("Михаил", "Программирование", "Классы", 34, 28);
            array[3] = new Test("Василий", "Дискретная математика", "Графы", 5, 3);
            foreach(Test obj in array)
            {
                obj.Show();
            }
            Console.WriteLine("Объекты клоны: ");
            Test clone_1 = array[1].ShallowCopy();
            clone_1.Show();
            Test clone_2 = (Test)array[1].Clone();
            clone_2.Show();
        }
    }
}
