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

namespace WindowsFormsApplicationRestaurant
{
    public partial class SellerLogin : Form
    {
        public SellerLogin()
        {
            InitializeComponent();
        }


        //sql Database connect
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K53PB6A\SQLEXPRESS;Initial Catalog=RestaurantDatabase;Integrated Security=True");



        //Salesman Login password Show/Hide
        private void btnSalesmanPassShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnSalesmanPassHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnSalesmanPassHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnSalesmanPassShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        //private void btnSalesmanLogin_Click(object sender, EventArgs e)
        //{
        //}

        //back to FormLogin Form
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin frmLg = new FormLogin();
            frmLg.Show();
            this.Hide();
        }

        //Salesman Login
        private void btnSalesmanLogin_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from TBLseller where SellerId='" + this.txtId.Text + "' and SellerPassword='" + this.txtPassword + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            con.Close();

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Successful");
                Selling go = new Selling();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("recheck your userid and password");
            }
        }
    }
}
