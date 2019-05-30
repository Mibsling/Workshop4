﻿namespace Workshop4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.btnClearPackage = new System.Windows.Forms.Button();
            this.btnSavePackage = new System.Windows.Forms.Button();
            this.PackagesPanel = new System.Windows.Forms.Panel();
            this.cBoxPackages = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPkgId = new System.Windows.Forms.Label();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.lboxAddedProducts = new System.Windows.Forms.ListBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblAddedProducts = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.lblAgencyCommission = new System.Windows.Forms.Label();
            this.txtPkgId = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BackgroundPanel.SuspendLayout();
            this.PackagesPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(509, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundPanel.Controls.Add(this.btnClearPackage);
            this.BackgroundPanel.Controls.Add(this.btnSavePackage);
            this.BackgroundPanel.Controls.Add(this.PackagesPanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(152, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(676, 548);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // btnClearPackage
            // 
            this.btnClearPackage.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPackage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearPackage.Location = new System.Drawing.Point(331, 510);
            this.btnClearPackage.Name = "btnClearPackage";
            this.btnClearPackage.Size = new System.Drawing.Size(75, 34);
            this.btnClearPackage.TabIndex = 26;
            this.btnClearPackage.Text = "Clear Form";
            this.btnClearPackage.UseVisualStyleBackColor = false;
            this.btnClearPackage.Click += new System.EventHandler(this.btnClearPackage_Click);
            // 
            // btnSavePackage
            // 
            this.btnSavePackage.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSavePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePackage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePackage.Location = new System.Drawing.Point(231, 510);
            this.btnSavePackage.Name = "btnSavePackage";
            this.btnSavePackage.Size = new System.Drawing.Size(75, 34);
            this.btnSavePackage.TabIndex = 25;
            this.btnSavePackage.Text = "Save";
            this.btnSavePackage.UseVisualStyleBackColor = false;
            this.btnSavePackage.Click += new System.EventHandler(this.btnSavePackage_Click);
            // 
            // PackagesPanel
            // 
            this.PackagesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PackagesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PackagesPanel.BackgroundImage")));
            this.PackagesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PackagesPanel.Controls.Add(this.cBoxPackages);
            this.PackagesPanel.Controls.Add(this.label1);
            this.PackagesPanel.Controls.Add(this.lblPkgId);
            this.PackagesPanel.Controls.Add(this.pictureBox1);
            this.PackagesPanel.Controls.Add(this.txtAgencyCommission);
            this.PackagesPanel.Controls.Add(this.groupBox1);
            this.PackagesPanel.Controls.Add(this.lblAgencyCommission);
            this.PackagesPanel.Controls.Add(this.txtPkgId);
            this.PackagesPanel.Controls.Add(this.txtBasePrice);
            this.PackagesPanel.Controls.Add(this.lblPkgName);
            this.PackagesPanel.Controls.Add(this.lblBasePrice);
            this.PackagesPanel.Controls.Add(this.lblPkgDesc);
            this.PackagesPanel.Controls.Add(this.dtpPkgEndDate);
            this.PackagesPanel.Controls.Add(this.txtPkgDesc);
            this.PackagesPanel.Controls.Add(this.txtPkgName);
            this.PackagesPanel.Controls.Add(this.lblStartDate);
            this.PackagesPanel.Controls.Add(this.dtpPkgStartDate);
            this.PackagesPanel.Controls.Add(this.lblEndDate);
            this.PackagesPanel.Location = new System.Drawing.Point(3, 40);
            this.PackagesPanel.Name = "PackagesPanel";
            this.PackagesPanel.Size = new System.Drawing.Size(642, 465);
            this.PackagesPanel.TabIndex = 24;
            // 
            // cBoxPackages
            // 
            this.cBoxPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPackages.FormattingEnabled = true;
            this.cBoxPackages.Location = new System.Drawing.Point(348, 169);
            this.cBoxPackages.Name = "cBoxPackages";
            this.cBoxPackages.Size = new System.Drawing.Size(205, 26);
            this.cBoxPackages.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Packages";
            // 
            // lblPkgId
            // 
            this.lblPkgId.AutoSize = true;
            this.lblPkgId.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPkgId.Location = new System.Drawing.Point(13, 41);
            this.lblPkgId.Name = "lblPkgId";
            this.lblPkgId.Size = new System.Drawing.Size(99, 18);
            this.lblPkgId.TabIndex = 22;
            this.lblPkgId.Text = "Package ID:";
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyCommission.Location = new System.Drawing.Point(374, 423);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.Size = new System.Drawing.Size(100, 24);
            this.txtAgencyCommission.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRemoveProduct);
            this.groupBox1.Controls.Add(this.lboxAddedProducts);
            this.groupBox1.Controls.Add(this.lblSuppliers);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.lblAddedProducts);
            this.groupBox1.Controls.Add(this.cbSuppliers);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.cbProducts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 126);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Products";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(178, 83);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveProduct.TabIndex = 19;
            this.btnRemoveProduct.Text = "Remove from list";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // lboxAddedProducts
            // 
            this.lboxAddedProducts.BackColor = System.Drawing.SystemColors.Window;
            this.lboxAddedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxAddedProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lboxAddedProducts.FormattingEnabled = true;
            this.lboxAddedProducts.ItemHeight = 18;
            this.lboxAddedProducts.Location = new System.Drawing.Point(313, 37);
            this.lboxAddedProducts.Name = "lboxAddedProducts";
            this.lboxAddedProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxAddedProducts.Size = new System.Drawing.Size(247, 58);
            this.lboxAddedProducts.TabIndex = 9;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(30, 21);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(69, 18);
            this.lblSuppliers.TabIndex = 4;
            this.lblSuppliers.Text = "Supplier";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(30, 69);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(67, 18);
            this.lblProducts.TabIndex = 5;
            this.lblProducts.Text = "Product";
            // 
            // lblAddedProducts
            // 
            this.lblAddedProducts.AutoSize = true;
            this.lblAddedProducts.Location = new System.Drawing.Point(313, 21);
            this.lblAddedProducts.Name = "lblAddedProducts";
            this.lblAddedProducts.Size = new System.Drawing.Size(143, 18);
            this.lblAddedProducts.TabIndex = 8;
            this.lblAddedProducts.Text = "Included Products";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(30, 37);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(121, 26);
            this.cbSuppliers.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(178, 37);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 23);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add to list";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // cbProducts
            // 
            this.cbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(30, 85);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(121, 26);
            this.cbProducts.TabIndex = 11;
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.BackColor = System.Drawing.Color.Transparent;
            this.lblAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyCommission.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgencyCommission.Location = new System.Drawing.Point(345, 402);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(162, 18);
            this.lblAgencyCommission.TabIndex = 7;
            this.lblAgencyCommission.Text = "Agency Commission";
            // 
            // txtPkgId
            // 
            this.txtPkgId.Enabled = false;
            this.txtPkgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgId.Location = new System.Drawing.Point(141, 38);
            this.txtPkgId.Name = "txtPkgId";
            this.txtPkgId.Size = new System.Drawing.Size(148, 24);
            this.txtPkgId.TabIndex = 21;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(141, 423);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 24);
            this.txtBasePrice.TabIndex = 14;
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPkgName.Location = new System.Drawing.Point(13, 78);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(122, 18);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBasePrice.Location = new System.Drawing.Point(112, 402);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(160, 18);
            this.lblBasePrice.TabIndex = 6;
            this.lblBasePrice.Text = "Package Base Price";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPkgDesc.Location = new System.Drawing.Point(12, 198);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(174, 20);
            this.lblPkgDesc.TabIndex = 1;
            this.lblPkgDesc.Text = "Package Description";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Location = new System.Drawing.Point(16, 171);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(296, 24);
            this.dtpPkgEndDate.TabIndex = 17;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(17, 221);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(406, 45);
            this.txtPkgDesc.TabIndex = 13;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(141, 72);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(148, 24);
            this.txtPkgName.TabIndex = 12;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(13, 102);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 18);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Location = new System.Drawing.Point(16, 123);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(296, 24);
            this.dtpPkgStartDate.TabIndex = 16;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndDate.Location = new System.Drawing.Point(13, 150);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 18);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 363);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 142);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(3, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // NavPanel
            // 
            this.NavPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavPanel.BackgroundImage")));
            this.NavPanel.Controls.Add(this.btnSuppliers);
            this.NavPanel.Controls.Add(this.btnProducts);
            this.NavPanel.Controls.Add(this.btnPackages);
            this.NavPanel.Controls.Add(this.pictureBox2);
            this.NavPanel.Controls.Add(this.pictureBox3);
            this.NavPanel.Controls.Add(this.pictureBox4);
            this.NavPanel.Location = new System.Drawing.Point(-2, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(160, 548);
            this.NavPanel.TabIndex = 5;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(3, 511);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(157, 34);
            this.btnSuppliers.TabIndex = 7;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(3, 313);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(157, 34);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.Location = new System.Drawing.Point(3, 134);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(157, 34);
            this.btnPackages.TabIndex = 5;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 548);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BackgroundPanel.ResumeLayout(false);
            this.PackagesPanel.ResumeLayout(false);
            this.PackagesPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblAgencyCommission;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Panel PackagesPanel;
        private System.Windows.Forms.Label lblPkgId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.ListBox lboxAddedProducts;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblAddedProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.TextBox txtPkgId;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSavePackage;
        private System.Windows.Forms.Button btnClearPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPackages;
    }
}

