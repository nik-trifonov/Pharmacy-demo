using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Pharmacy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountMedicine();
            CountCustomer();
            SumAmount();
            GetSeller();
            SumAmountBySellers();
            GetBestSeller();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Pharmacy\Pharmacy\PharmacyDB.mdf;Integrated Security=True");
        private void CountMedicine()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from MedicineTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblMedicines.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountCustomer()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblCustomers.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void CountSeller()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellers.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumAmount()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount) from BillTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellAmount.Text ="Rs" +  dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumAmountBySellers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount) from BillTbl where SellerName='" + txtSellsBySeller.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellsBySeller.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetSeller()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select SellerName from SellerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SellerName", typeof(string));
            dt.Load(Rdr);
            txtSellsBySeller.ValueMember = "SellerName";
            txtSellsBySeller.DataSource = dt;
            Con.Close();
        }
        private void GetBestCustomer()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select CustomerName from BillTbl where BillAmount ='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestCustomer.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch(Exception Ex)
            {
                Con.Close();
            }
        }

        private void GetBestSeller()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select SellerName from BillTbl where BillAmount ='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestSeller.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            this.Hide();
            Obj.Show();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer Obj = new Manufacturer();
            this.Hide();
            Obj.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            this.Hide();
            Obj.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            this.Hide();
            Obj.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers Obj = new Sellers();
            this.Hide();
            Obj.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling Obj = new Selling();
            this.Hide();
            Obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            this.Hide();
            Obj.Show();
        }

        private void txtSellsBySeller_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumAmountBySellers();
        }

        private void LblSellsBySeller_Click(object sender, EventArgs e)
        {

        }
    }
}
