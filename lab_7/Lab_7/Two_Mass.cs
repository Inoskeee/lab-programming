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
    public partial class Two_Mass : Form
    {
        public Two_Mass()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void RandGenerate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int)MasCols.Value != 0 && (int)MasRows.Value != 0)
            {
                int rows = (int)MasCols.Value;
                int cols = (int)MasRows.Value;
                int[,] arr = new int[cols, rows];
                Program.RandGeneration(ref arr);
                OutputMas.Text = Program.PrintMas(arr);
                OutputMas.Show();
                Program.array_2 = arr;
            }
            else if ((int)MasCols.Value == 0)
            {
                errorProvider1.SetError(MasCols, "Массив является пустым");
            }
            else
            {
                errorProvider1.SetError(MasRows, "Массив является пустым");
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void Two_Mass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InputOnKeyboard_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if ((int)MasCols.Value != 0 && (int)MasRows.Value != 0)
            {
                CreateMas_2 mas = new CreateMas_2();
                mas.Owner = this;
                Program.array_2 = new int[(int)MasRows.Value, (int)MasCols.Value];
                this.Enabled = false;
                mas.ShowDialog();
            }
            else if((int)MasCols.Value == 0)
            {
                errorProvider1.SetError(MasCols, "Массив является пустым");
            }
            else
            {
                errorProvider1.SetError(MasRows, "Массив является пустым");
            }
        }

        private void AddElem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Program.array_2 != null)
            {
                if(Program.array_2.GetLength(1) != 1)
                {
                    int check = 1;
                    Program.AddColumns(ref Program.array_2, Program.mas, check);
                    OutputMas.Text = Program.PrintMas(Program.array_2);
                }
                else
                {
                    errorProvider1.SetError(Text2, "В массиве 1 колонка, создайте новый массив");
                }
            }
            else
            {
                OutputMas.Text = "Вы еще не создали массив, создайте массив!";
            }
        }

        private void LoadOfFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string[] fileText = System.IO.File.ReadAllLines(filename);
            if (fileText[0] == "Двумерный массив")
            {
                OutputMas.Text = fileText[1];
                string[] arr = OutputMas.Text.Split(' ');
                int n = arr.Count() - 1;
                Program.array_2 = new int[fileText.Length - 1, n];
                for (int i = 1; i < fileText.Length; i++)
                {
                    OutputMas.Text = fileText[i];
                    arr = OutputMas.Text.Split(' ');
                    n = arr.Count() - 1;
                    int[] array = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[j] != "")
                        {
                            Program.array_2[i - 1, j] = int.Parse(arr[j]);
                        }

                    }
                    
                }
                OutputMas.Text = Program.PrintMas(Program.array_2);
                MessageBox.Show("Файл открыт");
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл с другим массивом");
            }
        }

        private void SaveInFile_Click(object sender, EventArgs e)
        {
            if (OutputMas.Text != "" && OutputMas.Text != "Массив пустой, пересоздайте массив!")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filename, "Двумерный массив\n" + OutputMas.Text);
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                MessageBox.Show("Невозможно сохранить пустой файл!");
            }
        }

        private void AddElem_1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Program.array_2 != null)
            {
                if (Program.array_2.GetLength(1) != 1)
                {
                    AddMas_2 mas = new AddMas_2();
                    mas.Owner = this;
                    Program.mas = new int[Program.array_2.GetLength(0), Program.array_2.GetLength(1) / 2];
                    this.Enabled = false;
                    mas.ShowDialog();
                }
                else
                {
                    errorProvider1.SetError(Text2, "В массиве 1 колонка, создайте новый массив");
                }
                
            }
            else
            {
                OutputMas.Text = "Вы еще не создали массив, создайте массив!";
            }
        }
    }
}
