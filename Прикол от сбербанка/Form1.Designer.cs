
namespace Прикол_от_сбербанка
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Нет = new System.Windows.Forms.Button();
            this.Да = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Нет
            // 
            this.Нет.Location = new System.Drawing.Point(568, 298);
            this.Нет.Name = "Нет";
            this.Нет.Size = new System.Drawing.Size(75, 23);
            this.Нет.TabIndex = 1;
            this.Нет.Text = "Нет";
            this.Нет.UseVisualStyleBackColor = true;
            this.Нет.Click += new System.EventHandler(this.Нет_Click);
            this.Нет.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Нет_MouseDown);
            this.Нет.MouseEnter += new System.EventHandler(this.Нет_Click);
            this.Нет.MouseLeave += new System.EventHandler(this.Form1_Load);
            // 
            // Да
            // 
            this.Да.Location = new System.Drawing.Point(154, 298);
            this.Да.Name = "Да";
            this.Да.Size = new System.Drawing.Size(75, 23);
            this.Да.TabIndex = 2;
            this.Да.Text = "Да";
            this.Да.UseVisualStyleBackColor = true;
            this.Да.Click += new System.EventHandler(this.Да_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(302, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 30);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Да);
            this.Controls.Add(this.Нет);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Прикол от сбербанка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Нет;
        private System.Windows.Forms.Button Да;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

