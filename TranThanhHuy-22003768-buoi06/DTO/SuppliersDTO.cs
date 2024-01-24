using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhHuy_22003768_buoi06.DTO
{
    internal class SuppliersDTO
    {
        public SuppliersDTO() { }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string SupplierID { get; set; }

        public string Address {  get; set; }

        public string ContactTitle { get; set; }
    }
}
