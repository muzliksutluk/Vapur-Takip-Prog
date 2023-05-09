using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vapur_takip
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            fiyatlar();
            giriş();
            radioButton1.Checked=true;
          
        }
        private void giriş()
        {
            string conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Seferler", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Seferler");
            dataGridView1.DataSource = ds.Tables["Seferler"];
            conn.Close();
        }
        private void fiyatlar()
        {
            string conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Fiyatlar", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Fiyatlar");
            dataGridView2.DataSource = ds.Tables["Fiyatlar"];
             conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aratılan;
            if (radioButton2.Checked == true)
            {
                aratılan = "Araba vapuru";
            }
            else
            {
                aratılan = "Vapur";
            }
            string conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            conn.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Seferler WHERE Ne= '" + aratılan + "'  AND Nerden ='"+comboBox1.Text+"' AND Nereye ='"+comboBox2.Text+"'", conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Seferler");
            dataGridView1.DataSource = ds.Tables["Seferler"];
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                if (comboBox2.Text == "Konak")
                {
                    comboBox2.Text = "Foça";
                }
                else
                {
                    comboBox2.Text = "Konak";
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                if (comboBox1.Text == "Konak")
                {
                    comboBox1.Text = "Foça";
                }
                else
                {
                    comboBox1.Text = "Konak";
                }
            }
        }
        Form1 abc;
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
          
           
        }
    }
}
