using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace lab_12
{
    public class Point<T>
    {
        public T Data { get; set; }
        public Point<T> Next { get; set; }

        public Point()
        {
            Next = null;
            Data = default(T);
        }
        public Point(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString() + " ";
        }

    }
    public class DuplexPoint<T>
    {
        public T Data { get; set; }
        public DuplexPoint<T> Next { get; set; }
        public DuplexPoint<T> Previous { get; set; }

        public DuplexPoint()
        {
            Next = null;
            Previous = null;
            Data = default(T);
        }
        public DuplexPoint(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public override string ToString()
        {
            return Data.ToString() + " ";
        }

    }
    public class List<T> : IEnumerable<T>
    {
        public Point<T> Head { get; set; }
        public Point<T> Tail { get; set; }
        public int Count { get; private set; }


        public List()
        {
            Clear();
        }
        public List(T data)
        {
            Point<T> item = new Point<T>(data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            Point<T> item = new Point<T>(data);

            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }// Добавление элемента

        public void AddAt(T data, T item)
        {
            Point<T> newData = new Point<T>(item);
            if(Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    newData.Next = Head.Next;
                    Head.Next = newData;
                    Count++;
                    return;
                }

                Point<T> current = Head.Next;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        newData.Next = current.Next;
                        current.Next = newData;
                        Count++;
                        if (newData.Next == null) { Tail = newData; }
                        return;
                    }
                    current = current.Next;
                }

                Console.WriteLine("Элемент не найден!");
            }
        } // Добавление элемента после заданного информационного поля

        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                Point<T> current = Head.Next;
                Point<T> previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if (Tail.Data.Equals(data))
                        {
                            previous.Next = current.Next;
                            Tail = previous;
                            Count--;
                            return;
                        }
                        else
                        {
                            previous.Next = current.Next;
                            Count--;
                            return;
                        }
                    }
                    previous = current;
                    current = current.Next;
                }

                Console.WriteLine("Элемент не найден!");
            }
            Console.WriteLine("Список пуст!");
        }// Удаление элемента списка

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }// Очистка списка

        private void SetHeadAndTail(Point<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
    public class LinkedList<T> : IEnumerable<T>
    {
        public DuplexPoint<T> Head { get; private set; }
        public DuplexPoint<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }
        public LinkedList(T data)
        {
            DuplexPoint<T> item = new DuplexPoint<T>(data);
            SetHeadAndTail(item);

        }

        public void Add(T data)
        {
            DuplexPoint<T> item = new DuplexPoint<T>(data);
            if (Count == 0) SetHeadAndTail(item);
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
        }
        public void Delete(T data)
        {
            DuplexPoint<T> current = Head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (Head.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        Count--;
                        return;
                    }
                    else
                    {
                        Head = current.Next;
                        Head.Previous = null;
                        Count--;
                        return;
                    }
                }

                current = current.Next;
            }

            Console.WriteLine("Элемент не найден!");
        }
        public void DeleteEven()
        {
            DuplexPoint<T> current = Head;
            int check = 1;
            if(current == null)
            {
                Console.WriteLine("Список пуст!");
            }
            while (current != null)
            {
                if (check%2==0)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                }
                check++;
                current = current.Next;
            }
            Console.WriteLine("Элементы были удалены!");
            return;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(DuplexPoint<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }

    //Binary Tree
    public class Node<T> : IComparable
        where T:IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node() { }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Right = right;
            Left = left;
        }
        
        public int CompareTo(object obj)
        {
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception("Несовпадение типов"); 
            }
        }
        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }

        
    }
    public class Tree<T> : IEnumerable<T>
        where T:IComparable
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }
        
        public static void CountSearch(Node<T> root, char element, ref Tree<T> tree)
        {
            if(root != null)
            {
                if(root.Data.ToString()[0].CompareTo(element) == 0)
                {
                    tree.Count++;
                }
                CountSearch(root.Left, element, ref tree);
                CountSearch(root.Right, element, ref tree);
            }
            
        }
        static void ShowTree(Node<T> node, int number)
        {
            if (node != null)
            {
                ShowTree(node.Left, number + 3);
                for (int i = 0; i < number; i++)
                    Console.Write(" ");
                Console.WriteLine(node.Data);
                ShowTree(node.Right, number + 3);
            }
        }
        public void Show()
        {
            if (Root == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                ShowTree(Root, 5);
            }  

        }

        public static Node<T> Add(ref Node<T> root, T d)
        {
            Node<T> p = root;
            Node<T> r = null;
            if (root.Data == null)
            {
                root = new Node<T>(d);
                return root;
            }
            else
            {
                bool ok = false;
                while (p != null && !ok)
                {
                    r = p;
                    if (d.CompareTo(p.Data) == 0) ok = true;
                    else
                    if (d.CompareTo(p.Data) < 0) p = p.Left;
                    else p = p.Right;
                }
                if (ok) return p;
                Node<T> NewPoint = new Node<T>(d);
                if (d.CompareTo(r.Data) < 0) r.Left = NewPoint;
                else r.Right = NewPoint;
                return NewPoint;
            }
        }
        public static Node<Challenge> IdealTree(int size, Node<Challenge> node)
        {
            Node<Challenge> r;
            int nl, nr;
            if (size == 0) { node = null; return node; }
            nl = size / 2;
            nr = size - nl - 1;
            r = new Node<Challenge>(new Challenge());
            for(int i = 0; i<size; i++)
            {
                r.Left = IdealTree(nl, r.Left);
                r.Right = IdealTree(nr, r.Right);
            }
            
            return r;
        }
        public static void CreateSeachTree(Node<T> p, ref Node<T> newTree)
        {
            if(p != null)
            {
                Add(ref newTree, p.Data);
                CreateSeachTree(p.Left, ref newTree);
                CreateSeachTree(p.Right, ref newTree);
            }
            else
            {

            }
        }

        public IEnumerator<T> InOrderTraversal()
        {
            if (Root != null)
            {
                Stack<Node<T>> stack = new Stack<Node<T>>();

                Node<T> current = Root;
                bool goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {

                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    yield return current.Data;

                    if (current.Right != null)
                    {
                        current = current.Right;
                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }

    //Собственная коллекция
    public class MyStack<T> : IEnumerable<Challenge>, ICloneable
    {
        private List<Challenge> items;
        public int Count
        {
            get { return items.Count;  }
        }
        public MyStack()
        {
            items = new List<Challenge>();
        }
        public MyStack(int size)
        {
            items = new List<Challenge>();
            for(int i = 0; i < size; i++)
            {
                Challenge test = new Challenge();
                items.Add(test);
            }
        }
        public MyStack(MyStack<T> list)
        {
            items = new List<Challenge>();
            Point<Challenge> test = list.items.Head;
            for (int i = 0; i < list.Count; i++)
            {
                items.Add(test.Data);
                test = test.Next;
            }
        }


        public void Push(Challenge data)
        {
            items.Add(data);
        }
        public Challenge Pop()
        {
            if (Count > 0)
            {
                items.Delete(items.Tail.Data);
                return items.Tail.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        public Challenge Peek()
        {
            if (Count > 0)
            {
                return items.Tail.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }


        public void Copy(ref MyStack<T> two)
        {
            two = this;
        }
        public void Clear()
        {
            items.Clear();
        }
        public void Search(Challenge data)
        {
            foreach(Challenge item in items)
            {
                if (item.Equals(data))
                {
                    Console.WriteLine("Элемент найден!");
                    return;
                }
            }
            Console.WriteLine("Элемент не найден!");
        }


        public IEnumerator<Challenge> GetEnumerator()
        {
            var current = items.Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public object Clone()
        {
            MyStack<Challenge> clone = new MyStack<Challenge>();
            
            Point<Challenge> test = this.items.Head;
            for (int i = 0; i < this.Count; i++)
            {
                clone.items.Add(test.Data);
                test = test.Next;
            }
            return clone;
        }
    }
}
