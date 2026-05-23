namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxChange = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.txbxAmount = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxRecieved = new CashierApplication.RoundedTxBx();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPriceError = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbxPrice = new CashierApplication.RoundedTxBx();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txbxColor = new CashierApplication.RoundedTxBx();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txbxItem = new CashierApplication.RoundedTxBx();
            this.txbxBrand = new CashierApplication.RoundedTxBx();
            this.label5 = new System.Windows.Forms.Label();
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
            this.lbHeader.Size = new System.Drawing.Size(290, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Purchase Discounted Item";
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
            this.btnSubmit.Location = new System.Drawing.Point(0, 399);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(465, 147);
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
            this.btnCloseForm.Location = new System.Drawing.Point(403, -3);
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
            this.tblpnAddProduct.Size = new System.Drawing.Size(465, 590);
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
            this.pnHeader.Size = new System.Drawing.Size(465, 69);
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
            this.pnBody.Size = new System.Drawing.Size(465, 521);
            this.pnBody.TabIndex = 1;
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.Controls.Add(this.label5);
            this.pnFields.Controls.Add(this.label4);
            this.pnFields.Controls.Add(this.label3);
            this.pnFields.Controls.Add(this.txbxChange);
            this.pnFields.Controls.Add(this.lbChange);
            this.pnFields.Controls.Add(this.txbxAmount);
            this.pnFields.Controls.Add(this.lbTotal);
            this.pnFields.Controls.Add(this.label2);
            this.pnFields.Controls.Add(this.txbxRecieved);
            this.pnFields.Controls.Add(this.label1);
            this.pnFields.Controls.Add(this.lbPriceError);
            this.pnFields.Controls.Add(this.lbPrice);
            this.pnFields.Controls.Add(this.txbxPrice);
            this.pnFields.Controls.Add(this.lbItem);
            this.pnFields.Controls.Add(this.lbQuantity);
            this.pnFields.Controls.Add(this.txbxColor);
            this.pnFields.Controls.Add(this.lbDiscount);
            this.pnFields.Controls.Add(this.txbxItem);
            this.pnFields.Controls.Add(this.txbxBrand);
            this.pnFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnFields.ForeColor = System.Drawing.Color.Transparent;
            this.pnFields.Location = new System.Drawing.Point(0, -23);
            this.pnFields.Margin = new System.Windows.Forms.Padding(0);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 50;
            this.pnFields.Size = new System.Drawing.Size(465, 448);
            this.pnFields.TabIndex = 15;
            this.pnFields.Thickness = 5F;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(198, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Invalid payment";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(127, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Invalid quantity";
            this.label3.Visible = false;
            // 
            // txbxChange
            // 
            this.txbxChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.txbxChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxChange.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxChange.ForeColor = System.Drawing.Color.White;
            this.txbxChange.Location = new System.Drawing.Point(160, 387);
            this.txbxChange.Name = "txbxChange";
            this.txbxChange.Size = new System.Drawing.Size(158, 22);
            this.txbxChange.TabIndex = 36;
            this.txbxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbChange.Location = new System.Drawing.Point(207, 353);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(63, 21);
            this.lbChange.TabIndex = 35;
            this.lbChange.Text = "Change";
            // 
            // txbxAmount
            // 
            this.txbxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.txbxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxAmount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxAmount.ForeColor = System.Drawing.Color.White;
            this.txbxAmount.Location = new System.Drawing.Point(262, 217);
            this.txbxAmount.Name = "txbxAmount";
            this.txbxAmount.Size = new System.Drawing.Size(158, 22);
            this.txbxAmount.TabIndex = 34;
            this.txbxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotal.Location = new System.Drawing.Point(318, 187);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 21);
            this.lbTotal.TabIndex = 33;
            this.lbTotal.Text = "Total:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(55, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Payment Recieved";
            // 
            // txbxRecieved
            // 
            this.txbxRecieved.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxRecieved.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxRecieved.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxRecieved.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxRecieved.BorderRadius = 0;
            this.txbxRecieved.BorderSize = 2;
            this.txbxRecieved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxRecieved.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxRecieved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxRecieved.Location = new System.Drawing.Point(52, 288);
            this.txbxRecieved.Margin = new System.Windows.Forms.Padding(4);
            this.txbxRecieved.MaxLength = 20;
            this.txbxRecieved.Multiline = false;
            this.txbxRecieved.Name = "txbxRecieved";
            this.txbxRecieved.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxRecieved.PasswordChar = false;
            this.txbxRecieved.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxRecieved.PlaceholderText = "0.00";
            this.txbxRecieved.Size = new System.Drawing.Size(226, 32);
            this.txbxRecieved.TabIndex = 31;
            this.txbxRecieved.Texts = "";
            this.txbxRecieved.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(149, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Invalid discount";
            this.label1.Visible = false;
            // 
            // lbPriceError
            // 
            this.lbPriceError.AutoSize = true;
            this.lbPriceError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceError.ForeColor = System.Drawing.Color.Tomato;
            this.lbPriceError.Location = new System.Drawing.Point(295, 116);
            this.lbPriceError.Name = "lbPriceError";
            this.lbPriceError.Size = new System.Drawing.Size(71, 16);
            this.lbPriceError.TabIndex = 29;
            this.lbPriceError.Text = "Invalid price";
            this.lbPriceError.Visible = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPrice.Location = new System.Drawing.Point(246, 112);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 21);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "Price";
            // 
            // txbxPrice
            // 
            this.txbxPrice.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxPrice.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxPrice.BorderRadius = 0;
            this.txbxPrice.BorderSize = 2;
            this.txbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPrice.Location = new System.Drawing.Point(241, 137);
            this.txbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPrice.MaxLength = 20;
            this.txbxPrice.Multiline = false;
            this.txbxPrice.Name = "txbxPrice";
            this.txbxPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxPrice.PasswordChar = false;
            this.txbxPrice.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxPrice.PlaceholderText = "0.00";
            this.txbxPrice.Size = new System.Drawing.Size(186, 32);
            this.txbxPrice.TabIndex = 3;
            this.txbxPrice.Texts = "";
            this.txbxPrice.UnderlinedStyle = false;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(55, 36);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(41, 21);
            this.lbItem.TabIndex = 14;
            this.lbItem.Text = "Item";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbQuantity.Location = new System.Drawing.Point(55, 187);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(70, 21);
            this.lbQuantity.TabIndex = 17;
            this.lbQuantity.Text = "Quantity";
            // 
            // txbxColor
            // 
            this.txbxColor.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxColor.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxColor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxColor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxColor.BorderRadius = 0;
            this.txbxColor.BorderSize = 2;
            this.txbxColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxColor.Location = new System.Drawing.Point(52, 212);
            this.txbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.txbxColor.MaxLength = 20;
            this.txbxColor.Multiline = false;
            this.txbxColor.Name = "txbxColor";
            this.txbxColor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxColor.PasswordChar = false;
            this.txbxColor.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxColor.PlaceholderText = "0";
            this.txbxColor.Size = new System.Drawing.Size(183, 32);
            this.txbxColor.TabIndex = 2;
            this.txbxColor.Texts = "";
            this.txbxColor.UnderlinedStyle = false;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.White;
            this.lbDiscount.Location = new System.Drawing.Point(55, 112);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(98, 21);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Discount (%)";
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
            this.txbxItem.Location = new System.Drawing.Point(52, 61);
            this.txbxItem.Margin = new System.Windows.Forms.Padding(4);
            this.txbxItem.MaxLength = 200;
            this.txbxItem.Multiline = false;
            this.txbxItem.Name = "txbxItem";
            this.txbxItem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxItem.PasswordChar = false;
            this.txbxItem.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxItem.PlaceholderText = "Item";
            this.txbxItem.Size = new System.Drawing.Size(375, 32);
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
            this.txbxBrand.Location = new System.Drawing.Point(52, 137);
            this.txbxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txbxBrand.MaxLength = 35;
            this.txbxBrand.Multiline = false;
            this.txbxBrand.Name = "txbxBrand";
            this.txbxBrand.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxBrand.PasswordChar = false;
            this.txbxBrand.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxBrand.PlaceholderText = "0";
            this.txbxBrand.Size = new System.Drawing.Size(183, 32);
            this.txbxBrand.TabIndex = 1;
            this.txbxBrand.Texts = "";
            this.txbxBrand.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(101, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Invalid item name";
            this.label5.Visible = false;
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(465, 590);
            this.Controls.Add(this.tblpnAddProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseDiscountedItem";
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
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private CashierApplication.RoundedTxBx txbxBrand;
        private System.Windows.Forms.Label lbItem;
        private CashierApplication.RoundedTxBx txbxItem;
        private System.Windows.Forms.Label lbQuantity;
        private CashierApplication.RoundedTxBx txbxColor;
        private System.Windows.Forms.Label lbPrice;
        private CashierApplication.RoundedTxBx txbxPrice;
        private CashierApplication.RoundedPanel pnFields;
        private System.Windows.Forms.Label lbPriceError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundedTxBx txbxRecieved;
        private System.Windows.Forms.TextBox txbxChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.TextBox txbxAmount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

