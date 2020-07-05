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
    public partial class Ragged_Mass : Form
    {
        public Ragged_Mass()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void RandGenerate_Click(object sender, EventArgs e)
        {
            int size = (int)MasRows.Value;
            int[][] arr = new int[size][];
            Program.RandGeneration(ref arr);
            OutputMas.Text = Program.PrintMas(arr);
            OutputMas.Show();
            Numbers.Maximum = MasRows.Value + 1;
            Program.array_3 = arr;
            if(Program.array_3 != null && Program.array_3.Length!=0)
            {
                AddElem_1.Enabled = true;
                AddElem.Enabled = true;
            }
            else
            {
                AddElem_1.Enabled = false;
                AddElem.Enabled = false;
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void Ragged_Mass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InputOnKeyboard_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int)MasRows.Value != 0)
            {
                CreateMas_3 mas = new CreateMas_3();
                mas.Owner = this;
                Program.array_3 = new int[(int)MasRows.Value][];
                this.Enabled = false;
                mas.ShowDialog();
                Numbers.Maximum = MasRows.Value + 1;
            }
            else if ((int)MasRows.Value == 0)
            {
                errorProvider1.SetError(MasRows, "Массив является пустым");
            }
        }

        private void AddElem_Click(object sender, EventArgs e)
        {
            if (Program.array_3 != null)
            {
                int check = 1;
                Program.AddRows(ref Program.array_3, Program.massive, (int)Numbers.Value, (int)Count.Value, check);
                OutputMas.Text = Program.PrintMas(Program.array_3);
            }
            else
            {
                OutputMas.Text = "Вы еще не создали массив, создайте массив!";
            }
        }

        private void MasRows_ValueChanged(object sender, EventArgs e)
        {
            Numbers.Maximum = MasRows.Value + 1;
        }

        private void OutputMas_TextChanged(object sender, EventArgs e)
        {
            if (Program.array_3 != null)
            {
                Numbers.Maximum = Program.array_3.Length + 1;
            }
        }

        private void SaveInFile_Click(object sender, EventArgs e)
        {
            if (OutputMas.Text != "" && OutputMas.Text != "Массив пустой, пересоздайте массив!")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filename, "Рваный массив\n" + OutputMas.Text);
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
            if (fileText[0] == "Рваный массив")
            {
                Program.array_3 = new int[fileText.Length-1][];
                for (int i = 1; i < fileText.Length; i++)
                {
                    OutputMas.Text = fileText[i];
                    string[] arr = OutputMas.Text.Split(' ');
                    int n = arr.Count()-1;
                    int[] array = new int[n];
                    for(int j=0; j<n; j++)
                    {
                        if (arr[j] != "")
                        {
                            array[j] = int.Parse(arr[j]);
                        }
                        
                    }
                    Program.array_3[i - 1] = array;
                }
                OutputMas.Text = Program.PrintMas(Program.array_3);
                MessageBox.Show("Файл открыт");
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл с другим массивом");
            }
        }

        private void AddElem_1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Program.array_3 != null)
            {
                if((int)Count.Value != 0)
                {
                    AddMas_3 mas = new AddMas_3();
                    mas.Owner = this;
                    Program.massive = new int[(int)Count.Value][];
                    this.Enabled = false;
                    mas.ShowDialog();
                }
                else
                {
                    errorProvider1.SetError(Count, "Значение количества строк пустое");
                }
            }
            else
            {
                OutputMas.Text = "Вы еще не создали массив, создайте массив!";
            }
        }
    }
}
