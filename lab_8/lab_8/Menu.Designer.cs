namespace lab_8
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListView = new System.Windows.Forms.ListView();
            this.DeleteElem = new System.Windows.Forms.Button();
            this.SaveTheFile = new System.Windows.Forms.Button();
            this.LoadTheFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_Panel = new System.Windows.Forms.Panel();
            this.Thirdname = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.PositionBus = new System.Windows.Forms.ComboBox();
            this.BusNumber = new System.Windows.Forms.ComboBox();
            this.ChangeElem = new System.Windows.Forms.Button();
            this.WayNumber = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddElem = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.search = new System.Windows.Forms.Button();
            this.onWay = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.Button();
            this.Change_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(12, 25);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(238, 377);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.List;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // DeleteElem
            // 
            this.DeleteElem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteElem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(27)))));
            this.DeleteElem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteElem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.DeleteElem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteElem.Location = new System.Drawing.Point(146, 408);
            this.DeleteElem.Name = "DeleteElem";
            this.DeleteElem.Size = new System.Drawing.Size(104, 38);
            this.DeleteElem.TabIndex = 1;
            this.DeleteElem.Text = "Удалить";
            this.DeleteElem.UseVisualStyleBackColor = false;
            this.DeleteElem.Click += new System.EventHandler(this.DeleteElem_Click);
            // 
            // SaveTheFile
            // 
            this.SaveTheFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveTheFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.SaveTheFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTheFile.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.SaveTheFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveTheFile.Location = new System.Drawing.Point(453, 408);
            this.SaveTheFile.Name = "SaveTheFile";
            this.SaveTheFile.Size = new System.Drawing.Size(104, 38);
            this.SaveTheFile.TabIndex = 1;
            this.SaveTheFile.Text = "Сохранить";
            this.SaveTheFile.UseVisualStyleBackColor = false;
            this.SaveTheFile.Click += new System.EventHandler(this.SaveTheFile_Click);
            // 
            // LoadTheFile
            // 
            this.LoadTheFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadTheFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.LoadTheFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTheFile.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.LoadTheFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadTheFile.Location = new System.Drawing.Point(343, 408);
            this.LoadTheFile.Name = "LoadTheFile";
            this.LoadTheFile.Size = new System.Drawing.Size(104, 38);
            this.LoadTheFile.TabIndex = 1;
            this.LoadTheFile.Text = "Загрузить";
            this.LoadTheFile.UseVisualStyleBackColor = false;
            this.LoadTheFile.Click += new System.EventHandler(this.LoadTheFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "База данных:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Информация:";
            // 
            // Change_Panel
            // 
            this.Change_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Change_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Change_Panel.Controls.Add(this.Thirdname);
            this.Change_Panel.Controls.Add(this.FirstName);
            this.Change_Panel.Controls.Add(this.Surname);
            this.Change_Panel.Controls.Add(this.PositionBus);
            this.Change_Panel.Controls.Add(this.BusNumber);
            this.Change_Panel.Controls.Add(this.ChangeElem);
            this.Change_Panel.Controls.Add(this.WayNumber);
            this.Change_Panel.Controls.Add(this.label8);
            this.Change_Panel.Controls.Add(this.label7);
            this.Change_Panel.Controls.Add(this.label6);
            this.Change_Panel.Controls.Add(this.label5);
            this.Change_Panel.Controls.Add(this.label4);
            this.Change_Panel.Controls.Add(this.label10);
            this.Change_Panel.Controls.Add(this.label9);
            this.Change_Panel.Controls.Add(this.label3);
            this.Change_Panel.Enabled = false;
            this.Change_Panel.Location = new System.Drawing.Point(284, 26);
            this.Change_Panel.Name = "Change_Panel";
            this.Change_Panel.Size = new System.Drawing.Size(273, 277);
            this.Change_Panel.TabIndex = 3;
            // 
            // Thirdname
            // 
            this.Thirdname.Location = new System.Drawing.Point(69, 209);
            this.Thirdname.Name = "Thirdname";
            this.Thirdname.Size = new System.Drawing.Size(134, 20);
            this.Thirdname.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(69, 179);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(134, 20);
            this.FirstName.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(69, 151);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(134, 20);
            this.Surname.TabIndex = 2;
            // 
            // PositionBus
            // 
            this.PositionBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionBus.FormattingEnabled = true;
            this.PositionBus.Items.AddRange(new object[] {
            "В пути",
            "В парке"});
            this.PositionBus.Location = new System.Drawing.Point(96, 91);
            this.PositionBus.Name = "PositionBus";
            this.PositionBus.Size = new System.Drawing.Size(107, 21);
            this.PositionBus.TabIndex = 1;
            // 
            // BusNumber
            // 
            this.BusNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusNumber.FormattingEnabled = true;
            this.BusNumber.Location = new System.Drawing.Point(107, 64);
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.Size = new System.Drawing.Size(96, 21);
            this.BusNumber.TabIndex = 1;
            // 
            // ChangeElem
            // 
            this.ChangeElem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.ChangeElem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeElem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.ChangeElem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeElem.Location = new System.Drawing.Point(166, 235);
            this.ChangeElem.Name = "ChangeElem";
            this.ChangeElem.Size = new System.Drawing.Size(104, 38);
            this.ChangeElem.TabIndex = 1;
            this.ChangeElem.Text = "Изменить";
            this.ChangeElem.UseVisualStyleBackColor = false;
            this.ChangeElem.Click += new System.EventHandler(this.ChangeElem_Click);
            // 
            // WayNumber
            // 
            this.WayNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WayNumber.FormattingEnabled = true;
            this.WayNumber.Items.AddRange(new object[] {
            "Маршрут №1",
            "Маршрут №2",
            "Маршрут №3"});
            this.WayNumber.Location = new System.Drawing.Point(107, 37);
            this.WayNumber.Name = "WayNumber";
            this.WayNumber.Size = new System.Drawing.Size(96, 21);
            this.WayNumber.TabIndex = 1;
            this.WayNumber.SelectedIndexChanged += new System.EventHandler(this.WayNumber_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "В пути/в парке:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер автобуса:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Фамилия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ИНФОРМАЦИЯ О ВОДИТЕЛЕ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ИНФОРМАЦИЯ О МАРШРУТАХ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер маршрута:";
            // 
            // AddElem
            // 
            this.AddElem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddElem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.AddElem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddElem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.AddElem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddElem.Location = new System.Drawing.Point(12, 408);
            this.AddElem.Name = "AddElem";
            this.AddElem.Size = new System.Drawing.Size(104, 38);
            this.AddElem.TabIndex = 1;
            this.AddElem.Text = "Добавить";
            this.AddElem.UseVisualStyleBackColor = false;
            this.AddElem.Click += new System.EventHandler(this.AddElem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(284, 309);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(177, 40);
            this.search.TabIndex = 4;
            this.search.Text = "Найти водителя по шаблону";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // onWay
            // 
            this.onWay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onWay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.onWay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onWay.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.onWay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onWay.Location = new System.Drawing.Point(284, 355);
            this.onWay.Name = "onWay";
            this.onWay.Size = new System.Drawing.Size(273, 38);
            this.onWay.TabIndex = 5;
            this.onWay.Text = "Узнать, кто в пути";
            this.onWay.UseVisualStyleBackColor = false;
            this.onWay.Click += new System.EventHandler(this.onWay_Click);
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(467, 309);
            this.text.MaxLength = 2;
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(90, 40);
            this.text.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Settings.Location = new System.Drawing.Point(256, 408);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Settings.Size = new System.Drawing.Size(38, 38);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "⚙";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 455);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.text);
            this.Controls.Add(this.onWay);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Change_Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadTheFile);
            this.Controls.Add(this.AddElem);
            this.Controls.Add(this.SaveTheFile);
            this.Controls.Add(this.DeleteElem);
            this.Controls.Add(this.ListView);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.Change_Panel.ResumeLayout(false);
            this.Change_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteElem;
        private System.Windows.Forms.Button SaveTheFile;
        private System.Windows.Forms.Button LoadTheFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PositionBus;
        private System.Windows.Forms.ComboBox BusNumber;
        private System.Windows.Forms.ComboBox WayNumber;
        private System.Windows.Forms.TextBox Thirdname;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Button AddElem;
        private System.Windows.Forms.Button ChangeElem;
        public System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button onWay;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button Settings;
        public System.Windows.Forms.Panel Change_Panel;
    }
}

