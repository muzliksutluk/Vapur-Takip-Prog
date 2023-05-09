using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapur_takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "1234")
            {
                Form3 abc = new Form3();
                abc.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz isim yada şifre hatalı lütfen tekrar deneyiniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form7 abc = new Form7();
           abc.Show();
           this.Close();
        }
    }
}
