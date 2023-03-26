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
    public partial class AdminManageFoodMenu : Form
    {
        public AdminManageFoodMenu()
        {
            InitializeComponent();
        }

        //Form Exit
        private void lblCloseLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //sql database connect
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K53PB6A\SQLEXPRESS;Initial Catalog=RestaurantDatabase;Integrated Security=True");

    

        //this method for showing Database table's data in gridview table
        private void helper()
        {
            con.Open();
            string query = "select * from TBLfoodMenu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DGVfoodMenu.DataSource = ds.Tables[0];
            con.Close();
        }

        //Load the Form and data shows in GridView Table
        private void AdminManageFoodMenu_Load(object sender, EventArgs e)
        {
            helper();
        }


        //textbox value added by selecting rows
        private void DGVfoodMenu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clearContent();
            txtId.Text = DGVfoodMenu.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DGVfoodMenu.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Text = DGVfoodMenu.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = DGVfoodMenu.SelectedRows[0].Cells[3].Value.ToString();
        }



        //add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into TBLfoodMenu values('" + txtId.Text + "','" + txtName.Text + "','" + txtQuantity.Text + "','" + txtPrice.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                MessageBox.Show("Category Added Successfully");
                con.Close();
                helper();
                clearContent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "") 
                {
                    MessageBox.Show("Select food");
                }
                else
                {
                    con.Open();
                    string query = "update TBLfoodMenu set FoodName='" + txtName.Text + "',FoodQuantity=" + txtQuantity.Text + ",FoodPrice=" + txtPrice.Text + "where FoodId=" + txtId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Food Updated successfully");
                    con.Close();
                    helper();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Select any Food to delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from TBLfoodMenu where FoodId=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Food deleted successfully");
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


        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearContent();
        }

        //clear button method
        private void clearContent()
        {
            this.txtId.Text = "";
            this.txtName.Text = "";
            this.txtQuantity.Text = "";
            this.txtPrice.Text = "";
        }

        //button seller
        private void btnSellers_Click(object sender, EventArgs e)
        {
            AdminManageSellers seller = new AdminManageSellers();
            seller.Show();
            this.Hide();
        }

        //button logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin loginnew = new FormLogin();
            loginnew.Show();
            this.Hide();
        }
















        //----------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------
        //Table's data show in textbox by selecting full row
        //private void DGVfoodMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    clearContent();
        //    txtId.Text = DGVfoodMenu.SelectedRows[0].Cells[0].Value.ToString();
        //    txtName.Text = DGVfoodMenu.SelectedRows[0].Cells[1].Value.ToString();
        //    txtQuantity.Text = DGVfoodMenu.SelectedRows[0].Cells[2].Value.ToString();
        //    txtPrice.Text = DGVfoodMenu.SelectedRows[0].Cells[3].Value.ToString();
            
        //    //MessageBox.Show(txtId.Text + txtName.Text + txtQuantity.Text + txtPrice.Text);
  
        //}

        //private void DGVfoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    clearContent();
        //    txtId.Text = DGVfoodMenu.SelectedRows[0].Cells[0].Value.ToString();
        //    txtName.Text = DGVfoodMenu.SelectedRows[0].Cells[1].Value.ToString();
        //    txtQuantity.Text = DGVfoodMenu.SelectedRows[0].Cells[2].Value.ToString();
        //    txtPrice.Text = DGVfoodMenu.SelectedRows[0].Cells[3].Value.ToString();
        //}
    }
}
