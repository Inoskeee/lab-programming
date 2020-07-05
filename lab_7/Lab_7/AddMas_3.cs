using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class AddMas_3 : Form
    {
        public AddMas_3()
        {
            InitializeComponent();
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            if ((int)Num1.Value != 0)
            {
                string[] label1 = Txt1.Text.Split(new char[] { ' ' });
                int col = int.Parse(label1[0]);//элементы в строке
                Program.massive[col - 1] = new int[(int)Num1.Value];
                Txt1.Text = (col + 1) + " строка";
                if (col == Program.massive.Length)
                {
                    if((int)Num1.Value == 1)
                    {
                        Next1.Hide();
                        Num1.Hide();
                        Num2.Show();
                        Txt1.Text = "1 строка";
                        Text1.Text = "Введите элементы каждой строки";
                        Txt2.Show();
                        Send.Location = new Point(76, 75);
                        Send.Show();
                    }
                    else
                    {
                        Next1.Hide();
                        Next.Show();
                        Num1.Hide();
                        Num2.Show();
                        Txt1.Text = "1 строка";
                        Text1.Text = "Введите элементы каждой строки";
                        Txt2.Show();
                    }
                    
                }
            }
            else
            {
                errorProvider1.SetError(Num1, "Строка не может быть пустой");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int[][] arr = Program.massive;
            string[] label1 = Txt2.Text.Split(new char[] { ' ' });
            string[] label2 = Txt1.Text.Split(new char[] { ' ' });
            int row = int.Parse(label2[0]);//строки
            int col = int.Parse(label1[0]);//элементы в строке
            if (row == arr.Length && col + 1 == arr[row - 1].Length)
            {
                Next.Visible = false;
                Send.Location = new Point(76, 75);
                Send.Show();
            }
            arr[row - 1][col - 1] = (int)Num2.Value;
            Txt2.Text = (col + 1) + " =";
            if (col == arr[row - 1].Length)
            {
                Txt1.Text = (row + 1) + " строка";
                Txt2.Text = "1 =";
            }
            Program.massive = arr;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.massive[Program.massive.Length - 1][Program.massive[Program.massive.Length - 1].Length - 1] = (int)Num2.Value;
            Ragged_Mass form = this.Owner as Ragged_Mass;
            int check = 0;
            Program.AddRows(ref Program.array_3, Program.massive, (int)form.Numbers.Value, (int)form.Count.Value, check);
            this.Hide();
            form.Enabled = true;
            form.OutputMas.Text = Program.PrintMas(Program.array_3);
            form.OutputMas.Visible = true;
        }

        private void AddMas_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Ragged_Mass form = this.Owner as Ragged_Mass;
            form.Enabled = true;
        }
    }
}
