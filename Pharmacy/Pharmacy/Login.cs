using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Pharmacy\Pharmacy\PharmacyDB.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            this.Hide();
            Obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            this.Hide();
            Obj.Show();
        }
        public static String User;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter Username and Password to Login");
            }
            else 
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl where SellerName='" + txtUserName.Text + "'and SellerPassword='" + txtPassword.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = txtUserName.Text;
                    Selling Obj = new Selling();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else 
                {
                    MessageBox.Show("You have entered wrong Username and Password");

                }
                Con.Close();
            }
        }
    }
}
