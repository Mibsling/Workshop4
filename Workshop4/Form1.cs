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
            //dgvPackages.DataSource = DataLayer.PackageDB.GetPackages();

            /*The agents need to add/edit travel packages.  This function must allow the user to enter data for the package,
             * and select from a product list to add products to the package.The application will also require simple add/edit
             * access for maintaining the product, suppliers, and product_suppliers data.
             
             * * The tables that will be used by this part of the project are:
             * 1.Packages
             * 2.Products
             * 3.Products_suppliers
             * 4.Suppliers
             * 5.Packages_products_suppliers
             * 
             * 
             * Make sure that you validate the data before creating the package:
             *  a)the Agency Commission cannot be greater than the Base Price
             *  b)the Package End Date must be later than Package Start Date
             *  c)Package Name and Package Description cannot be null
             
             
             select distinct Packages.PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission from packages 
                JOIN Packages_Products_Suppliers AS PPS
	                ON Packages.PackageId = PPS.PackageId
                JOIN Products_Suppliers AS PS
	                ON PPS.ProductSupplierId = PS.ProductSupplierId;

             SELECT Packages.PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission from packages 
                JOIN Packages_Products_Suppliers AS PPS
	                ON Packages.PackageId = PPS.PackageId
                JOIN Products_Suppliers AS PS
	                ON PPS.ProductSupplierId = PS.ProductSupplierId
				JOIN Products
					ON PS.ProductId = Products.ProductId
				WHERE Products.ProductId = 7

select * from Packages_Products_Suppliers;
select * from products;

SELECT * FROM Products_Suppliers WHERE ProductId = 6;


            
             */
            cBoxPackages.Items.Add("test");
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

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {

            lboxAddedProducts.Items.Add("test");
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var selectedItems = lboxAddedProducts.SelectedItems;

            if (lboxAddedProducts.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lboxAddedProducts.Items.Remove(selectedItems[i]);
            }
        }

        private void btnClearPackage_Click(object sender, EventArgs e)
        {
            txtPkgName.Text = "";
            txtBasePrice.Text = "";
            txtPkgDesc.Text = "";
            txtAgencyCommission.Text = "";
            lboxAddedProducts.Items.Clear();
            dtpPkgStartDate.ResetText();
            dtpPkgEndDate.ResetText();
        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpPkgStartDate.Value.Date.ToString());
        }
    }
}
