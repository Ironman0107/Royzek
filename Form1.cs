using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Masaüstünden_resım_video_cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mert\\Desktop\\2.mp3"; // media playere yol göstererek masaüstündeki müziği açıyoruz.
            pictureBox1.ImageLocation = "C:\\Users\\Mert\\Desktop\\aas.jpg";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mert\\Desktop\\1.mp3"; // media playere yol göstererek masaüstündeki müziği açıyoruz.
            pictureBox1.ImageLocation = "C:\\Users\\Mert\\Desktop\\as.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mert\\Desktop\\can\\bg.mp3"; // media playere yol göstererek masaüstündeki müziği açıyoruz.
            pictureBox1.ImageLocation = "C:\\Users\\Mert\\Desktop\\as.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.close();
            
        }
    }
}
