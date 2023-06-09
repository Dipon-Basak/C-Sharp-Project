﻿using System;
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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }


        //logout
        private void btnOptionLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlogin = new FormLogin();
            frmlogin.Show();
            this.Hide();
        }


        //move food menu
        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            AdminManageFoodMenu fdMenu = new AdminManageFoodMenu();
            fdMenu.Show();
            this.Hide();
        }

        //move seller
        private void btnSeller_Click(object sender, EventArgs e)
        {
            AdminManageSellers mngseller = new AdminManageSellers();
            mngseller.Show();
            this.Hide();
        }

        //form exit
        private void lblCloseOptionForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
