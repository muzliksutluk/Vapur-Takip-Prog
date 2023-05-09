using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace vapur_takip
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void kullancaz()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            kullancaz();
            textBox1.MaxLength = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "SELECT * FROM Seferler WHERE no='" + textBox1.Text + "'";
                cmd.Connection = conn;
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    textBox1.Text = reader["No"].ToString();
                    comboBox1.Text = reader["Nereye"].ToString();
                    dateTimePicker1.Text = reader["Nezaman"].ToString();
                    comboBox2.Text = reader["Ne"].ToString();
                }
                else
                {
                    textBox1.Clear();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata:{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = "DELETE FROM Seferler WHERE no='" + textBox1.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            kullancaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String conString = "Data Source=maindatabase.db;verison=3";
            SQLiteConnection conn = new SQLiteConnection(conString);
            try
            {

                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText =
                    "UPDATE Seferler SET Nerden=@V,Nereye=@A,Nezaman=@E,Ne=@Q WHERE No=@N";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@V", comboBox1.Text);
                cmd.Parameters.AddWithValue("@A", comboBox3.Text);
                cmd.Parameters.AddWithValue("@E", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Q", comboBox2.Text);  
                cmd.Parameters.AddWithValue("@N", textBox1.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                kullancaz();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata:{ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            
                try
                {
                    String conString = "Data Source=maindatabase.db;verison=3";
                    SQLiteConnection conn = new SQLiteConnection(conString);
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText =
                        "INSERT INTO Seferler VALUES('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    kullancaz();

                }
                catch
                {
                    MessageBox.Show("Hatalı girdiniz");
                }
            
          


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 abc = new Form5();
            abc.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox3.Text)
            {
                if (comboBox3.Text == "Konak")
                {
                    comboBox3.Text = "Foça";
                }
                else
                {
                    comboBox3.Text = "Konak";
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox3.Text)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
