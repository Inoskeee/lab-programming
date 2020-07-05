using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class UravnenieArray
    {
        Uravnenie[] arr;
        private int size = 0;

        public int Size
        {
            get { return size; }
            set
            {
                if (value >= 0)
                {
                    size = value;
                }
            }
        }
        public UravnenieArray(int size, int a, int b, int c)
        {
            arr = new Uravnenie[size];
            Size = size;
            if (size != 0)
            {
                arr[0] = new Uravnenie(a, b, c);
                for (int i = 1; i < arr.Length; i++)
                {
                    Program.Input(out a, out b, out c);
                    arr[i] = new Uravnenie(a, b, c);
                }
            }
        }
        public UravnenieArray(int size)
        {
            Size = size;
            if (size != 0)
            {
                Random rand = new Random();
                arr = new Uravnenie[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = new Uravnenie(rand.Next(0, 20), rand.Next(0, 20), rand.Next(0, 20));
                }
            }
        }
        public UravnenieArray()
        {
            Size = 1;
            arr = new Uravnenie[1];
            arr[0] = new Uravnenie(1, 1, 1);
        }

        //индексатор
        public Uravnenie this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public string Show()
        {
            string result = "";
            if (Size != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i].Show();
                    result += "\n";
                }
                return result;
            }
            else
            {
                result = "Пустой массив.";
                return result;
            }
        }

        public Uravnenie Check()
        {
            if (Size != 0)
            {
                Uravnenie ur = arr[0];
                double currentX = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Calculate();
                    if (arr[i].X1 != 0 && arr[i].X2 != 0)
                    {
                        if (Math.Abs(arr[i].X1) > Math.Abs(arr[i].X2))
                        {
                            if (Math.Abs(arr[i].X1) > currentX)
                            {
                                currentX = Math.Abs(arr[i].X1);
                                ur = arr[i];
                            }
                        }
                        else
                        {
                            if (Math.Abs(arr[i].X2) > currentX)
                            {
                                currentX = Math.Abs(arr[i].X2);
                                ur = arr[i];
                            }
                        }
                    }

                }
                return ur;
            }
            return null;
        }
    }
}
