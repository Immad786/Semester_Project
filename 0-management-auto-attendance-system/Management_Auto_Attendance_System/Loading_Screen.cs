using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Auto_Attendance_System
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Start();
        }

        int per = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            per++;

            if (per == 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 f = new Form1();
                f.Show();

            }
            else
            {
                progressBar1.Value = per;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Select(0, 0);
            textBox1.ReadOnly = true;
        }
    }
}
