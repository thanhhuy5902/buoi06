namespace TranThanhHuy_22003768_buoi06
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbMaSoSV = new TextBox();
            tbName = new TextBox();
            tbAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            buttonUpdate = new Button();
            ButtonDelete = new Button();
            buttonExit = new Button();
            listView1 = new ListView();
            columnHeaderMã = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderAddress = new ColumnHeader();
            columnHeaderDateofBirth = new ColumnHeader();
            columnHeaderClass = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(508, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(138, 52);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Thêm Mới";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Số SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 69);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 125);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 178);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 233);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 5;
            label5.Text = "Lớp";
            // 
            // tbMaSoSV
            // 
            tbMaSoSV.Location = new Point(157, 22);
            tbMaSoSV.Name = "tbMaSoSV";
            tbMaSoSV.Size = new Size(168, 27);
            tbMaSoSV.TabIndex = 6;
            tbMaSoSV.TextChanged += textBox1_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(157, 69);
            tbName.Name = "tbName";
            tbName.Size = new Size(168, 27);
            tbName.TabIndex = 7;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(157, 122);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(168, 27);
            tbAddress.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(157, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 28);
            comboBox1.TabIndex = 10;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(508, 105);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(138, 61);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Cập Nhật Item";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(508, 206);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(138, 55);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.Text = "Xóa Item";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(508, 288);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(138, 50);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderMã, columnHeaderName, columnHeaderAddress, columnHeaderDateofBirth, columnHeaderClass });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 390);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 199);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderMã
            // 
            columnHeaderMã.Text = "Mã";
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Họ tên";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderAddress
            // 
            columnHeaderAddress.Text = "Địa Chỉ";
            columnHeaderAddress.Width = 200;
            // 
            // columnHeaderDateofBirth
            // 
            columnHeaderDateofBirth.Text = "Nơi Sinh";
            columnHeaderDateofBirth.Width = 100;
            // 
            // columnHeaderClass
            // 
            columnHeaderClass.Text = "Phone";
            columnHeaderClass.Width = 150;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 654);
            Controls.Add(listView1);
            Controls.Add(buttonExit);
            Controls.Add(ButtonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(tbMaSoSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbMaSoSV;
        private TextBox tbName;
        private TextBox tbAddress;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button buttonUpdate;
        private Button ButtonDelete;
        private Button buttonExit;
        private ListView listView1;
        private ColumnHeader columnHeaderMã;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderAddress;
        private ColumnHeader columnHeaderDateofBirth;
        private ColumnHeader columnHeaderClass;
    }
}