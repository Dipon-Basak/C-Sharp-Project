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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        int StartCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartCount = StartCount + 1;
            MyProgressBar.Value = StartCount;
            if(MyProgressBar.Value == 50)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                this.Hide();
                FormLogin turn = new FormLogin();
                turn.Show();

            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
