using BLL.Entities;
using BLL.EntityList;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public class ProductManager
    {
        static DBManager dBManager = new DBManager();
        public static ProductList SelectAllProducts()
        {
            try
            {
                return DataTableToProductList(dBManager.ExecuteDataTable("ShowAll"));
            }
            catch
            {

            }
            return new ProductList();
        }
        public static ProductList OrderByPrice()
        {
            try
            {
                return DataTableToProductList(dBManager.ExecuteDataTable("OrderProductsByPrice"));
            }
            catch
            {

            }
            return new ProductList();
        }
        public static ProductList OrderByQuantity()
        {
            try
            {
                return DataTableToProductList(dBManager.ExecuteDataTable("OrderProductsByQuantity"));
            }
            catch
            {

            }
            return new ProductList();
        }
        static internal ProductList DataTableToProductList(DataTable Dt)
        {
            ProductList PrdLst = new ProductList();
            try
            {
                if (Dt?.Rows?.Count > 0)
                {
                    foreach (DataRow Dr in Dt.Rows) {
                        PrdLst.Add(DataRowToProduct(Dr));
                    }
                }
            }
            catch
            { 

            }
            return PrdLst;
        }
        static internal Product DataRowToProduct(DataRow Dr)
        {
            Product Prd = new Product();

            Prd.Name = Dr.Field<string>("Name");
            Prd.SerialNumber = Dr["SerialNumber"]?.ToString()??"NA";
           // Prd.Price = Dr.Field<decimal>("Price");
            Prd.Quantity = Dr.Field<int>("Quantity");
            Prd.Profit = decimal.Parse(Dr["Profit"].ToString());
            Prd.InStock = Dr.Field<bool>("InStock");
            Prd.Price = decimal.Parse(Dr["Price"].ToString());

            return Prd;
        }
    }
}
