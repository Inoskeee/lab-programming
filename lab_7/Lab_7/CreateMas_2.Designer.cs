﻿namespace Lab_7
{
    partial class CreateMas_2
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
            this.Send = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.Txt1 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Send.Location = new System.Drawing.Point(101, 129);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 28);
            this.Send.TabIndex = 9;
            this.Send.Text = "Создать";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Visible = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next.Location = new System.Drawing.Point(101, 92);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 28);
            this.Next.TabIndex = 8;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1.Location = new System.Drawing.Point(89, 52);
            this.Num1.Margin = new System.Windows.Forms.Padding(4);
            this.Num1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(60, 22);
            this.Num1.TabIndex = 7;
            // 
            // Txt1
            // 
            this.Txt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt1.AutoSize = true;
            this.Txt1.Location = new System.Drawing.Point(60, 54);
            this.Txt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(32, 17);
            this.Txt1.TabIndex = 6;
            this.Txt1.Text = "1 = ";
            // 
            // Text1
            // 
            this.Text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(8, 11);
            this.Text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(270, 17);
            this.Text1.TabIndex = 5;
            this.Text1.Text = "Вводите по очереди элементы массива";
            // 
            // Txt2
            // 
            this.Txt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt2.AutoSize = true;
            this.Txt2.Location = new System.Drawing.Point(183, 54);
            this.Txt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(65, 17);
            this.Txt2.TabIndex = 10;
            this.Txt2.Text = "1 строка";
            // 
            // CreateMas_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(303, 182);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Text1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateMas_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создвние массива";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateMas_2_FormClosed);
            this.Load += new System.EventHandler(this.CreateMas_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.Label Txt1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Txt2;
    }
}