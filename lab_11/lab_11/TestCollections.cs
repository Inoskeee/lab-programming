using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11
{
    class TestCollections
    {
        public List<Test> listStudents = new List<Test>();
        public List<string> stringList = new List<string>();
        public SortedDictionary<Challenge, Test> dictStudents = new SortedDictionary<Challenge, Test>();
        public SortedDictionary<string, Test> stringDict = new SortedDictionary<string, Test>();

        public int Size { get; set; } 

        public TestCollections(int size)
        {
            Size = size;
            for (int i = 0; i < size; i++)
            {
                Test testS = new Test();
                listStudents.Add(testS);
                stringList.Add(testS.ToString());
                dictStudents.Add(testS.GetBaseChallenge(), testS);
                stringDict.Add(testS.ToString(), testS);
            }
        }

        public void PrintList()
        {
            Console.WriteLine("PRINT LIST");
            foreach (var item in listStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PrintDict()
        {
            Console.WriteLine("PRINT DICTIONARY");
            foreach (KeyValuePair<Challenge, Test> keyValue in dictStudents)
            {
                Challenge obj = keyValue.Value as Challenge;
                if (obj != null)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
        }

        public void AddDictionaryElem(ref SortedDictionary<Challenge, Test> list)
        {
            Console.Clear();
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
            Console.WriteLine("Введите тему теста:");
            string theme = Console.ReadLine();
            Test someTest = new Test(name, subj, theme, count, result);
            list.Add(someTest.GetBaseChallenge(), someTest);
            Console.WriteLine("Объект успешно добавлен!");
        }
        public void AddListElem(ref List<Test> list)
        {
            Console.Clear();
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

            string theme = Console.ReadLine();
            Test someTest = new Test(name, subj, theme, count, result);
            list.Add(someTest);
            Console.WriteLine("Объект успешно добавлен!");
        }

        public void DeleteListElem(ref List<Test> list)
        {
            Console.WriteLine("Введите порядковый номер удаляемого элемента:");
            int currentEl;
            while (!int.TryParse(Console.ReadLine(), out currentEl) || !(currentEl >= 1 && currentEl <= list.Count))
            {
                Console.WriteLine("Повторите ввод.");
            }
            list.RemoveAt(currentEl - 1);
            Console.WriteLine("Элемент успешно удален");
        }
        public void DeleteDictElem(ref SortedDictionary<Challenge, Test> list)
        {
            Console.Clear();
            Console.WriteLine("Введите ключ удаляемого элемента:");
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
            Console.WriteLine("Введите тему теста:");
            string theme = Console.ReadLine();
            Test currentEl = new Test(name, subj, theme, count, result);
            if (list.Values.Contains(currentEl))
            {
                list.Remove(currentEl.GetBaseChallenge());
            }
            Console.WriteLine("Элемент успешно удален");
        }

    }
}
