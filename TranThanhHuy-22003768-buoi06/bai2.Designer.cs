namespace TranThanhHuy_22003768_buoi06
{
    partial class bai2
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
            listView1 = new ListView();
            columnHeaderCountry = new ColumnHeader();
            columnHeaderContactName = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            btnFormat = new Button();
            lbContact = new Label();
            lbCountry = new Label();
            lbPhone = new Label();
            textBoxContactName = new TextBox();
            textBoxCountry = new TextBox();
            textBoxPhone = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderCountry, columnHeaderContactName, columnHeaderPhone });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(484, 379);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderCountry
            // 
            columnHeaderCountry.Text = "Country";
            columnHeaderCountry.Width = 100;
            // 
            // columnHeaderContactName
            // 
            columnHeaderContactName.Text = "Contact Name";
            columnHeaderContactName.Width = 200;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Phone";
            columnHeaderPhone.Width = 100;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(32, 12);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(136, 29);
            btnFormat.TabIndex = 1;
            btnFormat.Text = "Format ListView";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // lbContact
            // 
            lbContact.AutoSize = true;
            lbContact.Location = new Point(554, 59);
            lbContact.Name = "lbContact";
            lbContact.Size = new Size(104, 20);
            lbContact.TabIndex = 2;
            lbContact.Text = "Contact Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(554, 160);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 3;
            lbCountry.Text = "Country";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(554, 262);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone";
            // 
            // textBoxContactName
            // 
            textBoxContactName.Location = new Point(554, 95);
            textBoxContactName.Name = "textBoxContactName";
            textBoxContactName.Size = new Size(194, 27);
            textBoxContactName.TabIndex = 5;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(554, 198);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(194, 27);
            textBoxCountry.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(554, 308);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(194, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(654, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxContactName);
            Controls.Add(lbPhone);
            Controls.Add(lbCountry);
            Controls.Add(lbContact);
            Controls.Add(btnFormat);
            Controls.Add(listView1);
            Name = "bai2";
            Text = "bai2";
            Load += bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeaderContactName;
        private ColumnHeader columnHeaderCountry;
        private ColumnHeader columnHeaderPhone;
        private Button btnFormat;
        private Label lbContact;
        private Label lbCountry;
        private Label lbPhone;
        private TextBox textBoxContactName;
        private TextBox textBoxCountry;
        private TextBox textBoxPhone;
        private Button btnAdd;
    }
}