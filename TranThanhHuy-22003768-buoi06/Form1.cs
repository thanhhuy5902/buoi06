namespace TranThanhHuy_22003768_buoi06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("điền tên đi");
            }
            else if (tbAddress.Text == "")
            {
                MessageBox.Show("điền địa chỉ đi");
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("điền email đi");
            }
            else if (mtbPhone.Text == "")
            {
                MessageBox.Show("điền phone đi");
            }
            else if (mtbDateOfBirth.Text == "")
            {
                MessageBox.Show("điền ngày tháng năm sinh đi");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("điền địa chỉ đi");
            }


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.ToString();
            string dateOfBirth = mtbDateOfBirth.Text.ToString();
            string city = rtbCity.Text.ToString();
            string country = cbCountry.Text.ToString();
            string qualifcation = rtbQualification.Text.ToString();
            string phone = mtbPhone.Text.ToString();
            string email = tbEmail.Text.ToString();
            string dateOfJonning = dateTimePicker1.Text.ToString();
            string strinngToPrint = "Name : " + name + " Date of Birth" + dateOfBirth + " City" + city + " Country: " + country + " Qualifcation: " + qualifcation + " Phone: " + phone + " Email: " + email + " Date of Joining: " + dateOfJonning;
            MessageBox.Show(strinngToPrint, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }

        private void mtbDateOfBirth_Leave(object sender, EventArgs e)
        {

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCountry.SelectedIndex == 0)
            {
                rtbCity.Text = "Hồ Chí Minh, Nha Trang, Hà Nội";
            }
            else
            {
                rtbCity.Text = "Bankok , Paytaye , ChiengMain";
            }
        }
    }
}
