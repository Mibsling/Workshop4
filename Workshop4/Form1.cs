using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*The agents need to add/edit travel packages.  This function must allow the user to enter data for the package,
             * and select from a product list to add products to the package.The application will also require simple add/edit
             * access for maintaining the product, suppliers, and product_suppliers data.
             
            select s.SupName, p.ProdName from Products p
join Products_Suppliers ps on ps.ProductId = p.ProductId
join Suppliers s on ps.SupplierId = s.SupplierId
join Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId
join Packages on Packages.PackageId = pps.PackageId
where Packages.PackageId = 1;
             
            
             */

            var packages = DataLayer.PackageDB.GetPackages();
            var products = DataLayer.ProductsDB.GetProducts();
            var suppliers = DataLayer.SuppliersDB.GetSuppliers();
            BoxProdID.DataSource = products;
            BoxProdID.DisplayMember = "ProductId";
            txtProdName.DataBindings.Add("Text", products, "ProdName");
            BoxSupId.DataSource = suppliers;
            BoxSupId.DisplayMember = "SupplierId";

            // Get max SupplierID (needed because SupplierId is not identity column)
            int maxSupId = 0;
            foreach (var s in suppliers)
            {
                if (s.SupplierId > maxSupId)
                {
                    maxSupId = s.SupplierId;
                }
            }
            
            txtSupName.DataBindings.Add("Text", suppliers, "SupName");
            cBoxPackages.DataSource = packages;
            cBoxPackages.DisplayMember = "PkgName";
            txtPkgId.DataBindings.Add("Text", packages, "PackageId");
            txtPkgName.DataBindings.Add("Text", packages, "PkgName");
            txtPkgDesc.DataBindings.Add("Text", packages, "PkgDesc");
            dtpPkgStartDate.DataBindings.Add("Value", packages, "PkgStartDate");
            dtpPkgEndDate.DataBindings.Add("Value", packages, "PkgEndDate");
            txtBasePrice.DataBindings.Add("Text", packages, "PkgBasePrice");
            txtAgencyCommission.DataBindings.Add("Text", packages, "PkgAgencyCommission");
            cbSuppliers.DataSource = DataLayer.SuppliersDB.GetSuppliers();
            cbSuppliers.DisplayMember = "SupName";
            cbProducts.DataSource = DataLayer.ProductsDB.GetProducts();
            cbProducts.DisplayMember = "ProdName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPkgName.Text = "";
            txtBasePrice.Text = "";
            txtPkgDesc.Text = "";
            txtAgencyCommission.Text = "";
            lboxAddedProducts.Items.Clear();
            dtpPkgStartDate.ResetText();
            dtpPkgEndDate.ResetText();
        }

        private void BtnClearPackage_Click(object sender, EventArgs e)
        {
            txtPkgName.Text = "";
            txtBasePrice.Text = "";
            txtPkgDesc.Text = "";
            txtAgencyCommission.Text = "";
            lboxAddedProducts.Items.Clear();
            dtpPkgStartDate.ResetText();
            dtpPkgEndDate.ResetText();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            lboxAddedProducts.Items.Add("test");
        }

        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            var selectedItems = lboxAddedProducts.SelectedItems;

            if (lboxAddedProducts.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lboxAddedProducts.Items.Remove(selectedItems[i]);
            }
        }

        private void BtnSavePackage_Click(object sender, EventArgs e)
        {
            string erMsg = "";
            if (txtPkgName.Text.Trim() == "")
            {
                erMsg += "-Package Name can't be empty.\n";
            }
            if (txtPkgDesc.Text.Trim() == "")
            {
                erMsg += "-Package Description can't be empty.\n";
            }
            if (dtpPkgStartDate.Value > dtpPkgEndDate.Value) {
                erMsg += "-Package End Date must be later than Start Date.\n";
            }
            try
            {
                if (Convert.ToDecimal(txtBasePrice.Text) < Convert.ToDecimal(txtAgencyCommission.Text))
                {
                    erMsg += "-Agency Commision can't be greater than Package Base Price\n";
                }
            }
            catch (System.FormatException ex)
            {
                erMsg += "-Agency Commission and Package Base Price must be numerical.\n";
            }
            
            if (erMsg != "")
            {
                MessageBox.Show("Please correct the following: \n\n" + erMsg);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BoxProdID.Enabled = false;
            txtProdName.Text = "";
            btnNewProdCancel.Visible = true;
            btnDeleteProduct.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BoxProdID.Enabled == false)
            {
                try
                {
                    DataLayer.ProductsDB.AddProduct(txtProdName.Text);
                    MessageBox.Show("Product '"+txtProdName.Text+"' successfully added.");
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    DataLayer.ProductsDB.EditProduct(txtProdName.Text, BoxProdID.Text);
                    MessageBox.Show("Product '"+txtProdName.Text+"' successfully edited.");
                }
                catch
                {

                }
            }
            
            var products = DataLayer.ProductsDB.GetProducts();
            BoxProdID.DataSource = products;
            BoxProdID.DisplayMember = "ProductId";
            BoxProdID.Enabled = true;
            txtProdName.DataBindings.RemoveAt(0);
            txtProdName.DataBindings.Add("Text", products, "ProdName");
            btnNewProdCancel.Visible = false;
            btnDeleteProduct.Visible = true;
        }
        private void BtnNewProdCancel_Click(object sender, EventArgs e)
        {
            var products = DataLayer.ProductsDB.GetProducts();
            BoxProdID.DataSource = products;
            BoxProdID.DisplayMember = "ProductId";
            BoxProdID.Enabled = true;
            txtProdName.DataBindings.RemoveAt(0);
            txtProdName.DataBindings.Add("Text", products, "ProdName");
            btnNewProdCancel.Visible = false;
            btnDeleteProduct.Visible = true;
        }
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            var deletedProd = txtProdName.Text;
            try
            {
                DataLayer.ProductsDB.DeleteProduct(Convert.ToInt32(BoxProdID.Text));
                MessageBox.Show("Product '" + deletedProd + "' deleted.");
            }
            catch
            {
                MessageBox.Show("Can't delete '" + txtProdName.Text + "'. Existing packages might still include this product.");
            }
            
            var products = DataLayer.ProductsDB.GetProducts();
            BoxProdID.DataSource = products;
            BoxProdID.DisplayMember = "ProductId";
            txtProdName.DataBindings.RemoveAt(0);
            txtProdName.DataBindings.Add("Text", products, "ProdName");
            btnNewProdCancel.Visible = false;
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            BoxSupId.Enabled = false;
            txtSupName.Text = "";
            btnNewSupCancel.Visible = true;
            btnDelSupplier.Visible = false;
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            if (BoxSupId.Enabled == false)
            {
                try
                {
                    DataLayer.SuppliersDB.AddSupplier(++DataLayer.SuppliersDB.maxSupplierId, txtSupName.Text);
                    MessageBox.Show("Supplier '" + txtSupName.Text+" ' successfully added.");
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    DataLayer.SuppliersDB.EditSupplier(BoxSupId.Text, txtSupName.Text);
                    MessageBox.Show("Supplier '" + txtSupName.Text+"' successfully edited.");
                }
                catch
                {

                }
            }

            var suppliers = DataLayer.SuppliersDB.GetSuppliers();
            BoxSupId.DataSource = suppliers;
            BoxSupId.DisplayMember = "SupplierId";
            BoxSupId.Enabled = true;
            txtSupName.DataBindings.RemoveAt(0);
            txtSupName.DataBindings.Add("Text", suppliers, "SupName");
            btnNewSup.Visible = true;
            btnNewSupCancel.Visible = false;
        }
        private void BtnNewSupCancel_Click(object sender, EventArgs e)
        {
            var suppliers = DataLayer.SuppliersDB.GetSuppliers();
            BoxSupId.DataSource = suppliers;
            BoxSupId.DisplayMember = "SupplierId";
            BoxSupId.Enabled = true;
            txtSupName.DataBindings.RemoveAt(0);
            txtSupName.DataBindings.Add("Text", suppliers, "SupName");
            btnNewSupCancel.Visible = false;
            btnNewSup.Visible = true;
            btnDelSupplier.Visible = true;
        }
        private void BtnDelSupplier_Click(object sender, EventArgs e)
        {
            var deletedSup = txtSupName.Text;
            try
            {
                DataLayer.SuppliersDB.DeleteSupplier(Convert.ToInt32(BoxSupId.Text));
                MessageBox.Show("Supplier '" + deletedSup + "' deleted.");
            }
            catch
            {
                MessageBox.Show("Can't delete '" + deletedSup + "'. Existing packages might still include this Supplier.");
            }

            var suppliers = DataLayer.SuppliersDB.GetSuppliers();
            BoxSupId.DataSource = suppliers;
            BoxSupId.DisplayMember = "SupplierId";
            txtSupName.DataBindings.RemoveAt(0);
            txtSupName.DataBindings.Add("Text", suppliers, "SupName");
            btnNewSupCancel.Visible = false;
        }

        private void CBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change lBoxAddedProducts based on txtPkgId.Text


        }

        private void BtnNewPackage_Click(object sender, EventArgs e)
        {
            cBoxPackages.SelectedIndex = -1;
            txtPkgId.Text = "";
            txtPkgName.Text = "";
        }

        
    }
}
