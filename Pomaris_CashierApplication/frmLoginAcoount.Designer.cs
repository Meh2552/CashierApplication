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
            this.lbUsernameError = new System.Windows.Forms.Label();
            this.lbPasswordError = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbxUsername = new CashierApplication.RoundedTxBx();
            this.txbxPassword = new CashierApplication.RoundedTxBx();
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
            this.lbHeader.Location = new System.Drawing.Point(24, 13);
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
            this.btnSubmit.Location = new System.Drawing.Point(0, 247);
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
            this.btnCloseForm.Size = new System.Drawing.Size(62, 58);
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
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63612F));
            this.tblpnAddProduct.Size = new System.Drawing.Size(351, 411);
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
            this.pnHeader.Size = new System.Drawing.Size(351, 58);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnFields);
            this.pnBody.Controls.Add(this.btnSubmit);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 58);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(351, 353);
            this.pnBody.TabIndex = 1;
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.Controls.Add(this.lbUsernameError);
            this.pnFields.Controls.Add(this.lbPasswordError);
            this.pnFields.Controls.Add(this.lbUsername);
            this.pnFields.Controls.Add(this.lbPassword);
            this.pnFields.Controls.Add(this.txbxUsername);
            this.pnFields.Controls.Add(this.txbxPassword);
            this.pnFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnFields.ForeColor = System.Drawing.Color.Transparent;
            this.pnFields.Location = new System.Drawing.Point(0, -22);
            this.pnFields.Margin = new System.Windows.Forms.Padding(0);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 50;
            this.pnFields.Size = new System.Drawing.Size(351, 293);
            this.pnFields.TabIndex = 15;
            this.pnFields.Thickness = 5F;
            // 
            // lbUsernameError
            // 
            this.lbUsernameError.AutoSize = true;
            this.lbUsernameError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameError.ForeColor = System.Drawing.Color.Tomato;
            this.lbUsernameError.Location = new System.Drawing.Point(135, 70);
            this.lbUsernameError.Name = "lbUsernameError";
            this.lbUsernameError.Size = new System.Drawing.Size(96, 16);
            this.lbUsernameError.TabIndex = 39;
            this.lbUsernameError.Text = "Invalid username";
            this.lbUsernameError.Visible = false;
            // 
            // lbPasswordError
            // 
            this.lbPasswordError.AutoSize = true;
            this.lbPasswordError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordError.ForeColor = System.Drawing.Color.Tomato;
            this.lbPasswordError.Location = new System.Drawing.Point(135, 170);
            this.lbPasswordError.Name = "lbPasswordError";
            this.lbPasswordError.Size = new System.Drawing.Size(95, 16);
            this.lbPasswordError.TabIndex = 30;
            this.lbPasswordError.Text = "Invalid password";
            this.lbPasswordError.Visible = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(48, 65);
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
            this.lbPassword.Location = new System.Drawing.Point(48, 165);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 21);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txbxUsername
            // 
            this.txbxUsername.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxUsername.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxUsername.BorderRadius = 0;
            this.txbxUsername.BorderSize = 2;
            this.txbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxUsername.Location = new System.Drawing.Point(41, 90);
            this.txbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbxUsername.MaxLength = 200;
            this.txbxUsername.Multiline = false;
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxUsername.PasswordChar = false;
            this.txbxUsername.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxUsername.PlaceholderText = "Username";
            this.txbxUsername.Size = new System.Drawing.Size(272, 32);
            this.txbxUsername.TabIndex = 0;
            this.txbxUsername.Texts = "";
            this.txbxUsername.UnderlinedStyle = false;
            // 
            // txbxPassword
            // 
            this.txbxPassword.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxPassword.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxPassword.BorderRadius = 0;
            this.txbxPassword.BorderSize = 2;
            this.txbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPassword.Location = new System.Drawing.Point(41, 190);
            this.txbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPassword.MaxLength = 35;
            this.txbxPassword.Multiline = false;
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxPassword.PasswordChar = false;
            this.txbxPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxPassword.PlaceholderText = "Password";
            this.txbxPassword.Size = new System.Drawing.Size(272, 32);
            this.txbxPassword.TabIndex = 1;
            this.txbxPassword.Texts = "";
            this.txbxPassword.UnderlinedStyle = false;
            // 
            // frmLoginAcoount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(351, 411);
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
        private CashierApplication.RoundedTxBx txbxPassword;
        private System.Windows.Forms.Label lbUsername;
        private CashierApplication.RoundedTxBx txbxUsername;
        private CashierApplication.RoundedPanel pnFields;
        private System.Windows.Forms.Label lbPasswordError;
        private System.Windows.Forms.Label lbUsernameError;
    }
}

