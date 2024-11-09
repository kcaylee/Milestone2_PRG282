namespace Project.PresentationLayer
{
    partial class Update
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
            dbdStudent = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtStNum = new TextBox();
            txtDOB = new TextBox();
            txtStSurname = new TextBox();
            txtPhone = new TextBox();
            txtStName = new TextBox();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dbdStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dbdStudent
            // 
            dbdStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbdStudent.Location = new Point(11, 12);
            dbdStudent.Name = "dbdStudent";
            dbdStudent.RowHeadersWidth = 51;
            dbdStudent.RowTemplate.Height = 29;
            dbdStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dbdStudent.Size = new Size(776, 225);
            dbdStudent.TabIndex = 0;
            dbdStudent.CellClick += dbdStudent_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 71, 218);
            btnCreate.Location = new Point(6, 29);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 71, 218);
            btnUpdate.Location = new Point(147, 29);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 192, 255);
            txtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(443, 291);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtStNum
            // 
            txtStNum.BackColor = Color.FromArgb(255, 192, 255);
            txtStNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStNum.ForeColor = SystemColors.WindowText;
            txtStNum.Location = new Point(167, 260);
            txtStNum.Name = "txtStNum";
            txtStNum.Size = new Size(125, 27);
            txtStNum.TabIndex = 4;
            // 
            // txtDOB
            // 
            txtDOB.BackColor = Color.FromArgb(255, 192, 255);
            txtDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDOB.ForeColor = SystemColors.WindowText;
            txtDOB.Location = new Point(167, 360);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(125, 27);
            txtDOB.TabIndex = 5;
            // 
            // txtStSurname
            // 
            txtStSurname.BackColor = Color.FromArgb(255, 192, 255);
            txtStSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStSurname.ForeColor = SystemColors.WindowText;
            txtStSurname.Location = new Point(167, 326);
            txtStSurname.Name = "txtStSurname";
            txtStSurname.Size = new Size(125, 27);
            txtStSurname.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(255, 192, 255);
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.Location = new Point(443, 257);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtStName
            // 
            txtStName.BackColor = Color.FromArgb(255, 192, 255);
            txtStName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStName.ForeColor = SystemColors.WindowText;
            txtStName.Location = new Point(167, 294);
            txtStName.Name = "txtStName";
            txtStName.Size = new Size(125, 27);
            txtStName.TabIndex = 8;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 192, 255);
            cmbGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGender.ForeColor = SystemColors.WindowText;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(167, 392);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(125, 28);
            cmbGender.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 260);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 10;
            label1.Text = "Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(325, 293);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 11;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(325, 260);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(23, 389);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 13;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(23, 360);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(23, 325);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Surname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(23, 293);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 16;
            label7.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 71, 218);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(697, 390);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 19;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(325, 342);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 78);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create and Update";
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 6, 94);
            ClientSize = new Size(800, 448);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(txtStName);
            Controls.Add(txtPhone);
            Controls.Add(txtStSurname);
            Controls.Add(txtDOB);
            Controls.Add(txtStNum);
            Controls.Add(txtAddress);
            Controls.Add(dbdStudent);
            Name = "Update";
            Text = "Update";
            Load += Update_Load;
            ((System.ComponentModel.ISupportInitialize)dbdStudent).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbdStudent;
        private Button btnCreate;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtStNum;
        private TextBox txtDOB;
        private TextBox txtStSurname;
        private TextBox txtPhone;
        private TextBox txtStName;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private GroupBox groupBox1;
    }
}