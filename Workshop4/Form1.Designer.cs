namespace Workshop4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPkgId = new System.Windows.Forms.Label();
            this.txtPkgId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSavePackage = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.lboxAddedProducts = new System.Windows.Forms.ListBox();
            this.lblAddedProducts = new System.Windows.Forms.Label();
            this.lblAgencyCommission = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(58, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblPkgId);
            this.tabPage1.Controls.Add(this.txtPkgId);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSavePackage);
            this.tabPage1.Controls.Add(this.dtpPkgEndDate);
            this.tabPage1.Controls.Add(this.dtpPkgStartDate);
            this.tabPage1.Controls.Add(this.txtAgencyCommission);
            this.tabPage1.Controls.Add(this.txtBasePrice);
            this.tabPage1.Controls.Add(this.txtPkgDesc);
            this.tabPage1.Controls.Add(this.txtPkgName);
            this.tabPage1.Controls.Add(this.lblAgencyCommission);
            this.tabPage1.Controls.Add(this.lblBasePrice);
            this.tabPage1.Controls.Add(this.lblEndDate);
            this.tabPage1.Controls.Add(this.lblStartDate);
            this.tabPage1.Controls.Add(this.lblPkgDesc);
            this.tabPage1.Controls.Add(this.lblPkgName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packages";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblPkgId
            // 
            this.lblPkgId.AutoSize = true;
            this.lblPkgId.Location = new System.Drawing.Point(231, 23);
            this.lblPkgId.Name = "lblPkgId";
            this.lblPkgId.Size = new System.Drawing.Size(67, 13);
            this.lblPkgId.TabIndex = 22;
            this.lblPkgId.Text = "Package ID:";
            // 
            // txtPkgId
            // 
            this.txtPkgId.Enabled = false;
            this.txtPkgId.Location = new System.Drawing.Point(304, 19);
            this.txtPkgId.Name = "txtPkgId";
            this.txtPkgId.Size = new System.Drawing.Size(100, 20);
            this.txtPkgId.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSavePackage
            // 
            this.btnSavePackage.Location = new System.Drawing.Point(228, 428);
            this.btnSavePackage.Name = "btnSavePackage";
            this.btnSavePackage.Size = new System.Drawing.Size(75, 23);
            this.btnSavePackage.TabIndex = 19;
            this.btnSavePackage.Text = "Save";
            this.btnSavePackage.UseVisualStyleBackColor = true;
            this.btnSavePackage.Click += new System.EventHandler(this.btnSavePackage_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(163, 43);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 23);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add to list";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(451, 81);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgEndDate.TabIndex = 17;
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(223, 81);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPkgStartDate.TabIndex = 16;
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.Location = new System.Drawing.Point(371, 386);
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.Size = new System.Drawing.Size(100, 20);
            this.txtAgencyCommission.TabIndex = 15;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(169, 386);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 14;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(46, 135);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(605, 60);
            this.txtPkgDesc.TabIndex = 13;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(46, 81);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(148, 20);
            this.txtPkgName.TabIndex = 12;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(30, 85);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(121, 21);
            this.cbProducts.TabIndex = 11;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(30, 37);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cbSuppliers.TabIndex = 10;
            // 
            // lboxAddedProducts
            // 
            this.lboxAddedProducts.FormattingEnabled = true;
            this.lboxAddedProducts.Location = new System.Drawing.Point(313, 37);
            this.lboxAddedProducts.Name = "lboxAddedProducts";
            this.lboxAddedProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxAddedProducts.Size = new System.Drawing.Size(266, 69);
            this.lboxAddedProducts.TabIndex = 9;
            // 
            // lblAddedProducts
            // 
            this.lblAddedProducts.AutoSize = true;
            this.lblAddedProducts.Location = new System.Drawing.Point(313, 21);
            this.lblAddedProducts.Name = "lblAddedProducts";
            this.lblAddedProducts.Size = new System.Drawing.Size(93, 13);
            this.lblAddedProducts.TabIndex = 8;
            this.lblAddedProducts.Text = "Included Products";
            // 
            // lblAgencyCommission
            // 
            this.lblAgencyCommission.AutoSize = true;
            this.lblAgencyCommission.Location = new System.Drawing.Point(371, 370);
            this.lblAgencyCommission.Name = "lblAgencyCommission";
            this.lblAgencyCommission.Size = new System.Drawing.Size(101, 13);
            this.lblAgencyCommission.TabIndex = 7;
            this.lblAgencyCommission.Text = "Agency Commission";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(169, 370);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(104, 13);
            this.lblBasePrice.TabIndex = 6;
            this.lblBasePrice.Text = "Package Base Price";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(30, 69);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(44, 13);
            this.lblProducts.TabIndex = 5;
            this.lblProducts.Text = "Product";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(30, 21);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(45, 13);
            this.lblSuppliers.TabIndex = 4;
            this.lblSuppliers.Text = "Supplier";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(451, 65);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(223, 65);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(46, 119);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(106, 13);
            this.lblPkgDesc.TabIndex = 1;
            this.lblPkgDesc.Text = "Package Description";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(46, 65);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(81, 13);
            this.lblPkgName.TabIndex = 0;
            this.lblPkgName.Text = "Package Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(697, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products_Suppliers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(697, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Suppliers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(697, 524);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Packages_Products_Su";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveProduct);
            this.groupBox1.Controls.Add(this.lboxAddedProducts);
            this.groupBox1.Controls.Add(this.lblSuppliers);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.lblAddedProducts);
            this.groupBox1.Controls.Add(this.cbSuppliers);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.cbProducts);
            this.groupBox1.Location = new System.Drawing.Point(46, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 139);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Products";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(191, 78);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveProduct.TabIndex = 19;
            this.btnRemoveProduct.Text = "Remove from list";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSavePackage;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ListBox lboxAddedProducts;
        private System.Windows.Forms.Label lblAddedProducts;
        private System.Windows.Forms.Label lblAgencyCommission;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgId;
        private System.Windows.Forms.TextBox txtPkgId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}

