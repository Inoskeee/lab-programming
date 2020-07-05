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
    public partial class CreateMas_2 : Form
    {
        public CreateMas_2()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Two_Mass form = this.Owner as Two_Mass;
            int[,] arr = Program.array_2;
            string[] label1 = Txt1.Text.Split(new char[] { ' ' });
            string[] label2 = Txt2.Text.Split(new char[] { ' ' });
            int row = int.Parse(label2[0]);//строки
            int col = int.Parse(label1[0]);//элементы в строке
            if ((row == arr.GetLength(0) && col + 1 == arr.GetLength(1)) || (row+1 == arr.GetLength(0) && (int)form.MasCols.Value == 1))
            {
                Next.Visible = false;
                Send.Location = new Point(76, 75);
                Send.Show();
            }
            arr[row-1, col-1] = (int)Num1.Value;
            Txt1.Text = (col + 1) + " =";
            if(col == arr.GetLength(1))
            {
                Txt2.Text = (row + 1) + " строка";
                Txt1.Text = "1 =";
            }
            Program.array_2 = arr;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.array_2[Program.array_2.GetLength(0)-1, Program.array_2.GetLength(1) - 1] = (int)Num1.Value;
            this.Hide();
            Two_Mass form = this.Owner as Two_Mass;
            form.Enabled = true;
            form.OutputMas.Text = Program.PrintMas(Program.array_2);
            form.OutputMas.Visible = true;
        }

        private void CreateMas_2_Load(object sender, EventArgs e)
        {
            string[] label = Txt1.Text.Split(new char[] { ' ' });
            string[] label1 = Txt1.Text.Split(new char[] { ' ' });
            string[] label2 = Txt2.Text.Split(new char[] { ' ' });
            int row = int.Parse(label2[0]);//строки
            int col = int.Parse(label1[0]);//элементы в строке
            if (row == Program.array_2.GetLength(0) && col == Program.array_2.GetLength(1))
            {
                Next.Visible = false;
                Send.Location = new Point(76, 75);
                Send.Show();
            }
        }

        private void CreateMas_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Two_Mass form = this.Owner as Two_Mass;
            form.Enabled = true;
        }
    }
}
