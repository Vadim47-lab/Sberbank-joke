using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Прикол_от_сбербанка
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string[] Infomation = { "Мы в вас не сомневались." };
            listBox1.Items.AddRange(Infomation);
            listBox1.ItemHeight = 100;
        }

        private void Заново_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }
    }
}
