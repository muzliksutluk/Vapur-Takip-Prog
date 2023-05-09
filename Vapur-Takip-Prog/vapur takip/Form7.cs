using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vapur_takip
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Deneme1.mp4";          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abc = new Form2();
            abc.Show();
            this.Close();

            SoundPlayer player = new SoundPlayer();
            string path = "C:\\Users\\newza\\Desktop\\Rick Astley - Never Gona Give You Up project.wav";
            player.SoundLocation = path;
            player.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
