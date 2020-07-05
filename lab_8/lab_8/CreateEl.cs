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
    public partial class CreateEl : Form
    {
        public CreateEl()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = this.Owner as Menu;
            menu.Enabled = true;
        }

        private void CreateEl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu menu = this.Owner as Menu;
            menu.Enabled = true;
        }

        private void WayNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(WayNumber.Text == "Маршрут №1")
            {
                BusNumber.Enabled = true;
                BusNumber.Items.Clear();
                BusNumber.Items.AddRange(new string[] { "16", "36", "56", "76" });
            }
            else if (WayNumber.Text == "Маршрут №2")
            {
                BusNumber.Enabled = true;
                BusNumber.Items.Clear();
                BusNumber.Items.AddRange(new string[] { "11", "33", "55", "77" });
            }
            else
            {
                BusNumber.Enabled = true;
                BusNumber.Items.Clear();
                BusNumber.Items.AddRange(new string[] { "7", "47", "88", "115" });
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (CheckTheName(FirstName.Text))
            {
                errorProvider.SetError(FirstName, "Введите корректное имя");
            }
            else if (CheckTheName(Surname.Text))
            {
                errorProvider.SetError(Surname, "Введите корректную фамилию");
            }
            else if (CheckTheName(Thirdname.Text))
            {
                errorProvider.SetError(Thirdname, "Введите корректное отчество");
            }
            else if (ObjPosition.SelectedIndex != 0 && ObjPosition.SelectedIndex != 1 && ObjPosition.SelectedIndex != 2)
            {
                errorProvider.SetError(ObjPosition, "Выберите одно значение");
            }
            else
            {
                Menu menu = this.Owner as Menu;
                Driver driver = new Driver(FirstName.Text, Surname.Text, Thirdname.Text, WayNumber.SelectedIndex, BusNumber.SelectedIndex, PositionBus.SelectedIndex);

                string fio =  driver.DName[0] + ". " + driver.DThirdname[0] + ". " + driver.DSurname;

                ListViewItem list = new ListViewItem(fio);
                
                list.Tag = driver;
                
                if (ObjPosition.Text == "В начале")
                {
                    menu.ListView.Items.Insert(0, list);
                }
                else if (ObjPosition.Text == "В конце")
                {
                    menu.ListView.Items.Add(list);
                }
                else if (ObjPosition.Text == "Выбрать")
                {
                    menu.ListView.Items.Insert((int)Numeric.Value-1, list);
                }

                this.Hide();
                menu.Enabled = true;
            }
        }

        public bool CheckTheName(string name)
        {
            char[] array = name.ToCharArray();
            if(name == string.Empty)
            {
                return true;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (!((array[i] >= 'A' && array[i] <= 'Z') || (array[i] >= 'А' && array[i] <= 'Я') || (array[i] >= 'a' && array[i] <= 'z') || (array[i] >= 'а' && array[i] <= 'я')))
                {
                    return true;
                }
            }
            return false;
        }

        private void ObjPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ObjPosition.Text == "Выбрать")
            {
                Menu menu = this.Owner as Menu;
                Numeric.Enabled = true;
                Numeric.Maximum = menu.ListView.Items.Count+1;
                Numeric.Minimum = 1;
            }
        }
    }
}
