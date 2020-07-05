using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class One_Mass : Form
    {
        public One_Mass()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void One_Mass_Load(object sender, EventArgs e)
        {

        }

        private void One_Mass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void RandGenerate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int)MasSize.Value != 0)
            {
                int size = (int)MasSize.Value;
                int[] arr = new int[size];
                Program.RandGeneration(ref arr);
                OutputMas.Text = Program.PrintMas(arr);
                OutputMas.Show();
                Program.array = arr;
            }
            else
            {
                errorProvider1.SetError(MasSize, "Массив является пустым");
            }
        }

        private void InputOnKeyboard_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int)MasSize.Value != 0)
            {
                CreateMas mas = new CreateMas();
                mas.Owner = this;
                Program.array = new int[(int)MasSize.Value];
                this.Enabled = false;
                mas.ShowDialog();
            }
            else
            {
                errorProvider1.SetError(MasSize, "Массив является пустым");
            }
        }

        private void MasSize_ValueChanged(object sender, EventArgs e)
        {
            Keys.Maximum = MasSize.Value;
            Numbers.Maximum = MasSize.Value - Keys.Value + 1;
        }

        private void Keys_ValueChanged(object sender, EventArgs e)
        {
            Numbers.Maximum = MasSize.Value - Keys.Value + 1;
        }

        private void Numbers_ValueChanged(object sender, EventArgs e)
        {
            Numbers.Maximum = MasSize.Value - Keys.Value + 1;
        }

        private void DeleteElem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Program.array != null)
            {
                if((int)Keys.Value> Program.array.Length)
                {
                    errorProvider1.SetError(Keys, "Выход за границы массива");
                }
                else if ((int)Numbers.Value-1 > Program.array.Length - (int)Keys.Value)
                {
                    errorProvider1.SetError(Numbers, "Выход за границы массива");
                }
                else
                {
                    Program.DeleteElem(ref Program.array, (int)Numbers.Value, (int)Keys.Value);

                    OutputMas.Text = Program.PrintMas(Program.array);
                    OutputMas.Show();
                }
                
            }
        }

        private void SaveInFile_Click(object sender, EventArgs e)
        {
            
            if(OutputMas.Text != "" && OutputMas.Text != "Массив пустой, пересоздайте массив!")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filename, "Одномерный массив\n" + OutputMas.Text);
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                MessageBox.Show("Невозможно сохранить пустой файл!");
            }
            
        }

        private void LoadOfFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string[] fileText = System.IO.File.ReadAllLines(filename);
            if (fileText[0] == "Одномерный массив")
            {
                OutputMas.Text = fileText[1];
                string[] arr = OutputMas.Text.Split(' ');
                int n = arr.Count() - 1;
                Program.array = new int[n];
                int[] array = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] != "")
                    {
                        Program.array[j] = int.Parse(arr[j]);
                    }

                }
                OutputMas.Text = Program.PrintMas(Program.array);
                MessageBox.Show("Файл открыт");
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл с другим массивом");
            }
            
        }
    }
}
