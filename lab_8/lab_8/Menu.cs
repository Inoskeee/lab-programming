using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab_8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            openFileDialog.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
            saveFileDialog.Filter = "Binary files(*.bin)|*.bin|All files(*.*)|*.*";
        }

        private void AddElem_Click(object sender, EventArgs e)
        {
            CreateEl AddObject = new CreateEl();
            AddObject.Owner = this;
            this.Enabled = false;
            AddObject.ShowDialog();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListView.SelectedItems.Count == 1)
            {
                Change_Panel.Enabled = true;
                Driver driver = (Driver)ListView.SelectedItems[0].Tag;

                if(driver != null)
                {
                    WayNumber.SelectedIndex = driver.wayNumber;
                    BusNumber.SelectedIndex = driver.busNumber;
                    PositionBus.SelectedIndex = driver.busPosition;

                    FirstName.Text = driver.DName;
                    Surname.Text = driver.DSurname;
                    Thirdname.Text = driver.DThirdname;
                }
            }
            else if(ListView.SelectedItems.Count == 0)
            {
                //Ничего
            }
        }

        private void WayNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WayNumber.Text == "Маршрут №1")
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

        private void ChangeElem_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            CreateEl element = new CreateEl();

            if (element.CheckTheName(FirstName.Text))
            {
                errorProvider.SetError(FirstName, "Введите корректное имя");
            }
            else if (element.CheckTheName(Surname.Text))
            {
                errorProvider.SetError(Surname, "Введите корректную фамилию");
            }
            else if (element.CheckTheName(Thirdname.Text))
            {
                errorProvider.SetError(Thirdname, "Введите корректное отчество");
            }
            else
            {
                Driver driver = (Driver)ListView.SelectedItems[0].Tag;

                driver.wayNumber = WayNumber.SelectedIndex;
                driver.busNumber = BusNumber.SelectedIndex;
                driver.busPosition = PositionBus.SelectedIndex;

                driver.DName = FirstName.Text;
                driver.DSurname = Surname.Text;
                driver.DThirdname = Thirdname.Text;

                string fio = driver.DName[0] + ". " + driver.DThirdname[0] + ". " + driver.DSurname;

                ListView.SelectedItems[0].Text = fio;
            }
        }

        private void DeleteElem_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count != 0)
            {
                Driver driver = (Driver)ListView.SelectedItems[0].Tag;

                ListView.SelectedItems[0].Tag = null;
                ListView.SelectedItems[0].Remove();
                
                Change_Panel.Enabled = false;
            }
        }

        private void SaveTheFile_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();

            foreach (ListViewItem item in ListView.Items)
            {
                if (item.Tag != null)
                {
                    drivers.DriversList.Add((Driver)item.Tag);
                }
            }

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;

            Serializer(filename, drivers);

        }

        private void LoadTheFile_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;

            Drivers drivers = Deserializer(filename);

            foreach (Driver driver in drivers.DriversList)
            {
                string fio = driver.DName[0] + ". " + driver.DThirdname[0] + ". " + driver.DSurname;
                ListViewItem list = new ListViewItem(fio);

                list.Tag = driver;

                ListView.Items.Add(list);
            }
        }

        private void Serializer(string filename, Drivers drivers)
        {
            BinaryFormatter binary = new BinaryFormatter();

            File.Delete(filename);

            using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
            {

                binary.Serialize(fstream, drivers);
            }
        }


        private Drivers Deserializer(string filename)
        {
            BinaryFormatter binary = new BinaryFormatter();

            using (FileStream fstream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                return (Drivers)binary.Deserialize(fstream);
            }
        }



        private void search_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (ListViewItem item in ListView.Items)
            {
                if (item.Tag != null)
                {
                    Driver driver = (Driver)item.Tag;
                    if(driver.DSurname.Substring(0,2) == text.Text)
                    {
                        item.Selected = true;
                        found = true;
                    }
                    item.Selected = false;
                }
            }
            if (!found)
            {
                MessageBox.Show("Водитель не найден, проверьте правильность введенных букв!");
            }
        }

        private void onWay_Click(object sender, EventArgs e)
        {
            string inWay = "Сейчас в пути водители:\n";
            foreach (ListViewItem item in ListView.Items)
            {
                if (item.Tag != null)
                {
                    Driver driver = (Driver)item.Tag;
                    if(driver.busPosition == 0)
                    {
                        inWay += driver.DName[0] + ". " + driver.DThirdname[0] + ". " + driver.DSurname+"\n";
                    }
                }
            }
            if(inWay == "")
            {
                MessageBox.Show("Нет водителей в пути");
            }
            else
            {
                MessageBox.Show(inWay);
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Setting AddObject = new Setting();
            AddObject.Owner = this;
            this.Enabled = false;
            AddObject.ShowDialog();
        }
    }
}
