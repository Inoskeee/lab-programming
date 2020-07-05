using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class Uravnenie
    {
        private double a;
        private double b;
        private double c;

        private double x1;
        private double x2;

        public static int count = 0;
        public double A
        {
            get { return a; }
            set
            {
                if(value == 0)
                {
                    Console.WriteLine("Значение а не может быть = 0");
                }
                else
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public Uravnenie(double aW, double bW, double cW)
        {
            A = aW;
            B = bW;
            C = cW;
            count++;
        }
        public Uravnenie()
        {
            A = 1;
            B = 0;
            C = 0;
            count++;
        }

        public string Show()
        {
            string result = $"Уравнение: {a}x^2";
            if (b > 0)
            {
                result += $"+{b}x";
            }
            else if (b < 0)
            {
                result += $"{b}x";
            }
            if (c > 0)
            {
                result += $"+{c}";
            }
            else if (c < 0)
            {
                result += $"{c}";
            }
            result += " = 0";
            return result;
        }

        public string Calculate()
        {
            double discriminant = Math.Pow(B, 2) - 4 * A * C;
            if (discriminant < 0)
            {
                return "\nНет решений.";
            }
            else if (discriminant == 0)
            {
                X1 = (-B / (2 * A));
                X2 = (-B / (2 * A));
                return "";
            }
            else
            {
                X1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                X2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                return "";
            }
        }
        public static string Calculate(Uravnenie s)
        {
            double discriminant = Math.Pow(s.B, 2) - 4 * s.A * s.C;
            if (discriminant < 0)
            {
                return "\nНет решений.";
            }
            else if (discriminant == 0)
            {
                s.X1 = (-s.B + Math.Sqrt(discriminant)) / (2 * s.A);
                s.X2 = (-s.B - Math.Sqrt(discriminant)) / (2 * s.A);
                return $"\nx1 = {s.X1}, x2 = {s.X2}";
            }
            else
            {
                s.X1 = (-s.B + Math.Sqrt(discriminant)) / (2 * s.A);
                s.X2 = (-s.B - Math.Sqrt(discriminant)) / (2 * s.A);
                return $"\nx1 = {s.X1}, x2 = {s.X2}";
            }
        }

        //Унарные операции
        public static Uravnenie operator ++(Uravnenie u)
        {
            u.A++;
            u.B++;
            u.C++;

            return u;
        }
        public static Uravnenie operator --(Uravnenie u)
        {
            u.A--;
            u.B--;
            u.C--;

            return u;
        }

        public static implicit operator double(Uravnenie u)
        {
            double discriminant = Math.Pow(u.B, 2) - 4 * u.A * u.C;
            if (discriminant < 0)
            {
                return 0;
            }
            else
            {
                double x1 = (-u.B + Math.Sqrt(discriminant)) / 2 * u.A;
                return x1;
            }
        }

        public static explicit operator bool(Uravnenie u)
        {
            double discriminant = Math.Pow(u.B, 2) - 4 * u.A * u.C;

            if (discriminant < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Uravnenie u1, Uravnenie u2)
        {
            return u1.A == u2.A && u1.B == u2.B && u1.C == u2.C;
        }
        public static bool operator !=(Uravnenie u1, Uravnenie u2)
        {
            return u1.A != u2.A || u1.B != u2.B || u1.C != u2.C;
        }

        public override bool Equals(object obj)
        {
            Uravnenie ur = (Uravnenie)obj;
            return this.A == ur.A && this.B == ur.B && this.C == ur.C;
        }
        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
}
