using BLL.EntitiesManagers;

namespace Northwind_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadOption_Click(object sender, EventArgs e)
        {
            var products = ProductManager.SelectAllProducts();
            this.productsGV.DataSource = products;
        }
    }
}