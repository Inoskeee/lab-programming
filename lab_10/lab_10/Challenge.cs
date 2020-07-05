using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{

    public abstract class Challenge
    {
        
        private string name;    //Имя студента
        private string subject; //Предмет испытания
        private bool done;      //Выполнено или нет

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public Challenge(string name, string subj, bool done)
        {
            Name = name;
            Subject = subj;
            Done = done;
        }
        public Challenge(string name, string subj)
        {
            Name = name;
            Subject = subj;
        }
        public Challenge()
        {
            name = "No Name";
            subject = "No Subject";
            done = false;
        }

        abstract public void Show();
    }

    public class Test : Challenge, IComparable, ICloneable
    {
        private int questCount;
        private string theme;
        private int result;


        public int QuestCount
        {
            get { return questCount; }
            set
            {
                if (value >= 0)
                {
                    questCount = value;
                }
                else
                {
                    questCount = 0;
                }
            }
        }
        public string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
            }
        }
        public int Result
        {
            get { return result; }
            set
            {
                result = value;
            }
        }

        public Test(string name, string subj, string theme, int count, int result) : base(name, subj)
        {
            QuestCount = count;
            Theme = theme;
            if(result <= count)
            {
                Result = result;
                if(result >= count / 2)
                {
                    Done = true;
                }
                else
                {
                    Done = false;
                }
            }
            else
            {
                Result = count;
                Done = true;
            }
        }
        public Test():base()
        {
            questCount = 0;
            theme = "No Theme";
        }

        public Test ShallowCopy() //Поверхностное копирование
        {
            return (Test)this.MemberwiseClone();
        }
        public object Clone() //Полное копирование
        {
            return new Test("Клон " + this.Name, this.Subject, this.Theme, this.QuestCount, this.Result);
        }
        public int CompareTo(object obj)
        {
            Test temp = (Test)obj;
            if (String.Compare(this.Name, temp.Name) > 0) return 1;
            if (String.Compare(this.Name, temp.Name) < 0) return -1;
            return 0;
        }

        public override void Show()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Тест: {Subject}, \nТема: {Theme}, \nКоличество вопросов: {questCount}, \nВыполнено: {Done}");
        }
    }


    public class Exam : Challenge, IComparable
    {
        private int questCount; //количество вопросов
        private int result;     //результат экзамена
        private bool essential; //обязательный или нет
        private string marker;

        public int QuestCount
        {
            get { return questCount; }
            set
            {
                if (value >= 0)
                {
                    questCount = value;
                }
                else
                {
                    questCount = 0;
                }
            }
        }
        public int Result
        {
            get { return result; }
            set
            {
                result = value;
            }
        }
        public bool Essential
        {
            get
            {
                return essential;
            }
            set
            {
                essential = value;
            }
        }

        public string Marker
        {
            get { return marker; }
            set { marker = value; }
        }

        public Exam(string name, string subj, int count, int result, bool essential) :base(name, subj)
        {
            QuestCount = count;
            Essential = essential;
            if (result <= count)
            {
                Result = result;
                if (result >= count / 2)
                {
                    if (result == count)
                    {
                        marker = "Отлично";
                    }
                    else if (result >= count / 4)
                    {
                        marker = "Хорошо";
                    }
                    else
                    {
                        marker = "Средне";
                    }
                    Done = true;
                }
                else
                {
                    Done = false;
                    marker = "Не сдал";
                }
            }
            else
            {
                Result = count;
                Done = true;
                marker = "Отлично";
            }
        }
        public Exam(string name, string subj, int count, int result) : base(name, subj)
        {
            QuestCount = count;
            if (result <= count)
            {
                Result = result;
                if (result >= count / 2)
                {
                    if(result == count)
                    {
                        marker = "Отлично";
                    }
                    else if(result >= count / 4)
                    {
                        marker = "Хорошо";
                    }
                    else
                    {
                        marker = "Средне";
                    }
                    Done = true;
                }
                else
                {
                    Done = false;
                    marker = "Не сдал";
                }
            }
            else
            {
                Result = count;
                Done = true;
                marker = "Отлично";
            }
        }
        public Exam() : base()
        {
            questCount = 0;
            result = 0;
            essential = false;
        }


        public int CompareTo(object obj)
        {
            Exam temp = (Exam)obj;
            if (temp.Result < this.Result) return 1;
            if (temp.Result > this.Result) return -1;
            return 0;
        }

        public override void Show()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Тест: {Subject}, \nКоличество вопросов: {QuestCount}, \nРезультат: {Result}, \nОценка: {Marker}, \nЗачет: {Done}, \nОбязательный: {Essential}");
        }

    }

    public class ExitExam : Exam, IComparable
    {
        private double influence; //Как сильно влияет экзамен на итоговую оценку
        public double Influence
        {
            get { return influence; }
            set
            {
                if(value <= 1 && value >= 0)
                {
                    influence = value;
                }
                else if(value > 1)
                {
                    influence = 1;
                }
                else
                {
                    influence = 0;
                }
            }
        }

        public ExitExam(string name, string subj, int count, int result, double marker):base(name, subj, count, result)
        {
            Influence = marker;
        }
        public ExitExam() : base()
        {
            Influence = 0.5;
        }

        public override void Show()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"\nСтудент: {Name}");
            Console.WriteLine($"Тест: {Subject}, \nКоличество вопросов: {QuestCount}, \nРезультат: {Result}, \nОценка: {Marker},  \nЗачет: {Done}, \nВлияние на итоговую оценку: {Influence}");
        }

    }

    public class SortByName : IComparer<Test>
    {
        int IComparer<Test>.Compare(Test ob1, Test ob2)
        {
            return String.Compare(ob1.Name, ob2.Name);
        }

    }

}
