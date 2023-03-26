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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }

        //sql database connect
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K53PB6A\SQLEXPRESS;Initial Catalog=RestaurantDatabase;Integrated Security=True");


        //this method for showing Database table's data in gridview table
        private void helper()
        {
            con.Open();
            string query = "select FoodName,FoodPrice from TBLfoodMenu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DGVfoodMenu1.DataSource = ds.Tables[0];
            con.Close();
        }

        //Just calling the helper method when this form will load
        private void Selling_Load(object sender, EventArgs e)
        {
            helper();
        }


        //CellClick will select full row and pass data in textbox
        private void DGVfoodMenu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DGVfoodMenu1.SelectedRows[0].Cells[0].Value.ToString();
            txtPrice.Text = DGVfoodMenu1.SelectedRows[0].Cells[1].Value.ToString();
        }



        //button logout
        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin sellLogin = new FormLogin();
            sellLogin.Show();
            this.Hide();
        }

        //Date Time Set
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }


        //Add Customer Choosen Food by Salesman
        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }
    }
}
