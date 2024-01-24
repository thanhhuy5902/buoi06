using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranThanhHuy_22003768_buoi06.DAO;
using TranThanhHuy_22003768_buoi06.DTO;

namespace TranThanhHuy_22003768_buoi06.BUS
{
    internal class SuppliersBUS
    {
        private SuppliersDAO suppliersDAO;

        public SuppliersBUS()
        {
            suppliersDAO = new SuppliersDAO();
        }

        public List<DTO.SuppliersDTO> getAll()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = suppliersDAO.getAll();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<SuppliersDTO> list = new List<SuppliersDTO>();
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SuppliersDTO suppliersDTO = new SuppliersDTO();
                    suppliersDTO.ContactTitle = dr["ContactTitle"].ToString();
                    suppliersDTO.Address = dr["Address"].ToString();
                    suppliersDTO.ContactName = dr["ContactName"].ToString();
                    suppliersDTO.Country = dr["Country"].ToString();
                    suppliersDTO.Phone = dr["Phone"].ToString();
                    list.Add(suppliersDTO);
                }
            }
            return list;
            }
        }
    }

