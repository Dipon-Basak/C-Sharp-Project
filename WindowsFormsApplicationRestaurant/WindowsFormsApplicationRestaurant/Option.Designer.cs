
namespace WindowsFormsApplicationRestaurant
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOptionLogout = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnFoodMenu = new System.Windows.Forms.Button();
            this.lblCloseOptionForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOptionLogout
            // 
            this.btnOptionLogout.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOptionLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionLogout.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOptionLogout.Location = new System.Drawing.Point(321, 231);
            this.btnOptionLogout.Name = "btnOptionLogout";
            this.btnOptionLogout.Size = new System.Drawing.Size(161, 36);
            this.btnOptionLogout.TabIndex = 35;
            this.btnOptionLogout.Text = "Log Out";
            this.btnOptionLogout.UseVisualStyleBackColor = false;
            this.btnOptionLogout.Click += new System.EventHandler(this.btnOptionLogout_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeller.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeller.Location = new System.Drawing.Point(321, 185);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(161, 31);
            this.btnSeller.TabIndex = 37;
            this.btnSeller.Text = "Salesman";
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFoodMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodMenu.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFoodMenu.Location = new System.Drawing.Point(321, 136);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.Size = new System.Drawing.Size(161, 34);
            this.btnFoodMenu.TabIndex = 38;
            this.btnFoodMenu.Text = "Food Menu";
            this.btnFoodMenu.UseVisualStyleBackColor = false;
            this.btnFoodMenu.Click += new System.EventHandler(this.btnFoodMenu_Click);
            // 
            // lblCloseOptionForm
            // 
            this.lblCloseOptionForm.AutoSize = true;
            this.lblCloseOptionForm.BackColor = System.Drawing.Color.Red;
            this.lblCloseOptionForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCloseOptionForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseOptionForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCloseOptionForm.Location = new System.Drawing.Point(783, 0);
            this.lblCloseOptionForm.Name = "lblCloseOptionForm";
            this.lblCloseOptionForm.Size = new System.Drawing.Size(21, 20);
            this.lblCloseOptionForm.TabIndex = 39;
            this.lblCloseOptionForm.Text = "X";
            this.lblCloseOptionForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloseOptionForm.Click += new System.EventHandler(this.lblCloseOptionForm_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.lblCloseOptionForm);
            this.Controls.Add(this.btnFoodMenu);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.btnOptionLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Option";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptionLogout;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Label lblCloseOptionForm;
    }
}