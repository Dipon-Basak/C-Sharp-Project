using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationRestaurant
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        //--------------------------------admin login---------------------------------------
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtBoxUsername.Text.ToLower().Equals("admin") && this.txtBoxPassword.Text.ToLower().Equals("admin"))
            {
                MessageBox.Show("login successful");
                Option newOption = new Option();
                newOption.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("INVALID LOGIN");
                this.txtBoxUsername.Text = "";
                this.txtBoxPassword.Text = "";
            }
        }


        //------------------------------admin login password show/hide-----------------------------
        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtBoxPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtBoxPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtBoxPassword.PasswordChar = '*';
            }
        }


        //go to seller login form
        private void btnNext_Click(object sender, EventArgs e)
        {
            SellerLogin slogin = new SellerLogin();
            slogin.Show();
            this.Hide();
        }
    }
}
