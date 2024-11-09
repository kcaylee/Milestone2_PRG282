namespace Project.PresentationLayer
{
    partial class Display
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
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnStudent = new Button();
            btnModule = new Button();
            txtDelete = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 241);
            dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 192, 255);
            txtSearch.Location = new Point(6, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(218, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 71, 218);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(243, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(255, 71, 218);
            btnStudent.ForeColor = SystemColors.ButtonFace;
            btnStudent.Location = new Point(6, 26);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(94, 29);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnModule
            // 
            btnModule.BackColor = Color.FromArgb(255, 71, 218);
            btnModule.ForeColor = SystemColors.ButtonFace;
            btnModule.Location = new Point(134, 26);
            btnModule.Name = "btnModule";
            btnModule.Size = new Size(94, 29);
            btnModule.TabIndex = 4;
            btnModule.Text = "Module";
            btnModule.UseVisualStyleBackColor = false;
            btnModule.Click += btnModule_Click;
            // 
            // txtDelete
            // 
            txtDelete.BackColor = Color.FromArgb(255, 71, 218);
            txtDelete.ForeColor = SystemColors.ButtonFace;
            txtDelete.Location = new Point(243, 47);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(91, 27);
            txtDelete.TabIndex = 5;
            txtDelete.Text = "Delete";
            txtDelete.UseVisualStyleBackColor = false;
            txtDelete.Click += txtDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 71, 218);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(693, 337);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStudent);
            groupBox1.Controls.Add(btnModule);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(408, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 81);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update and Add";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtDelete);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(12, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 81);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter student number";
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 6, 94);
            ClientSize = new Size(800, 385);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Display";
            Text = "Display";
            Load += Display_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnStudent;
        private Button btnModule;
        private Button txtDelete;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}