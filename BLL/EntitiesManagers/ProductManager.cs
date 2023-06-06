using BLL.Entities;
using BLL.EntitiesLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntitiesManagers
{
    /// The Manager class : the only class that communicate with Data Access Layer  
    public class ProductManager
    {
        private static readonly DBManager manager = new();

        public static ProductList SelectAllProducts()
        {
            var products = new ProductList();
            try
            {
                DataTable productsDT = manager.ExecuteDataTable("SelectAllProducts");

                // Mapping the DataTable into ProductList
                products = MappingDataTableToProductList(productsDT);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            return products;
        }

        public  static bool DeleteProductByID(int ID)
        {
            try
            {
                 manager.ExecuteNonQuery("DeleteProductByID", new Dictionary<string, object>
                {
                    ["ID"] = ID
                });
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            return false;
        }

        #region Mapping Functions
        private static ProductList MappingDataTableToProductList(DataTable productsDT)
        {
            var list = new ProductList();
            try
            {
                foreach (DataRow row in productsDT.Rows)
                {
                    list.Add(MappingDataRowToSingleProduct(row));
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return list;
        }

        private static Product MappingDataRowToSingleProduct(DataRow row)
        {
            var product = new Product();
            try
            {
                product.ProductID = row.Field<int>("ProductID");

                product.ProductName = row["ProductName"]?.ToString() ?? "NA";

                if (int.TryParse(row["SupplierID"]?.ToString() ?? "0", out int tempInt))
                {
                    product.SupplierID = tempInt;
                }

                if (int.TryParse(row["CategoryID"]?.ToString() ?? "0", out tempInt))
                    product.CategoryID = tempInt;

                product.QuantityPerUnit = row["QuantityPerUnit"]?.ToString() ?? "NA";

                if (decimal.TryParse(row["UnitPrice"]?.ToString() ?? "0", out decimal d))
                    product.UnitPrice = d;

                if (short.TryParse(row["UnitsInStock"]?.ToString() ?? "0", out short TempShort))
                    product.UnitsInStock = TempShort;

                if (short.TryParse(row["UnitsOnOrder"]?.ToString() ?? "0", out TempShort))
                    product.UnitsOnOrder = TempShort;

                if (short.TryParse(row["ReorderLevel"]?.ToString() ?? "0", out TempShort))
                    product.ReorderLevel = TempShort;

                if (bool.TryParse(row["Discontinued"]?.ToString() ?? "False", out bool b))
                    product.Discontinued = b;

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return product;
        }
        #endregion
    }
}
