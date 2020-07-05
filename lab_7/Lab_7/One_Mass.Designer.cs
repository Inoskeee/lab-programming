namespace Lab_7
{
    partial class One_Mass
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
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.ExitMenu = new System.Windows.Forms.Button();
            this.LoadOfFile = new System.Windows.Forms.Button();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.MasSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RandGenerate = new System.Windows.Forms.Button();
            this.InputOnKeyboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Keys = new System.Windows.Forms.NumericUpDown();
            this.Numbers = new System.Windows.Forms.NumericUpDown();
            this.DeleteElem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OutputMas = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MasSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(8, 53);
            this.Text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(104, 19);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Ввод массива:";
            // 
            // Text2
            // 
            this.Text2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.Location = new System.Drawing.Point(8, 252);
            this.Text2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(116, 19);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "Вывод массива:";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitMenu.Location = new System.Drawing.Point(268, 12);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(122, 38);
            this.ExitMenu.TabIndex = 2;
            this.ExitMenu.Text = "Выйти в меню";
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // LoadOfFile
            // 
            this.LoadOfFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadOfFile.Location = new System.Drawing.Point(12, 12);
            this.LoadOfFile.Name = "LoadOfFile";
            this.LoadOfFile.Size = new System.Drawing.Size(122, 38);
            this.LoadOfFile.TabIndex = 3;
            this.LoadOfFile.Text = "Загрузить из файла";
            this.LoadOfFile.UseVisualStyleBackColor = true;
            this.LoadOfFile.Click += new System.EventHandler(this.LoadOfFile_Click);
            // 
            // SaveInFile
            // 
            this.SaveInFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveInFile.Location = new System.Drawing.Point(140, 12);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(122, 38);
            this.SaveInFile.TabIndex = 4;
            this.SaveInFile.Text = "Сохранить в файл";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
            // 
            // MasSize
            // 
            this.MasSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasSize.Location = new System.Drawing.Point(111, 89);
            this.MasSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MasSize.Name = "MasSize";
            this.MasSize.Size = new System.Drawing.Size(42, 20);
            this.MasSize.TabIndex = 5;
            this.MasSize.ValueChanged += new System.EventHandler(this.MasSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер массива";
            // 
            // RandGenerate
            // 
            this.RandGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RandGenerate.Location = new System.Drawing.Point(15, 180);
            this.RandGenerate.Name = "RandGenerate";
            this.RandGenerate.Size = new System.Drawing.Size(146, 59);
            this.RandGenerate.TabIndex = 7;
            this.RandGenerate.Text = "Сгенерировать массив";
            this.RandGenerate.UseVisualStyleBackColor = true;
            this.RandGenerate.Click += new System.EventHandler(this.RandGenerate_Click);
            // 
            // InputOnKeyboard
            // 
            this.InputOnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputOnKeyboard.Location = new System.Drawing.Point(15, 115);
            this.InputOnKeyboard.Name = "InputOnKeyboard";
            this.InputOnKeyboard.Size = new System.Drawing.Size(146, 59);
            this.InputOnKeyboard.TabIndex = 10;
            this.InputOnKeyboard.Text = "Создать массив вручную";
            this.InputOnKeyboard.UseVisualStyleBackColor = true;
            this.InputOnKeyboard.Click += new System.EventHandler(this.InputOnKeyboard_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(265, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Удалить N элементов начиная с номера K";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "K = ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "N = ";
            // 
            // Keys
            // 
            this.Keys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Keys.Location = new System.Drawing.Point(291, 133);
            this.Keys.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Keys.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Keys.Name = "Keys";
            this.Keys.Size = new System.Drawing.Size(50, 20);
            this.Keys.TabIndex = 14;
            this.Keys.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Keys.ValueChanged += new System.EventHandler(this.Keys_ValueChanged);
            // 
            // Numbers
            // 
            this.Numbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbers.Location = new System.Drawing.Point(291, 159);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(50, 20);
            this.Numbers.TabIndex = 15;
            this.Numbers.ValueChanged += new System.EventHandler(this.Numbers_ValueChanged);
            // 
            // DeleteElem
            // 
            this.DeleteElem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteElem.Location = new System.Drawing.Point(268, 197);
            this.DeleteElem.Name = "DeleteElem";
            this.DeleteElem.Size = new System.Drawing.Size(127, 42);
            this.DeleteElem.TabIndex = 16;
            this.DeleteElem.Text = "Удалить";
            this.DeleteElem.UseVisualStyleBackColor = true;
            this.DeleteElem.Click += new System.EventHandler(this.DeleteElem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OutputMas
            // 
            this.OutputMas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputMas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputMas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputMas.Location = new System.Drawing.Point(13, 285);
            this.OutputMas.Multiline = true;
            this.OutputMas.Name = "OutputMas";
            this.OutputMas.ReadOnly = true;
            this.OutputMas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OutputMas.Size = new System.Drawing.Size(382, 35);
            this.OutputMas.TabIndex = 19;
            this.OutputMas.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // One_Mass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(405, 345);
            this.Controls.Add(this.OutputMas);
            this.Controls.Add(this.DeleteElem);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.Keys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputOnKeyboard);
            this.Controls.Add(this.RandGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasSize);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.LoadOfFile);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "One_Mass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одномерный массив";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.One_Mass_FormClosed);
            this.Load += new System.EventHandler(this.One_Mass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button ExitMenu;
        private System.Windows.Forms.Button LoadOfFile;
        private System.Windows.Forms.Button SaveInFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RandGenerate;
        private System.Windows.Forms.Button InputOnKeyboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Keys;
        private System.Windows.Forms.NumericUpDown Numbers;
        private System.Windows.Forms.Button DeleteElem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.NumericUpDown MasSize;
        public System.Windows.Forms.TextBox OutputMas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}