using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranThanhHuy_22003768_buoi06.BUS;
using TranThanhHuy_22003768_buoi06.DTO;

namespace TranThanhHuy_22003768_buoi06
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
            suppliersBUS = new SuppliersBUS();

        }
        private SuppliersBUS suppliersBUS;
        private void bai2_Load(object sender, EventArgs e)
        {
            loadDataWithReaderSuppliers();
        }
        public void loadDataWithReaderSuppliers()
        {
            List<SuppliersDTO> suppliersList = suppliersBUS.getAll();

            foreach (SuppliersDTO suppliers in suppliersList)
            {
                ListViewItem item = new ListViewItem(suppliers.ContactName);
                item.SubItems.Add(suppliers.Country);
                item.SubItems.Add(suppliers.Phone);

                listView1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contactName = textBoxContactName.Text;
            string country = textBoxCountry.Text;
            string phone = textBoxPhone.Text;

            ListViewItem item = new ListViewItem(contactName);
            item.SubItems.Add(country);
            item.SubItems.Add(phone);
            listView1.Items.Add(item);
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            View view = listView1.View;


            switch (view)
            {
                case View.List:
                    listView1.View = View.Details;
                    break;
                case View.Details:
                    listView1.View = View.List;
                    break;
                case View.SmallIcon:
                    listView1.View = View.LargeIcon;
                    break;
                case View.LargeIcon:
                    listView1.View = View.SmallIcon;
                    break;
            }
        }
    }
}
