using BLL.EntitiesManagers;

namespace Northwind_Form
{
    public partial class Form1 : Form
    {
        private BindingSource productsBindingDataSource;
        public Form1()
        {
            InitializeComponent();
            productsBindingDataSource = new BindingSource();
        }

        private void loadOption_Click(object sender, EventArgs e)
        {
            var products = ProductManager.SelectAllProducts();
            productsBindingDataSource.DataSource = products;
            this.productsGV.DataSource = productsBindingDataSource;
            this.productsGV.EndEdit();
            this.productsGV.Columns["SupplierID"].ReadOnly = true;

            var suppliers = SupplierManager.GetAllSuppliers();


            var supplierColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Supplier Name",
                DataSource = suppliers,
                DisplayMember = "CompanyName", // shown attribute from suppliers list
                ValueMember = "SID",      // background work will be based on this ID
                DataPropertyName = "SupplierID"
            };

            this.productsGV.Columns.AddRange(supplierColumn);
        }

        private void deleteFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManager.DeleteProductByID(1);
        }
    }
}