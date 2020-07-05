using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Демонстрация_коллекции
            //MyCollection<Challenge> list = new MyCollection<Challenge>(15);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Sort();

            //Console.WriteLine("СОРТИРОВАННЫЙ СПИСОК:");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            MyNewCollection<Challenge> list1 = new MyNewCollection<Challenge>();
            MyNewCollection<Challenge> list2 = new MyNewCollection<Challenge>();
            list1.Name = "First Collection";
            list2.Name = "Second Collenction";

            Journal jour1 = new Journal();
            Journal jour2 = new Journal();

            list1.CollectionCountChanged += new CollectionHandler(jour1.CollectionCountChanged);
            list1.CollectionReferenceChanged += new CollectionHandler(jour1.CollectionReferenceChanged);

            list1.CollectionReferenceChanged += new CollectionHandler(jour2.CollectionReferenceChanged);
            list2.CollectionReferenceChanged += new CollectionHandler(jour2.CollectionReferenceChanged);

            list1.AddDefaults();
            list1.AddDefaults();
            list1.AddDefaults();
            list1.AddDefaults();

            list2.AddDefaults();
            list2.AddDefaults();
            list2.AddDefaults();
            list2.AddDefaults();

            list1.Remove(1);
            list2.Remove(2);


            list1.ChangeValue(2);
            list2.ChangeValue(1);

            list1.Add(new Challenge("Владимир", "История", true));

            list1.Show();
            Console.WriteLine();
            list2.Show();

            Console.WriteLine();
            Console.WriteLine("Journal №1");
            Console.WriteLine();
            jour1.ToString();
            Console.WriteLine();
            Console.WriteLine("Journal №2");
            Console.WriteLine();
            jour2.ToString();



            Console.ReadKey();
        }
    }
}
