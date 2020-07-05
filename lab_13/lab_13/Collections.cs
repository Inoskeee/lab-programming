using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab_13
{
    public class MyCollection<T> : List<Challenge>, IEnumerable<T>
    {
        public int Length
        {
            get
            {
                return list.Count;
            }
        }
        List<Challenge> list;

        public MyCollection()
        {
            list = new List<Challenge>();
        }
        public MyCollection(int size)
        {
            list = new List<Challenge>();
            for (int i = 0; i < size; i++)
            {
                Challenge element = new Challenge();
                list.Add(element);
            }
        }
        public MyCollection(MyCollection<T> collection)
        {
            list = collection.list;
        }

        public void Add()
        {
            Challenge item = new Challenge();
            list.Add(item);
        }
        public bool Delete(int position)
        {
            if(list.Count < position || position < 0)
            {
                return false;
            }
            else
            {
                list.RemoveAt(position);
                return true;
            }

        }
        public new void Sort()
        {
            list.Sort();
        }
        new public void Clear()
        {
            list.Clear();
        }
        public new IEnumerator GetEnumerator()
        {
            foreach(var item in list)
            {
                yield return item;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }

    //Объявляем делегат
    public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
    public class MyNewCollection<T> : MyCollection<T>
    {
        public string Name { get; set; }
        public List<Challenge> list;
        public MyNewCollection()
        {
            list = new List<Challenge>();
        }
        public MyNewCollection(int size)
        {
            list = new List<Challenge>(size);
            for (int i = 0; i < size; i++)
            {
                Challenge element = new Challenge();
                list.Add(element);
            }
        }
        public MyNewCollection(MyNewCollection<T> collection)
        {
            list = collection.list;
        }

        public void AddDefaults()
        {
            Challenge item = new Challenge();
            list.Add(item);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Add", list[list.IndexOf(item)]));
            //Console.WriteLine(new CollectionHandlerEventArgs(this.Name, "Add", list[list.IndexOf(item)]));
        }
        new public void Add(Challenge item)
        {
            list.Add(item);
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Add", list[list.IndexOf(item)]));
            //Console.WriteLine(new CollectionHandlerEventArgs(this.Name, "Add", list[list.IndexOf(item)]));
        }
        public bool Remove(int position)
        {
            if (list.Count < position || position < 0)
            {
                return false;
            }
            else
            {
                OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "Add", list[position]));
                //Console.WriteLine(new CollectionHandlerEventArgs(this.Name, "Add", list[position]));
                list.RemoveAt(position);
                return true;
            }
        }
        public void ChangeValue(int position)
        {
            OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this.Name, "Changed", list[position]));
            list[position] = new Challenge();
        }

        //индексатор
        public new Challenge this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this.Name, "Changed", list[index]));
                list[index] = value;
            }
        }


        //происходит при добавлении нового элемента или при удалении элемента из коллекции
        public event CollectionHandler CollectionCountChanged;
        //объекту коллекции присваивается новое значение       
        public event CollectionHandler CollectionReferenceChanged;

        //обработчик события CollectionCountChanged
        public void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            if(CollectionCountChanged != null)
            {
                CollectionCountChanged(source, args);
            }
        }
        //обработчик события OnCollectionReferenceChanged
        public void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChanged != null)
            {
                CollectionReferenceChanged(source, args);
            }
        }

        //Вывод элементов коллекции
        public void Show()
        {
            Console.WriteLine($"Коллекция {Name}:");
            foreach (var item in this.list)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class CollectionHandlerEventArgs : System.EventArgs
    {
        public string NameCollection { get; set; }
        public string ChangeType { get; set; }
        public object Object { get; set; }

        public CollectionHandlerEventArgs(string name, string type, object obj)
        {
            NameCollection = name;
            ChangeType = type;
            Object = obj;
        }

        public override string ToString()
        {
            return "Имя коллекции: " + NameCollection + "\nТип изменения: " + ChangeType + "\nОбъект: " + Object;
        }
    }

    public class Journal
    {
        private List<JournalEntry> journal;

        public Journal()
        {
            journal = new List<JournalEntry>();
        }

        public void CollectionCountChanged(object source, CollectionHandlerEventArgs arg)
        {
            JournalEntry jur = new JournalEntry(arg.NameCollection, arg.ChangeType, arg.Object.ToString());
            journal.Add(jur);
        }
        public void CollectionReferenceChanged(object source, CollectionHandlerEventArgs arg)
        {
            JournalEntry jur = new JournalEntry(arg.NameCollection, arg.ChangeType, arg.Object.ToString());
            journal.Add(jur);
        }
        public override string ToString()
        {
            foreach (var item in journal)
            {
                Console.WriteLine(item.ToString());
            }
            return "";
        }
    }

    public class JournalEntry
    {
        public string Name { get; set; }
        public string TypeOfChange { get; set; }
        public string ObjectData { get; set; }

        public JournalEntry(string name, string change, string data)
        {
            Name = name;
            TypeOfChange = change;
            ObjectData = data;
        }

        public override string ToString()
        {
            return "Имя коллекции: " + Name + "\nТип изменения: " + TypeOfChange + "\nОбъект: " + ObjectData;
        }
    }

}