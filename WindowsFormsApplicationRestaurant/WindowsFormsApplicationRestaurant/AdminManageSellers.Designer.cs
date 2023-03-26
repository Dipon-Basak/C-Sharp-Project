
namespace WindowsFormsApplicationRestaurant
{
    partial class AdminManageSellers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSellerAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSellerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFoodMenuSellers = new System.Windows.Forms.Button();
            this.btnSellerLogout = new System.Windows.Forms.Button();
            this.DGVSalesman = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalesman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.DGVSalesman);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtSellerAge);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSellerPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSellerPhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSellerName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSellerId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(114, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 461);
            this.panel2.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(81, 292);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 33);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(56, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 32);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(11, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 33);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(158, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 33);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSellerAge
            // 
            this.txtSellerAge.Location = new System.Drawing.Point(111, 152);
            this.txtSellerAge.Name = "txtSellerAge";
            this.txtSellerAge.Size = new System.Drawing.Size(117, 20);
            this.txtSellerAge.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "AGE";
            // 
            // txtSellerPassword
            // 
            this.txtSellerPassword.Location = new System.Drawing.Point(111, 194);
            this.txtSellerPassword.Name = "txtSellerPassword";
            this.txtSellerPassword.Size = new System.Drawing.Size(117, 20);
            this.txtSellerPassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "PASSWORD";
            // 
            // txtSellerPhone
            // 
            this.txtSellerPhone.Location = new System.Drawing.Point(111, 239);
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(117, 20);
            this.txtSellerPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(111, 111);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(117, 20);
            this.txtSellerName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(111, 67);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(117, 20);
            this.txtSellerId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(255, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesman";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFoodMenuSellers
            // 
            this.btnFoodMenuSellers.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFoodMenuSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodMenuSellers.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodMenuSellers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFoodMenuSellers.Location = new System.Drawing.Point(11, 180);
            this.btnFoodMenuSellers.Name = "btnFoodMenuSellers";
            this.btnFoodMenuSellers.Size = new System.Drawing.Size(93, 32);
            this.btnFoodMenuSellers.TabIndex = 31;
            this.btnFoodMenuSellers.Text = "Food Menu";
            this.btnFoodMenuSellers.UseVisualStyleBackColor = false;
            this.btnFoodMenuSellers.Click += new System.EventHandler(this.btnFoodMenuSellers_Click);
            // 
            // btnSellerLogout
            // 
            this.btnSellerLogout.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSellerLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellerLogout.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSellerLogout.Location = new System.Drawing.Point(11, 222);
            this.btnSellerLogout.Name = "btnSellerLogout";
            this.btnSellerLogout.Size = new System.Drawing.Size(93, 31);
            this.btnSellerLogout.TabIndex = 33;
            this.btnSellerLogout.Text = "Log Out";
            this.btnSellerLogout.UseVisualStyleBackColor = false;
            this.btnSellerLogout.Click += new System.EventHandler(this.btnSellerLogout_Click);
            // 
            // DGVSalesman
            // 
            this.DGVSalesman.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DGVSalesman.AllowUserToAddRows = false;
            this.DGVSalesman.AllowUserToDeleteRows = false;
            this.DGVSalesman.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVSalesman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSalesman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSalesman.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVSalesman.Location = new System.Drawing.Point(261, 65);
            this.DGVSalesman.MultiSelect = false;
            this.DGVSalesman.Name = "DGVSalesman";
            this.DGVSalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSalesman.ShowEditingIcon = false;
            this.DGVSalesman.Size = new System.Drawing.Size(397, 390);
            this.DGVSalesman.TabIndex = 37;
            this.DGVSalesman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSalesman_CellClick);
            // 
            // AdminManageSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.btnSellerLogout);
            this.Controls.Add(this.btnFoodMenuSellers);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminManageSellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManageSellers";
            this.Load += new System.EventHandler(this.AdminManageSellers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalesman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSellerPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSellerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSellerAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFoodMenuSellers;
        private System.Windows.Forms.Button btnSellerLogout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView DGVSalesman;
    }
}