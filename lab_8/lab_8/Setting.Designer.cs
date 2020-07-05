namespace lab_8
{
    partial class Setting
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
            this.checkKey = new System.Windows.Forms.CheckBox();
            this.checkZnak = new System.Windows.Forms.CheckBox();
            this.numKey = new System.Windows.Forms.NumericUpDown();
            this.textZnak = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelZnak = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkKey
            // 
            this.checkKey.AutoSize = true;
            this.checkKey.Location = new System.Drawing.Point(12, 31);
            this.checkKey.Name = "checkKey";
            this.checkKey.Size = new System.Drawing.Size(73, 17);
            this.checkKey.TabIndex = 0;
            this.checkKey.Text = "По ключу";
            this.checkKey.UseVisualStyleBackColor = true;
            this.checkKey.CheckedChanged += new System.EventHandler(this.checkKey_CheckedChanged);
            // 
            // checkZnak
            // 
            this.checkZnak.AutoSize = true;
            this.checkZnak.Location = new System.Drawing.Point(133, 31);
            this.checkZnak.Name = "checkZnak";
            this.checkZnak.Size = new System.Drawing.Size(92, 17);
            this.checkZnak.TabIndex = 1;
            this.checkZnak.Text = "По значению";
            this.checkZnak.UseVisualStyleBackColor = true;
            this.checkZnak.CheckedChanged += new System.EventHandler(this.checkZnak_CheckedChanged);
            // 
            // numKey
            // 
            this.numKey.Enabled = false;
            this.numKey.Location = new System.Drawing.Point(12, 76);
            this.numKey.Name = "numKey";
            this.numKey.Size = new System.Drawing.Size(73, 20);
            this.numKey.TabIndex = 2;
            // 
            // textZnak
            // 
            this.textZnak.Enabled = false;
            this.textZnak.Location = new System.Drawing.Point(133, 76);
            this.textZnak.Name = "textZnak";
            this.textZnak.Size = new System.Drawing.Size(92, 20);
            this.textZnak.TabIndex = 3;
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(27)))));
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.Del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Del.Location = new System.Drawing.Point(62, 112);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(95, 33);
            this.Del.TabIndex = 4;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удалить";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Enabled = false;
            this.labelKey.Location = new System.Drawing.Point(12, 57);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(51, 13);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "Позиция";
            // 
            // labelZnak
            // 
            this.labelZnak.AutoSize = true;
            this.labelZnak.Enabled = false;
            this.labelZnak.Location = new System.Drawing.Point(133, 57);
            this.labelZnak.Name = "labelZnak";
            this.labelZnak.Size = new System.Drawing.Size(56, 13);
            this.labelZnak.TabIndex = 7;
            this.labelZnak.Text = "Фамилия";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 157);
            this.Controls.Add(this.labelZnak);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.textZnak);
            this.Controls.Add(this.numKey);
            this.Controls.Add(this.checkZnak);
            this.Controls.Add(this.checkKey);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setting_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkKey;
        private System.Windows.Forms.CheckBox checkZnak;
        private System.Windows.Forms.NumericUpDown numKey;
        private System.Windows.Forms.TextBox textZnak;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelZnak;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}