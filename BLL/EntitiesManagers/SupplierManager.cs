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
    public class SupplierManager
    {
        private readonly static DBManager manager = new();

        public static SupplierList GetAllSuppliers()
        {
            var suppliers = new SupplierList();
            try
            {
                DataTable suppliersTable = manager.ExecuteDataTable(
                    @"Select SupplierID as SID , CompanyName from Suppliers"
                    , CommandType.Text);

                suppliers = MappingTableToSuppliersList(suppliersTable);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }

            return suppliers;
        }

        #region Suppliers Mapping Function
        private static SupplierList MappingTableToSuppliersList(DataTable suppliersTable)
        {
            SupplierList suppliers = new SupplierList();
            try
            {
                foreach(DataRow row in suppliersTable.Rows)
                {
                    suppliers.Add(MappingSingleRowToSingleSupplier(row));
                }
            }catch(Exception ex)
            {
                Trace.WriteLine(ex);
            }
            return suppliers;
        }

        private static Supplier MappingSingleRowToSingleSupplier(DataRow row)
        {
            var supplier = new Supplier();
            try
            {
                if (int.TryParse(row["SID"]?.ToString() ?? "0", out int ID))
                    supplier.SID = ID;

                supplier.CompanyName = row["CompanyName"]?.ToString() ?? "NA";

            }catch(Exception e)
            {
                Trace.WriteLine(e);
            }
            return supplier;
        }
        #endregion
    }
}
