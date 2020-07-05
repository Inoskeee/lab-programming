namespace Lab_7
{
    partial class Two_Mass
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
            this.MasCols = new System.Windows.Forms.NumericUpDown();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.LoadOfFile = new System.Windows.Forms.Button();
            this.ExitMenu = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.MasRows = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddElem_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MasCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputMas
            // 
            this.OutputMas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputMas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputMas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputMas.Location = new System.Drawing.Point(17, 342);
            this.OutputMas.Margin = new System.Windows.Forms.Padding(4);
            this.OutputMas.Multiline = true;
            this.OutputMas.Name = "OutputMas";
            this.OutputMas.ReadOnly = true;
            this.OutputMas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputMas.Size = new System.Drawing.Size(500, 210);
            this.OutputMas.TabIndex = 35;
            this.OutputMas.WordWrap = false;
            // 
            // AddElem
            // 
            this.AddElem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddElem.Location = new System.Drawing.Point(380, 240);
            this.AddElem.Margin = new System.Windows.Forms.Padding(4);
            this.AddElem.Name = "AddElem";
            this.AddElem.Size = new System.Drawing.Size(137, 52);
            this.AddElem.TabIndex = 34;
            this.AddElem.Text = "Сгенерировать";
            this.AddElem.UseVisualStyleBackColor = true;
            this.AddElem.Click += new System.EventHandler(this.AddElem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(240, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 52);
            this.label2.TabIndex = 29;
            this.label2.Text = "Добавить столбцы после каждого четного столбца матрицы";
            // 
            // InputOnKeyboard
            // 
            this.InputOnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputOnKeyboard.Location = new System.Drawing.Point(12, 139);
            this.InputOnKeyboard.Margin = new System.Windows.Forms.Padding(4);
            this.InputOnKeyboard.Name = "InputOnKeyboard";
            this.InputOnKeyboard.Size = new System.Drawing.Size(195, 73);
            this.InputOnKeyboard.TabIndex = 28;
            this.InputOnKeyboard.Text = "Создать массив вручную";
            this.InputOnKeyboard.UseVisualStyleBackColor = true;
            this.InputOnKeyboard.Click += new System.EventHandler(this.InputOnKeyboard_Click);
            // 
            // RandGenerate
            // 
            this.RandGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RandGenerate.Location = new System.Drawing.Point(12, 220);
            this.RandGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.RandGenerate.Name = "RandGenerate";
            this.RandGenerate.Size = new System.Drawing.Size(196, 73);
            this.RandGenerate.TabIndex = 27;
            this.RandGenerate.Text = "Сгенерировать массив";
            this.RandGenerate.UseVisualStyleBackColor = true;
            this.RandGenerate.Click += new System.EventHandler(this.RandGenerate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество столбцов";
            // 
            // MasCols
            // 
            this.MasCols.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasCols.Location = new System.Drawing.Point(176, 108);
            this.MasCols.Margin = new System.Windows.Forms.Padding(4);
            this.MasCols.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MasCols.Name = "MasCols";
            this.MasCols.Size = new System.Drawing.Size(56, 22);
            this.MasCols.TabIndex = 25;
            // 
            // SaveInFile
            // 
            this.SaveInFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveInFile.Location = new System.Drawing.Point(184, 13);
            this.SaveInFile.Margin = new System.Windows.Forms.Padding(4);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(163, 47);
            this.SaveInFile.TabIndex = 24;
            this.SaveInFile.Text = "Сохранить в файл";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
            // 
            // LoadOfFile
            // 
            this.LoadOfFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadOfFile.Location = new System.Drawing.Point(13, 13);
            this.LoadOfFile.Margin = new System.Windows.Forms.Padding(4);
            this.LoadOfFile.Name = "LoadOfFile";
            this.LoadOfFile.Size = new System.Drawing.Size(163, 47);
            this.LoadOfFile.TabIndex = 23;
            this.LoadOfFile.Text = "Загрузить из файла";
            this.LoadOfFile.UseVisualStyleBackColor = true;
            this.LoadOfFile.Click += new System.EventHandler(this.LoadOfFile_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitMenu.Location = new System.Drawing.Point(354, 13);
            this.ExitMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(163, 47);
            this.ExitMenu.TabIndex = 22;
            this.ExitMenu.Text = "Выйти в меню";
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Text2
            // 
            this.Text2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.Location = new System.Drawing.Point(13, 306);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(147, 23);
            this.Text2.TabIndex = 21;
            this.Text2.Text = "Вывод массива:";
            // 
            // Text1
            // 
            this.Text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(13, 64);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(132, 23);
            this.Text1.TabIndex = 20;
            this.Text1.Text = "Ввод массива:";
            // 
            // MasRows
            // 
            this.MasRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasRows.Location = new System.Drawing.Point(461, 108);
            this.MasRows.Margin = new System.Windows.Forms.Padding(4);
            this.MasRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MasRows.Name = "MasRows";
            this.MasRows.Size = new System.Drawing.Size(56, 22);
            this.MasRows.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Количество строк";
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
            this.AddElem_1.Location = new System.Drawing.Point(240, 240);
            this.AddElem_1.Margin = new System.Windows.Forms.Padding(4);
            this.AddElem_1.Name = "AddElem_1";
            this.AddElem_1.Size = new System.Drawing.Size(132, 53);
            this.AddElem_1.TabIndex = 36;
            this.AddElem_1.Text = "Добавить вручную";
            this.AddElem_1.UseVisualStyleBackColor = true;
            this.AddElem_1.Click += new System.EventHandler(this.AddElem_1_Click);
            // 
            // Two_Mass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(529, 565);
            this.Controls.Add(this.AddElem_1);
            this.Controls.Add(this.OutputMas);
            this.Controls.Add(this.AddElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputOnKeyboard);
            this.Controls.Add(this.RandGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MasRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasCols);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.LoadOfFile);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Two_Mass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Двумерный массив";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Two_Mass_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MasCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox OutputMas;
        private System.Windows.Forms.Button AddElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InputOnKeyboard;
        private System.Windows.Forms.Button RandGenerate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown MasCols;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Button LoadOfFile;
        private System.Windows.Forms.Button ExitMenu;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        public System.Windows.Forms.NumericUpDown MasRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button AddElem_1;
    }
}