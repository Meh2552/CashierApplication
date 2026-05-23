namespace CashierApplication
{
    partial class frmLoginAcoount
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tblpnAddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnFields = new CashierApplication.RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbxItem = new CashierApplication.RoundedTxBx();
            this.txbxBrand = new CashierApplication.RoundedTxBx();
            this.tblpnAddProduct.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(25, 18);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(124, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "User Login";
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(0, 198);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(351, 130);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.DimGray;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(289, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(62, 69);
            this.btnCloseForm.TabIndex = 14;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // tblpnAddProduct
            // 
            this.tblpnAddProduct.ColumnCount = 1;
            this.tblpnAddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnAddProduct.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnAddProduct.Controls.Add(this.pnBody, 0, 1);
            this.tblpnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.tblpnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnAddProduct.Name = "tblpnAddProduct";
            this.tblpnAddProduct.RowCount = 2;
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63612F));
            this.tblpnAddProduct.Size = new System.Drawing.Size(351, 367);
            this.tblpnAddProduct.TabIndex = 15;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Controls.Add(this.btnCloseForm);
            this.pnHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(351, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnFields);
            this.pnBody.Controls.Add(this.btnSubmit);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(351, 298);
            this.pnBody.TabIndex = 1;
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.Controls.Add(this.label5);
            this.pnFields.Controls.Add(this.label1);
            this.pnFields.Controls.Add(this.lbUsername);
            this.pnFields.Controls.Add(this.lbPassword);
            this.pnFields.Controls.Add(this.txbxItem);
            this.pnFields.Controls.Add(this.txbxBrand);
            this.pnFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnFields.ForeColor = System.Drawing.Color.Transparent;
            this.pnFields.Location = new System.Drawing.Point(0, -23);
            this.pnFields.Margin = new System.Windows.Forms.Padding(0);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 50;
            this.pnFields.Size = new System.Drawing.Size(351, 245);
            this.pnFields.TabIndex = 15;
            this.pnFields.Thickness = 5F;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(138, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Invalid username";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(139, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Invalid password";
            this.label1.Visible = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(51, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 21);
            this.lbUsername.TabIndex = 14;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(51, 130);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 21);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txbxItem
            // 
            this.txbxItem.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxItem.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxItem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxItem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxItem.BorderRadius = 0;
            this.txbxItem.BorderSize = 2;
            this.txbxItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxItem.Location = new System.Drawing.Point(44, 79);
            this.txbxItem.Margin = new System.Windows.Forms.Padding(4);
            this.txbxItem.MaxLength = 200;
            this.txbxItem.Multiline = false;
            this.txbxItem.Name = "txbxItem";
            this.txbxItem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxItem.PasswordChar = false;
            this.txbxItem.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxItem.PlaceholderText = "Item";
            this.txbxItem.Size = new System.Drawing.Size(272, 32);
            this.txbxItem.TabIndex = 0;
            this.txbxItem.Texts = "";
            this.txbxItem.UnderlinedStyle = false;
            // 
            // txbxBrand
            // 
            this.txbxBrand.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxBrand.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxBrand.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxBrand.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxBrand.BorderRadius = 0;
            this.txbxBrand.BorderSize = 2;
            this.txbxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxBrand.Location = new System.Drawing.Point(44, 155);
            this.txbxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txbxBrand.MaxLength = 35;
            this.txbxBrand.Multiline = false;
            this.txbxBrand.Name = "txbxBrand";
            this.txbxBrand.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxBrand.PasswordChar = false;
            this.txbxBrand.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxBrand.PlaceholderText = "0";
            this.txbxBrand.Size = new System.Drawing.Size(272, 32);
            this.txbxBrand.TabIndex = 1;
            this.txbxBrand.Texts = "";
            this.txbxBrand.UnderlinedStyle = false;
            // 
            // frmLoginAcoount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(351, 367);
            this.Controls.Add(this.tblpnAddProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLoginAcoount";
            this.Text = "Student Registration";
            this.tblpnAddProduct.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnFields.ResumeLayout(false);
            this.pnFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private CashierApplication.RoundedTxBx txbxBrand;
        private System.Windows.Forms.Label lbUsername;
        private CashierApplication.RoundedTxBx txbxItem;
        private CashierApplication.RoundedPanel pnFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

