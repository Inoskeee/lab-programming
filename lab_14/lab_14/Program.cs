using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace lab_14
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Test> list = new MyCollection<Test>(20);

            Success(list);

            Counter(list);

            Fails(list);

            MaxAndMin(list);

            Console.ReadLine();
        }

        //Запрос на выборку
        public static void Success(MyCollection<Test> list)
        {
            //Все студенты сдавшие тест(LINQ)
            var result = from item in list.list
                         where item.Done == true
                         select item;
            Console.WriteLine("Все студенты сдавшие тест");

            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            //Метод расширения
            var result2 = list.list.Where(item => item.Done==true);

            if (result.Count() == result2.Count())
            {
                Console.WriteLine("\nРезультаты LINQ запроса и метода расширения совпадают.\n");
            }
        }

        //Получение счетчика
        public static void Counter(MyCollection<Test> list)
        {
            //Количество студентов решавших математику(LINQ)
            int result = (from item in list.list
                           where item.Subject == "Математика"
                           select item).Count();
            //Метод расширения
            int result2 = list.list.Where(item => item.Subject == "Математика").Count();

            Console.WriteLine("\nКоличество студентов решавших математику");
            Console.WriteLine(result);

            if(result == result2)
            {
                Console.WriteLine("\nРезультаты LINQ запроса и метода расширения совпадают.\n");
            }
        }

        //Операции над множествами
        public static void Fails(MyCollection<Test> list)
        {
            //Студенты которые писали тест больше чем из 5 вопросов и не сдали его
            //LINQ - запрос
            var first = from item in list.list
                         where item.Done == false
                         select item;
            var second = from item in list.list
                         where item.QuestCount >= 5
                         select item;
            var result = (first).Intersect(second);

            Console.WriteLine("Студенты которые писали тест больше чем из 5 вопросов и не сдали его");

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            //Метод расширения
            var first2 = list.list.Where(item => item.Done == false);
            var second2 = list.list.Where(item => item.QuestCount >= 5);
            var result2 = (first2).Intersect(second2);

            if(result == result2)
            {
                Console.WriteLine("\nРезультаты LINQ запроса и метода расширения совпадают.\n");
            }


        }

        //Агрегирование данных
        public static void MaxAndMin(MyCollection<Test> list)
        {
            //Агрегирование данных
            //Тест с самым большим колличеством вопросов
            Console.WriteLine("\nБольше всего вопросов: {0}", (from item in list.list select item.QuestCount).Max());
            //Тест с наименьшим колличеством вопросов
            Console.WriteLine("\nМеньше всего вопросов: {0}", (list.list.Where(item => item.QuestCount >= 0).Min().QuestCount));
        }
    }
}
