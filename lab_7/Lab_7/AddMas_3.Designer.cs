﻿namespace Lab_7
{
    partial class AddMas_3
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
            this.Next = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.Txt1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Next1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.Txt2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next.Location = new System.Drawing.Point(89, 122);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 28);
            this.Next.TabIndex = 26;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1.Location = new System.Drawing.Point(197, 54);
            this.Num1.Margin = new System.Windows.Forms.Padding(4);
            this.Num1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(61, 22);
            this.Num1.TabIndex = 25;
            // 
            // Txt1
            // 
            this.Txt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt1.AutoSize = true;
            this.Txt1.Location = new System.Drawing.Point(121, 57);
            this.Txt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(65, 17);
            this.Txt1.TabIndex = 24;
            this.Txt1.Text = "1 строка";
            // 
            // Send
            // 
            this.Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Send.Location = new System.Drawing.Point(89, 158);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 32);
            this.Send.TabIndex = 23;
            this.Send.Text = "Создать";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Visible = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Next1
            // 
            this.Next1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next1.Location = new System.Drawing.Point(89, 97);
            this.Next1.Margin = new System.Windows.Forms.Padding(4);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(100, 33);
            this.Next1.TabIndex = 22;
            this.Next1.Text = "Далее";
            this.Next1.UseVisualStyleBackColor = true;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // Num2
            // 
            this.Num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num2.Location = new System.Drawing.Point(37, 54);
            this.Num2.Margin = new System.Windows.Forms.Padding(4);
            this.Num2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(60, 22);
            this.Num2.TabIndex = 21;
            this.Num2.Visible = false;
            // 
            // Txt2
            // 
            this.Txt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt2.AutoSize = true;
            this.Txt2.Location = new System.Drawing.Point(8, 57);
            this.Txt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(32, 17);
            this.Txt2.TabIndex = 20;
            this.Txt2.Text = "1 = ";
            this.Txt2.Visible = false;
            // 
            // Text1
            // 
            this.Text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(33, 11);
            this.Text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(216, 17);
            this.Text1.TabIndex = 19;
            this.Text1.Text = "Введите размер каждой строки";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddMas_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Next1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMas_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить строки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMas_3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.Label Txt1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.NumericUpDown Num2;
        private System.Windows.Forms.Label Txt2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}