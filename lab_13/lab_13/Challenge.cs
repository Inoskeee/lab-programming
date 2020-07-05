using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    public class Challenge : ICloneable, IComparable
    {
        public static Random rnd = new Random();
        public static string[] subjects = new string[] { "Физика", "Математика", "Дискретная математика", "Программирование", "История", "Английский язык" };

        static string[] FirstNameMale = { "Дмитрий", "Михаил", "Сергей", "Артем", "Антон", "Алексей", "Максим", "Иван", "Никита", "Виктор", "Владимир" };
        static string[] FirstNameFemale = { "Анна", "Виктория", "Елена", "Карина", "Лидия", "Ирина", "Вера", "Вероника", "Анастасия" };
        static string[] SecondNameMale = { "Петров", "Иванов", "Сергеев", "Сидоров", "Попов", "Никитин", "Александров", "Дмитриев" };
        static string[] SecondNameFemale = { "Петрова", "Иванова", "Сергеева", "Сидорова", "Попова", "Никитина", "Александрова", "Дмитриева" };


        public int CurrentNumber { get; set; }
        static string MakeName()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return FirstNameFemale[rnd.Next(FirstNameFemale.Length)] + " " + SecondNameFemale[rnd.Next(SecondNameFemale.Length)];
            }
            else
            {
                return FirstNameMale[rnd.Next(FirstNameFemale.Length)] + " " + SecondNameMale[rnd.Next(SecondNameFemale.Length)];
            }
        }

        public string Name { get; set; }

        public string Subject { get; set; }

        public bool Done { get; set; }


        public Challenge(string name, string subj, bool done, int number)
        {
            Name = name;
            Subject = subj;
            Done = done;
            CurrentNumber = number;
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
            Name = MakeName();
            Subject = subjects[rnd.Next(0, subjects.Length - 1)];
        }
        public virtual void Show() { }


        public object Clone()
        {
            return new Challenge(this.Name, this.Subject, this.Done);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Subject.GetHashCode() + Done.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Challenge p = (Challenge)obj;
            return (this.Name == p.Name) && (this.Subject == p.Subject) && (this.Done == p.Done);
        }

        public virtual int CompareTo(object obj)
        {
            Challenge temp = (Challenge)obj;
            if ((String.Compare(this.Name, temp.Name) > 0)) return 1;
            if ((String.Compare(this.Name, temp.Name) < 0)) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return Name.ToString() + ", " + Subject.ToString();
        }

    }

    public class Test : Challenge
    {
        string[] themes = new string[] { "Тема 1", "Тема 2", "Тема 3" };

        private int questCount;
        private string theme;
        private int result;

        public static int count = 0;

        //public int CurrentNumber { get; set; }

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

        public Test(string name, string subj, string theme, int count, int result, int cloneCount) : base(name, subj)
        {
            CurrentNumber = cloneCount;
            QuestCount = count;
            Theme = theme;
            if (result <= count)
            {
                Result = result;
                if (result >= count / 2)
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
        public Test(string name, string subj, string theme, int Clcount, int result) : base(name, subj)
        {
            count++;
            CurrentNumber = count;
            QuestCount = Clcount;
            Theme = theme;
            if (result <= Clcount)
            {
                Result = result;
                if (result >= Clcount / 2)
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
                Result = Clcount;
                Done = true;
            }
        }
        public Test() : base()
        {
            count++;
            CurrentNumber = count;
            Theme = themes[rnd.Next(0, themes.Length - 1)];
            QuestCount = rnd.Next(5, 20);
            Result = rnd.Next(0, QuestCount);

            if (Result <= QuestCount)
            {
                if (Result >= QuestCount / 2)
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
                Done = true;
            }

        }

        public Challenge GetBaseChallenge()
        {
            return new Challenge(this.Name, this.Subject, this.Done, this.CurrentNumber);
        }
        new public object Clone()
        {
            return new Test(this.Name, this.Subject, this.Theme, this.QuestCount, this.Result, this.CurrentNumber);
        }


        public override int CompareTo(object obj)
        {
            Challenge temp = (Challenge)obj;
            if ((String.Compare(this.Name, temp.Name) > 0) && (String.Compare(this.Name, temp.Name) > 0) && (this.CurrentNumber > temp.CurrentNumber)) return 1;
            if ((String.Compare(this.Name, temp.Name) < 0) && (String.Compare(this.Name, temp.Name) < 0) && (this.CurrentNumber <= temp.CurrentNumber)) return -1;
            else return 0;
        }

        public override void Show()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Тест: {Subject}, \nТема: {Theme}, \nКоличество вопросов: {QuestCount}, \nВыполнено: {Done}");
        }

        public override string ToString()
        {
            return "№" + CurrentNumber + " " + base.ToString() + " Вопросы: " + QuestCount;
        }
    }
}
