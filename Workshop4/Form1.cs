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
            dataGridView1.DataSource = DataLayer.ProductsDB.GetProducts();

            var packages = DataLayer.PackageDB.GetPackages();
            cBoxPackages.DataSource = packages;
            cBoxPackages.DisplayMember = "PkgName";
            txtPkgId.DataBindings.Add("Text", packages, "PackageId");
            txtPkgName.DataBindings.Add("Text", packages, "PkgName");
            txtPkgDesc.DataBindings.Add("Text", packages, "PkgDesc");
            dtpPkgStartDate.DataBindings.Add("Value", packages, "PkgStartDate");
            dtpPkgEndDate.DataBindings.Add("Value", packages, "PkgEndDate");
            txtBasePrice.DataBindings.Add("Text", packages, "PkgBasePrice");
            txtAgencyCommission.DataBindings.Add("Text", packages, "PkgAgencyCommission");
            //cbSuppliers.DataSource = DataLayer.SuppliersDB.
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
            if (Convert.ToDecimal(txtBasePrice.Text) < Convert.ToDecimal(txtAgencyCommission.Text))
            {
                erMsg += "-Agency Commision can't be greater than Package Base Price\n";
            }
            if (erMsg != "")
            {
                MessageBox.Show("Please correct the following: \n\n" + erMsg);
            }
        }

    }
}
