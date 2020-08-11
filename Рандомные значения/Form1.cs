using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рандомные_значения
{
    public partial class Form1 : Form
    {   int random_2, random_1;
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
         

         var r = new Random();
         random_1 = r.Next(-10, 10);
         random_2 = r.Next(-10, 10);
         textBox1.Text = random_1.ToString();
         textBox4.Text = random_2.ToString();

         }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void ИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение предназначено для \r" +
                            "проверки правильности уравнения" +
                            "\r\rРазработал: Полчихин А.");
        }

        public void button2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox2.Text, out int i))
            {
                textBox3.Text = random_1 * random_2 == i ? "Верно" : "Не верно";
            }
            else textBox3.Text = "Не число";
        }
    }
}
