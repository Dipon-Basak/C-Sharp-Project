
namespace WindowsFormsApplicationRestaurant
{
    partial class SellerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerLogin));
            this.btnSalesmanPassShow = new System.Windows.Forms.Button();
            this.btnSalesmanPassHide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSalesmanLogin = new System.Windows.Forms.Button();
            this.lblSalesmanPassword = new System.Windows.Forms.Label();
            this.lblSalesmanID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesmanPassShow
            // 
            this.btnSalesmanPassShow.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalesmanPassShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesmanPassShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesmanPassShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesmanPassShow.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesmanPassShow.Image")));
            this.btnSalesmanPassShow.Location = new System.Drawing.Point(484, 245);
            this.btnSalesmanPassShow.Name = "btnSalesmanPassShow";
            this.btnSalesmanPassShow.Size = new System.Drawing.Size(31, 22);
            this.btnSalesmanPassShow.TabIndex = 39;
            this.btnSalesmanPassShow.UseVisualStyleBackColor = false;
            // 
            // btnSalesmanPassHide
            // 
            this.btnSalesmanPassHide.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalesmanPassHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalesmanPassHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesmanPassHide.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalesmanPassHide.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesmanPassHide.Image")));
            this.btnSalesmanPassHide.Location = new System.Drawing.Point(484, 245);
            this.btnSalesmanPassHide.Name = "btnSalesmanPassHide";
            this.btnSalesmanPassHide.Size = new System.Drawing.Size(31, 22);
            this.btnSalesmanPassHide.TabIndex = 38;
            this.btnSalesmanPassHide.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(296, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "Salesman Login";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(386, 213);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(129, 22);
            this.txtId.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(406, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 35;
            // 
            // btnSalesmanLogin
            // 
            this.btnSalesmanLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalesmanLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesmanLogin.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesmanLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalesmanLogin.Location = new System.Drawing.Point(436, 274);
            this.btnSalesmanLogin.Name = "btnSalesmanLogin";
            this.btnSalesmanLogin.Size = new System.Drawing.Size(79, 32);
            this.btnSalesmanLogin.TabIndex = 34;
            this.btnSalesmanLogin.Text = "Login";
            this.btnSalesmanLogin.UseVisualStyleBackColor = false;
            this.btnSalesmanLogin.Click += new System.EventHandler(this.btnSalesmanLogin_Click_1);
            // 
            // lblSalesmanPassword
            // 
            this.lblSalesmanPassword.AutoSize = true;
            this.lblSalesmanPassword.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSalesmanPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesmanPassword.Font = new System.Drawing.Font("Zilla Slab SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalesmanPassword.Location = new System.Drawing.Point(270, 244);
            this.lblSalesmanPassword.Name = "lblSalesmanPassword";
            this.lblSalesmanPassword.Size = new System.Drawing.Size(110, 25);
            this.lblSalesmanPassword.TabIndex = 33;
            this.lblSalesmanPassword.Text = "PASSWORD";
            // 
            // lblSalesmanID
            // 
            this.lblSalesmanID.AutoSize = true;
            this.lblSalesmanID.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesmanID.Font = new System.Drawing.Font("Zilla Slab SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalesmanID.Location = new System.Drawing.Point(269, 213);
            this.lblSalesmanID.Name = "lblSalesmanID";
            this.lblSalesmanID.Size = new System.Drawing.Size(109, 25);
            this.lblSalesmanID.TabIndex = 32;
            this.lblSalesmanID.Text = "USERID        ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(386, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(129, 24);
            this.txtPassword.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(5, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 32);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SellerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSalesmanPassShow);
            this.Controls.Add(this.btnSalesmanPassHide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSalesmanLogin);
            this.Controls.Add(this.lblSalesmanPassword);
            this.Controls.Add(this.lblSalesmanID);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalesmanPassShow;
        private System.Windows.Forms.Button btnSalesmanPassHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSalesmanLogin;
        private System.Windows.Forms.Label lblSalesmanPassword;
        private System.Windows.Forms.Label lblSalesmanID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
    }
}