namespace Lab_7
{
    partial class Ragged_Mass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OutputMas = new System.Windows.Forms.TextBox();
            this.AddElem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputOnKeyboard = new System.Windows.Forms.Button();
            this.RandGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MasRows = new System.Windows.Forms.NumericUpDown();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.LoadOfFile = new System.Windows.Forms.Button();
            this.ExitMenu = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Numbers = new System.Windows.Forms.NumericUpDown();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddElem_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MasRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputMas
            // 
            this.OutputMas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputMas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputMas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputMas.Location = new System.Drawing.Point(17, 351);
            this.OutputMas.Margin = new System.Windows.Forms.Padding(4);
            this.OutputMas.Multiline = true;
            this.OutputMas.Name = "OutputMas";
            this.OutputMas.ReadOnly = true;
            this.OutputMas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputMas.Size = new System.Drawing.Size(509, 198);
            this.OutputMas.TabIndex = 49;
            this.OutputMas.WordWrap = false;
            this.OutputMas.TextChanged += new System.EventHandler(this.OutputMas_TextChanged);
            // 
            // AddElem
            // 
            this.AddElem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddElem.Enabled = false;
            this.AddElem.Location = new System.Drawing.Point(269, 222);
            this.AddElem.Margin = new System.Windows.Forms.Padding(4);
            this.AddElem.Name = "AddElem";
            this.AddElem.Size = new System.Drawing.Size(251, 39);
            this.AddElem.TabIndex = 48;
            this.AddElem.Text = "Добавить с помощью ДСЧ";
            this.AddElem.UseVisualStyleBackColor = true;
            this.AddElem.Click += new System.EventHandler(this.AddElem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(265, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 34);
            this.label2.TabIndex = 47;
            this.label2.Text = "Добавить строки в массив";
            // 
            // InputOnKeyboard
            // 
            this.InputOnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputOnKeyboard.Location = new System.Drawing.Point(20, 142);
            this.InputOnKeyboard.Margin = new System.Windows.Forms.Padding(4);
            this.InputOnKeyboard.Name = "InputOnKeyboard";
            this.InputOnKeyboard.Size = new System.Drawing.Size(195, 73);
            this.InputOnKeyboard.TabIndex = 46;
            this.InputOnKeyboard.Text = "Создать массив вручную";
            this.InputOnKeyboard.UseVisualStyleBackColor = true;
            this.InputOnKeyboard.Click += new System.EventHandler(this.InputOnKeyboard_Click);
            // 
            // RandGenerate
            // 
            this.RandGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RandGenerate.Location = new System.Drawing.Point(20, 222);
            this.RandGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.RandGenerate.Name = "RandGenerate";
            this.RandGenerate.Size = new System.Drawing.Size(195, 73);
            this.RandGenerate.TabIndex = 45;
            this.RandGenerate.Text = "Сгенерировать массив";
            this.RandGenerate.UseVisualStyleBackColor = true;
            this.RandGenerate.Click += new System.EventHandler(this.RandGenerate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Количество строк";
            // 
            // MasRows
            // 
            this.MasRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasRows.Location = new System.Drawing.Point(155, 110);
            this.MasRows.Margin = new System.Windows.Forms.Padding(4);
            this.MasRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MasRows.Name = "MasRows";
            this.MasRows.Size = new System.Drawing.Size(56, 22);
            this.MasRows.TabIndex = 42;
            this.MasRows.ValueChanged += new System.EventHandler(this.MasRows_ValueChanged);
            // 
            // SaveInFile
            // 
            this.SaveInFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveInFile.Location = new System.Drawing.Point(187, 15);
            this.SaveInFile.Margin = new System.Windows.Forms.Padding(4);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(163, 47);
            this.SaveInFile.TabIndex = 40;
            this.SaveInFile.Text = "Сохранить в файл";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
            // 
            // LoadOfFile
            // 
            this.LoadOfFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadOfFile.Location = new System.Drawing.Point(16, 15);
            this.LoadOfFile.Margin = new System.Windows.Forms.Padding(4);
            this.LoadOfFile.Name = "LoadOfFile";
            this.LoadOfFile.Size = new System.Drawing.Size(163, 47);
            this.LoadOfFile.TabIndex = 39;
            this.LoadOfFile.Text = "Загрузить из файла";
            this.LoadOfFile.UseVisualStyleBackColor = true;
            this.LoadOfFile.Click += new System.EventHandler(this.LoadOfFile_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitMenu.Location = new System.Drawing.Point(357, 15);
            this.ExitMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(163, 47);
            this.ExitMenu.TabIndex = 38;
            this.ExitMenu.Text = "Выйти в меню";
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Text2
            // 
            this.Text2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.Location = new System.Drawing.Point(11, 310);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(147, 23);
            this.Text2.TabIndex = 37;
            this.Text2.Text = "Вывод массива:";
            // 
            // Text1
            // 
            this.Text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(11, 65);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(132, 23);
            this.Text1.TabIndex = 36;
            this.Text1.Text = "Ввод массива:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "С какой строки добавляем";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Сколько строк добавляем";
            // 
            // Numbers
            // 
            this.Numbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbers.Location = new System.Drawing.Point(461, 112);
            this.Numbers.Margin = new System.Windows.Forms.Padding(4);
            this.Numbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(59, 22);
            this.Numbers.TabIndex = 52;
            this.Numbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Count
            // 
            this.Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Count.Location = new System.Drawing.Point(461, 145);
            this.Count.Margin = new System.Windows.Forms.Padding(4);
            this.Count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(59, 22);
            this.Count.TabIndex = 53;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // AddElem_1
            // 
            this.AddElem_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddElem_1.Enabled = false;
            this.AddElem_1.Location = new System.Drawing.Point(269, 270);
            this.AddElem_1.Margin = new System.Windows.Forms.Padding(4);
            this.AddElem_1.Name = "AddElem_1";
            this.AddElem_1.Size = new System.Drawing.Size(251, 39);
            this.AddElem_1.TabIndex = 54;
            this.AddElem_1.Text = "Добавить вручную";
            this.AddElem_1.UseVisualStyleBackColor = true;
            this.AddElem_1.Click += new System.EventHandler(this.AddElem_1_Click);
            // 
            // Ragged_Mass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(537, 554);
            this.Controls.Add(this.AddElem_1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputMas);
            this.Controls.Add(this.AddElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputOnKeyboard);
            this.Controls.Add(this.RandGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasRows);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.LoadOfFile);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ragged_Mass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рваный массив";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ragged_Mass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MasRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox OutputMas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InputOnKeyboard;
        private System.Windows.Forms.Button RandGenerate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown MasRows;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button LoadOfFile;
        private System.Windows.Forms.Button ExitMenu;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.Button AddElem_1;
        public System.Windows.Forms.NumericUpDown Numbers;
        public System.Windows.Forms.NumericUpDown Count;
        public System.Windows.Forms.Button AddElem;
    }
}