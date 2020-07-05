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
    public partial class CreateMas : Form
    {
        public CreateMas()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int[] arr = Program.array;
            string[] label = Txt1.Text.Split(new char[] { ' ' });
            int k = int.Parse(label[0]);
            if (k+1 == arr.Length)
            {
                Next.Visible = false;
                Send.Location = new Point(19, 78);
                Send.Show();
            }
            arr[k-1] = (int)Num1.Value;
            Txt1.Text = (k + 1) + " =";
            Program.array = arr;
        }

        private void CreateMas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            One_Mass form = this.Owner as One_Mass;
            form.Enabled = true;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Program.array[Program.array.Length-1] = (int)Num1.Value;
            this.Hide();
            One_Mass form = this.Owner as One_Mass;
            form.Enabled = true;
            form.OutputMas.Text = Program.PrintMas(Program.array);
            form.OutputMas.Visible = true;
        }

        private void CreateMas_Load(object sender, EventArgs e)
        {
            string[] label = Txt1.Text.Split(new char[] { ' ' });
            int k = int.Parse(label[0]);
            if (k == Program.array.Length)
            {
                Next.Visible = false;
                Send.Location = new Point(19, 78);
                Send.Show();
            }
        }
    }
}
