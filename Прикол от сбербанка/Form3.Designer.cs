﻿
namespace Прикол_от_сбербанка
{
    partial class Form3
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
            this.Заново = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Заново
            // 
            this.Заново.Location = new System.Drawing.Point(95, 99);
            this.Заново.Name = "Заново";
            this.Заново.Size = new System.Drawing.Size(75, 23);
            this.Заново.TabIndex = 5;
            this.Заново.Text = "Заново";
            this.Заново.UseVisualStyleBackColor = true;
            this.Заново.Click += new System.EventHandler(this.Заново_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 30);
            this.listBox1.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 149);
            this.Controls.Add(this.Заново);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "Нет";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Заново;
        private System.Windows.Forms.ListBox listBox1;
    }
}