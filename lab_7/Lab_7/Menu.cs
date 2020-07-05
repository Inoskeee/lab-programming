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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            One_Mass mass = new One_Mass();
            mass.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Two_Mass mass = new Two_Mass();
            mass.Show();
            this.Hide();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Ragged_Mass mass = new Ragged_Mass();
            mass.Show();
            this.Hide();
        }
    }
}
