using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapur_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abc = new Form2();
            abc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 abc = new Form6();   
            abc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 abc = new Form4();    
            abc.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
