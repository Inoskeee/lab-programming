using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void checkKey_CheckedChanged(object sender, EventArgs e)
        {
            Menu menu = this.Owner as Menu;
            checkZnak.Checked = false;
            labelZnak.Enabled = false;
            textZnak.Enabled = false;

            labelKey.Enabled = true;
            numKey.Minimum = 1;
            numKey.Maximum = menu.ListView.Items.Count;
            numKey.Enabled = true;

        }
        private void checkZnak_CheckedChanged(object sender, EventArgs e)
        {
            Menu menu = this.Owner as Menu;
            checkKey.Checked = false;
            labelKey.Enabled = false;
            numKey.Enabled = false;

            labelZnak.Enabled = true;
            textZnak.Enabled = true;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Menu menu = this.Owner as Menu;
            if (checkKey.Checked == true)
            {
                menu.ListView.Items[(int)numKey.Value - 1].Tag = null;
                menu.ListView.Items[(int)numKey.Value - 1].Remove();

                menu.Change_Panel.Enabled = false;

                this.Hide();
                menu.Enabled = true;
            }
            else if (checkZnak.Checked == true)
            {
                int indx = -1;
                bool found = false;
                foreach (ListViewItem item in menu.ListView.Items)
                {
                    if (item.Tag != null)
                    {
                        Driver driver = (Driver)item.Tag;
                        if (driver.DSurname == textZnak.Text)
                        {
                            indx = item.Index;
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    errorProvider.SetError(textZnak, "Водитель не найден! Введите конкретную фамилию!");
                }
                else
                {
                    menu.ListView.Items[indx].Tag = null;
                    menu.ListView.Items[indx].Remove();

                    menu.Change_Panel.Enabled = false;
                    this.Hide();
                    menu.Enabled = true;
                }
            }
            else
            {
                errorProvider.SetError(label1, "Выберите способ удаления");
            }
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu menu = this.Owner as Menu;
            menu.Enabled = true;
        }
    }
}
