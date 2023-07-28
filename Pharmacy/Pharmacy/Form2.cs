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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Startpoint = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Startpoint += 1;
            ProgressBar1.Value = Startpoint;
            Percentage.Text = Startpoint + "%";
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                Timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    



    }
}
