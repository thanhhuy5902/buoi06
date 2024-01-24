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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            suppliersBUS = new SuppliersBUS();
        }
        private SuppliersBUS suppliersBUS;
        public void loadDataWithReaderSuppliers()
        {
            List<SuppliersDTO> suppliersList = suppliersBUS.getAll();

            foreach (SuppliersDTO suppliers in suppliersList)
            {
                ListViewItem item = new ListViewItem(suppliers.ContactTitle);
                item.SubItems.Add(suppliers.ContactName);
                item.SubItems.Add(suppliers.Address);

                item.SubItems.Add(suppliers.Country);
                item.SubItems.Add(suppliers.Phone);
                listView1.Items.Add(item);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            loadDataWithReaderSuppliers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string contactName = tbName.Text;
            string country = tbAddress.Text;
            string phone = tbMaSoSV.Text;

            ListViewItem item = new ListViewItem(contactName);
            item.SubItems.Add(country);
            item.SubItems.Add(phone);
            listView1.Items.Add(item);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
    {
                // Lấy phần tử đã chọn
                ListViewItem selectedListItem = listView1.SelectedItems[0];

                // Lấy giá trị của các ô input
                string contactName = tbName.Text;
                string country = tbAddress.Text;
                string phone = tbMaSoSV.Text;

                // Cập nhật thông tin của phần tử đã chọn
                selectedListItem.SubItems[1].Text = contactName; // Giả sử cột 1 là cột chứa ContactName
                selectedListItem.SubItems[2].Text = country;     // Giả sử cột 2 là cột chứa Country
                selectedListItem.SubItems[3].Text = phone;       // Giả sử cột 3 là cột chứa Phone

                // Thêm mã logic cập nhật SupplierID tương tự như trước (nếu có cần thiết)

                // Cập nhật dữ liệu trong danh sách hoặc nguồn dữ liệu khác nếu có
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy phần tử đã chọn
                ListViewItem selectedListItem = listView1.SelectedItems[0];

                // Hiển thị hộp thoại xác nhận xóa (nếu cần)
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phần tử này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes", thực hiện xóa
                if (result == DialogResult.Yes)
                {
                    // Xóa phần tử từ ListView
                    listView1.Items.Remove(selectedListItem);

                    // Thêm mã logic xóa khỏi nguồn dữ liệu hoặc danh sách nếu có

                    // Nếu cần thêm bất kỳ logic xóa nào khác, bạn có thể thực hiện ở đây
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
