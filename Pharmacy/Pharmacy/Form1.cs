using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ProgressBar1 : Form
    {
        public ProgressBar1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int Startpoint = 0;
        //public readonly object Percentage;
        //public object ProgressBar1 { get; private set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();
        }

    }
}
