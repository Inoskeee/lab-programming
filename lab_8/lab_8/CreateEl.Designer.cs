namespace lab_8
{
    partial class CreateEl
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
            this.Create = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add_Panel = new System.Windows.Forms.Panel();
            this.Thirdname = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.PositionBus = new System.Windows.Forms.ComboBox();
            this.BusNumber = new System.Windows.Forms.ComboBox();
            this.ObjPosition = new System.Windows.Forms.ComboBox();
            this.WayNumber = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Numeric = new System.Windows.Forms.NumericUpDown();
            this.Add_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Create.Location = new System.Drawing.Point(12, 295);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(104, 38);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(122, 295);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(104, 38);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add_Panel
            // 
            this.Add_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Panel.Controls.Add(this.Numeric);
            this.Add_Panel.Controls.Add(this.Thirdname);
            this.Add_Panel.Controls.Add(this.FirstName);
            this.Add_Panel.Controls.Add(this.Surname);
            this.Add_Panel.Controls.Add(this.PositionBus);
            this.Add_Panel.Controls.Add(this.BusNumber);
            this.Add_Panel.Controls.Add(this.ObjPosition);
            this.Add_Panel.Controls.Add(this.WayNumber);
            this.Add_Panel.Controls.Add(this.label8);
            this.Add_Panel.Controls.Add(this.label7);
            this.Add_Panel.Controls.Add(this.label6);
            this.Add_Panel.Controls.Add(this.label5);
            this.Add_Panel.Controls.Add(this.label4);
            this.Add_Panel.Controls.Add(this.label10);
            this.Add_Panel.Controls.Add(this.label2);
            this.Add_Panel.Controls.Add(this.label9);
            this.Add_Panel.Controls.Add(this.label3);
            this.Add_Panel.Location = new System.Drawing.Point(12, 12);
            this.Add_Panel.Name = "Add_Panel";
            this.Add_Panel.Size = new System.Drawing.Size(273, 277);
            this.Add_Panel.TabIndex = 4;
            // 
            // Thirdname
            // 
            this.Thirdname.Location = new System.Drawing.Point(69, 241);
            this.Thirdname.Name = "Thirdname";
            this.Thirdname.Size = new System.Drawing.Size(134, 20);
            this.Thirdname.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(69, 211);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(134, 20);
            this.FirstName.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(69, 183);
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
            this.PositionBus.Location = new System.Drawing.Point(96, 123);
            this.PositionBus.Name = "PositionBus";
            this.PositionBus.Size = new System.Drawing.Size(107, 21);
            this.PositionBus.TabIndex = 1;
            // 
            // BusNumber
            // 
            this.BusNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusNumber.Enabled = false;
            this.BusNumber.FormattingEnabled = true;
            this.BusNumber.Location = new System.Drawing.Point(107, 96);
            this.BusNumber.Name = "BusNumber";
            this.BusNumber.Size = new System.Drawing.Size(96, 21);
            this.BusNumber.TabIndex = 1;
            // 
            // ObjPosition
            // 
            this.ObjPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjPosition.FormattingEnabled = true;
            this.ObjPosition.Items.AddRange(new object[] {
            "В начале",
            "В конце",
            "Выбрать"});
            this.ObjPosition.Location = new System.Drawing.Point(128, 10);
            this.ObjPosition.Name = "ObjPosition";
            this.ObjPosition.Size = new System.Drawing.Size(96, 21);
            this.ObjPosition.TabIndex = 1;
            this.ObjPosition.SelectedIndexChanged += new System.EventHandler(this.ObjPosition_SelectedIndexChanged);
            // 
            // WayNumber
            // 
            this.WayNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WayNumber.FormattingEnabled = true;
            this.WayNumber.Items.AddRange(new object[] {
            "Маршрут №1",
            "Маршрут №2",
            "Маршрут №3"});
            this.WayNumber.Location = new System.Drawing.Point(107, 69);
            this.WayNumber.Name = "WayNumber";
            this.WayNumber.Size = new System.Drawing.Size(96, 21);
            this.WayNumber.TabIndex = 1;
            this.WayNumber.SelectedIndexChanged += new System.EventHandler(this.WayNumber_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "В пути/в парке:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер автобуса:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Фамилия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ИНФОРМАЦИЯ О ВОДИТЕЛЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ПОЗИЦИЯ В СПИСКЕ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ИНФОРМАЦИЯ О МАРШРУТАХ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер маршрута:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Numeric
            // 
            this.Numeric.Enabled = false;
            this.Numeric.Location = new System.Drawing.Point(230, 11);
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(40, 20);
            this.Numeric.TabIndex = 3;
            // 
            // CreateEl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 341);
            this.Controls.Add(this.Add_Panel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create);
            this.Name = "CreateEl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление в базу данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEl_FormClosed);
            this.Add_Panel.ResumeLayout(false);
            this.Add_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel Add_Panel;
        private System.Windows.Forms.TextBox Thirdname;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.ComboBox PositionBus;
        private System.Windows.Forms.ComboBox WayNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ObjPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BusNumber;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown Numeric;
    }
}