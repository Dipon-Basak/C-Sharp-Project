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
    public partial class AdminManageSellers : Form
    {
        public AdminManageSellers()
        {
            InitializeComponent();
        }


        //sql Database connect
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K53PB6A\SQLEXPRESS;Initial Catalog=RestaurantDatabase;Integrated Security=True");


        //this method for showing Database table's data in gridview table
        private void helper()
        {
            con.Open();
            string query = "select * from TBLseller";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DGVSalesman.DataSource = ds.Tables[0];
            con.Close();
        }


        //Load the Form and data shows in GridView Table
        private void AdminManageSellers_Load(object sender, EventArgs e)
        {
            helper();
        }

        private void DGVSalesman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearContent();
            txtSellerId.Text = DGVSalesman.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = DGVSalesman.SelectedRows[0].Cells[1].Value.ToString();
            txtSellerAge.Text = DGVSalesman.SelectedRows[0].Cells[2].Value.ToString();
            txtSellerPassword.Text = DGVSalesman.SelectedRows[0].Cells[3].Value.ToString();
            txtSellerPhone.Text = DGVSalesman.SelectedRows[0].Cells[4].Value.ToString();
        }




        //button add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into TBLseller values('" + txtSellerId.Text + "','" + txtSellerName.Text + "','" + txtSellerAge.Text + "','" + txtSellerPassword.Text + "','"+txtSellerPhone.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                helper();
                clearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //button edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerId.Text == "")
                {
                    MessageBox.Show("Select food");
                }
                else
                {
                    con.Open();
                    string query = "update TBLseller set SellerName='" + txtSellerName.Text + "',SellerAge=" + txtSellerAge.Text + ",SellerPassword='" + txtSellerPassword.Text + "',PhoneNumber='" + txtSellerPhone.Text + "'where SellerId='" + txtSellerId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Seller Updated successfully");
                    con.Close();
                    helper();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //button delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerId.Text == "")
                {
                    MessageBox.Show("Select a seller");
                }
                else
                {
                    con.Open();
                    string query = "delete from TBLseller where SellerId=" + txtSellerId.Text +"";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Seller deleted successfully");
                    con.Close();
                    helper();
                    clearContent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //clear button method
        private void clearContent()
        {
            this.txtSellerId.Text = "";
            this.txtSellerName.Text = "";
            this.txtSellerAge.Text = "";
            this.txtSellerPassword.Text = "";
            this.txtSellerPhone.Text = "";
        }


        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearContent();
        }


        //button logout
        private void btnSellerLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        //button Food Menu
        private void btnFoodMenuSellers_Click(object sender, EventArgs e)
        {
            AdminManageFoodMenu fdmenu = new AdminManageFoodMenu();
            fdmenu.Show();
            this.Hide();
        }
 
    }
}
