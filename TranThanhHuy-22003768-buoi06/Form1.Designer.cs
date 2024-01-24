namespace TranThanhHuy_22003768_buoi06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            mtbDateOfBirth = new MaskedTextBox();
            rtbCity = new RichTextBox();
            cbCountry = new ComboBox();
            rtbQualification = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            mtbPhone = new MaskedTextBox();
            btnSubmit = new Button();
            btnExit = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 53);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 73);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "(dd/mm/yyyy)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 111);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 171);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 255);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 349);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 6;
            label7.Text = "Qualification";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 445);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 517);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 8;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 582);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 9;
            label10.Text = "Date of joinning";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 602);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 10;
            label11.Text = "(dd/mm/yyyy)";
            // 
            // tbName
            // 
            tbName.Location = new Point(213, 6);
            tbName.Name = "tbName";
            tbName.Size = new Size(270, 27);
            tbName.TabIndex = 11;
            tbName.Leave += textBox2_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(213, 510);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(270, 27);
            tbEmail.TabIndex = 12;
            tbEmail.TextChanged += textBox2_TextChanged;
            tbEmail.Leave += textBox2_TextChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(213, 111);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(270, 27);
            tbAddress.TabIndex = 13;
            tbAddress.Leave += textBox2_TextChanged;
            // 
            // mtbDateOfBirth
            // 
            mtbDateOfBirth.Location = new Point(213, 53);
            mtbDateOfBirth.Mask = "00/00/0000";
            mtbDateOfBirth.Name = "mtbDateOfBirth";
            mtbDateOfBirth.Size = new Size(270, 27);
            mtbDateOfBirth.TabIndex = 17;
            mtbDateOfBirth.ValidatingType = typeof(DateTime);
            mtbDateOfBirth.Leave += mtbDateOfBirth_Leave;
            // 
            // rtbCity
            // 
            rtbCity.Location = new Point(213, 165);
            rtbCity.Name = "rtbCity";
            rtbCity.Size = new Size(270, 64);
            rtbCity.TabIndex = 18;
            rtbCity.Text = "";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Items.AddRange(new object[] { "Việt Nam", "Thái Lan" });
            cbCountry.Location = new Point(213, 253);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(151, 28);
            cbCountry.TabIndex = 19;
            cbCountry.SelectedIndexChanged += cbCountry_SelectedIndexChanged;
            // 
            // rtbQualification
            // 
            rtbQualification.Location = new Point(213, 326);
            rtbQualification.Name = "rtbQualification";
            rtbQualification.Size = new Size(264, 80);
            rtbQualification.TabIndex = 20;
            rtbQualification.Text = "University\nMaster\nPh D";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 582);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(213, 445);
            mtbPhone.Mask = "000-0000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(125, 27);
            mtbPhone.TabIndex = 23;
            mtbPhone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            mtbPhone.Leave += textBox2_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(213, 695);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(389, 695);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(65, 695);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 20);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Link to Express";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 741);
            Controls.Add(linkLabel1);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(mtbPhone);
            Controls.Add(dateTimePicker1);
            Controls.Add(rtbQualification);
            Controls.Add(cbCountry);
            Controls.Add(rtbCity);
            Controls.Add(mtbDateOfBirth);
            Controls.Add(tbAddress);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private MaskedTextBox mtbDateOfBirth;
        private RichTextBox rtbCity;
        private ComboBox cbCountry;
        private RichTextBox rtbQualification;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox mtbPhone;
        private Button btnSubmit;
        private Button btnExit;
        private LinkLabel linkLabel1;
    }
}
