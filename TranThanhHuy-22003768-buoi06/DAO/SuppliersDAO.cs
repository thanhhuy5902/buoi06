using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhHuy_22003768_buoi06.DAO
{
    internal class SuppliersDAO
    {
        private DataProvider dataProvider;

        public SuppliersDAO()
        {
            dataProvider = new DataProvider();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Suppliers";
            try
            {
                dt = dataProvider.ExecuteSelectAllQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
    }
}
