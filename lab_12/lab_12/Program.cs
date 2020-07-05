using System;
using System.Diagnostics;

namespace lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Однонаправленный список

            //Test element = new Test();

            //List<Challenge> list = new lab_12.List<Challenge>()
            //{
            //    new Test(),
            //    new Test("Алексей", "Математика", "Уравнения", 16, 12),
            //    new Test(),
            //    new Test()
            //};

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //list.AddAt(element, new Test("W", "W", "W", 25, 25));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //list.Clear();
            //if (list.Count == 0) Console.WriteLine("Список был очищен!");


            #endregion

            #region Двунаправленный список

            //LinkedList<Challenge> linkedList = new LinkedList<Challenge>()
            //{
            //    new Test()
            //};

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //linkedList.DeleteEven();

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //linkedList.Clear();
            //Console.WriteLine("Список был очищен!");
            #endregion

            #region Дерево

            //Tree<Challenge> tree = new Tree<Challenge>();

            //Идеальное сбалансированное дерево
            //Node<Challenge> node = new Node<Challenge>(new Challenge());
            //Node<Challenge> data = Tree<Challenge>.IdealTree(10, node);
            //tree.Root = data;
            //tree.Show();

            //Console.WriteLine();

            //Преобразуем в деверо поиска
            //Tree<Challenge> searchTree = new Tree<Challenge>();
            //Node<Challenge> new_data = new Node<Challenge>();

            //Tree<Challenge>.CreateSeachTree(data, ref new_data);
            //searchTree.Root = new_data;
            //searchTree.Show();
            //Console.WriteLine();

            //Tree<Challenge>.CountSearch(new_data, 'А', ref searchTree);
            //Console.WriteLine(searchTree.Count);

            #endregion

            #region Stack
            MyStack<Challenge> stack = new MyStack<Challenge>(5);
            stack.Push(new Challenge());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Challenge item1 = stack.Peek();
            Challenge item2 = stack.Pop();

            Console.WriteLine($"Peek: {item1},\nPop: {item2}");

            Console.WriteLine();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //MyStack<Challenge> stack2 = (MyStack<Challenge>)stack.Clone();
            //stack.Clear();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in stack2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            MyStack<Challenge> stack2 = new MyStack<Challenge>();
            stack.Copy(ref stack2);
            stack.Clear();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Test test = new Test("W", "WM", "WF", 80, 77);

            stack.Push(test);

            stack.Search(test);
            stack2.Search(test);

            #endregion

            Console.ReadLine();
        }

    }
}
