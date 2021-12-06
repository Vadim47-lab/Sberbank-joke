using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прикол_от_сбербанка
{
    public partial class Form1 : Form
    {
        private int _x;
        private int _y;

        public Form1()
        {
            InitializeComponent();
            string[] Infomation = { "Вы удовлетворены своей работой?" };
            listBox1.Items.AddRange(Infomation);
            listBox1.ItemHeight = 100;
        }

        private void Да_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void Нет_MouseDown(object sender, MouseEventArgs e)
        {
            Form.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }
        private void Нет_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _x = rnd.Next(448, 568);
            _y = rnd.Next(178, 298);
            Нет.Location = new Point(_x, _y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
