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
    public partial class CreateMas_3 : Form
    {
        public CreateMas_3()
        {
            InitializeComponent();
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            if ((int)Num1.Value != 0)
            {
                string[] label1 = Txt1.Text.Split(new char[] { ' ' });
                int col = int.Parse(label1[0]);//элементы в строке
                Program.array_3[col - 1] = new int[(int)Num1.Value];
                Txt1.Text = (col + 1) + " строка";
                if (col == Program.array_3.Length)
                {
                    if ((int)Num1.Value == 1)
                    {
                        Next1.Hide();
                        Num1.Hide();
                        Num2.Show();
                        Txt1.Text = "1 строка";
                        Text1.Text = "Введите элементы каждой строки";
                        Txt2.Show();
                        Send.Location = new Point(108, 79);
                        Send.Show();
                    }
                    else
                    {
                        Next1.Hide();
                        Next.Location = new Point(108, 79);
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
            int[][] arr = Program.array_3;
            string[] label1 = Txt2.Text.Split(new char[] { ' ' });
            string[] label2 = Txt1.Text.Split(new char[] { ' ' });
            int row = int.Parse(label2[0]);//строки
            int col = int.Parse(label1[0]);//элементы в строке
            if (row == arr.Length && col + 1 == arr[row-1].Length)
            {
                Next.Visible = false;
                Send.Location = new Point(108, 79);
                Send.Show();
            }
            arr[row - 1][col-1] = (int)Num2.Value;
            Txt2.Text = (col + 1) + " =";
            if (col == arr[row - 1].Length)
            {
                Txt1.Text = (row + 1) + " строка";
                Txt2.Text = "1 =";
            }
            Program.array_3 = arr;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.array_3[Program.array_3.Length - 1][Program.array_3[Program.array_3.Length-1].Length - 1] = (int)Num2.Value;
            this.Hide();
            Ragged_Mass form = this.Owner as Ragged_Mass;
            form.Enabled = true;
            form.OutputMas.Text = Program.PrintMas(Program.array_3);
            form.OutputMas.Visible = true;
            form.AddElem_1.Enabled = true;
            form.AddElem.Enabled = true;
        }

        private void CreateMas_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Ragged_Mass form = this.Owner as Ragged_Mass;
            form.Enabled = true;
        }
    }
}
