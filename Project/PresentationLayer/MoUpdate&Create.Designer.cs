namespace Project.PresentationLayer
{
    partial class Modules
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
            label15 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMoLink = new TextBox();
            txtMoCode = new TextBox();
            txtMoName = new TextBox();
            txtMoDesc = new TextBox();
            btnMoUpdate = new Button();
            btnMoCreate = new Button();
            dbdModules = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dbdModules).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(27, 382);
            label15.Name = "label15";
            label15.Size = new Size(38, 20);
            label15.TabIndex = 12;
            label15.Text = "Link";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(27, 348);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(27, 315);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 14;
            label7.Text = "Module";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(27, 283);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 15;
            label8.Text = "ModuleCode";
            // 
            // txtMoLink
            // 
            txtMoLink.BackColor = Color.FromArgb(255, 192, 255);
            txtMoLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMoLink.Location = new Point(181, 379);
            txtMoLink.Name = "txtMoLink";
            txtMoLink.Size = new Size(125, 27);
            txtMoLink.TabIndex = 19;
            // 
            // txtMoCode
            // 
            txtMoCode.BackColor = Color.FromArgb(255, 192, 255);
            txtMoCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMoCode.Location = new Point(181, 279);
            txtMoCode.Name = "txtMoCode";
            txtMoCode.Size = new Size(125, 27);
            txtMoCode.TabIndex = 16;
            // 
            // txtMoName
            // 
            txtMoName.BackColor = Color.FromArgb(255, 192, 255);
            txtMoName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMoName.Location = new Point(181, 312);
            txtMoName.Name = "txtMoName";
            txtMoName.Size = new Size(125, 27);
            txtMoName.TabIndex = 17;
            // 
            // txtMoDesc
            // 
            txtMoDesc.BackColor = Color.FromArgb(255, 192, 255);
            txtMoDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMoDesc.Location = new Point(181, 345);
            txtMoDesc.Name = "txtMoDesc";
            txtMoDesc.Size = new Size(125, 27);
            txtMoDesc.TabIndex = 18;
            // 
            // btnMoUpdate
            // 
            btnMoUpdate.BackColor = Color.FromArgb(255, 71, 218);
            btnMoUpdate.Location = new Point(150, 26);
            btnMoUpdate.Name = "btnMoUpdate";
            btnMoUpdate.Size = new Size(94, 29);
            btnMoUpdate.TabIndex = 20;
            btnMoUpdate.Text = "Update";
            btnMoUpdate.UseVisualStyleBackColor = false;
            btnMoUpdate.Click += btnMoUpdate_Click;
            // 
            // btnMoCreate
            // 
            btnMoCreate.BackColor = Color.FromArgb(255, 71, 218);
            btnMoCreate.Location = new Point(6, 26);
            btnMoCreate.Name = "btnMoCreate";
            btnMoCreate.Size = new Size(94, 29);
            btnMoCreate.TabIndex = 21;
            btnMoCreate.Text = "Create";
            btnMoCreate.UseVisualStyleBackColor = false;
            btnMoCreate.Click += btnMoCreate_Click;
            // 
            // dbdModules
            // 
            dbdModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbdModules.Location = new Point(11, 12);
            dbdModules.Name = "dbdModules";
            dbdModules.RowHeadersWidth = 51;
            dbdModules.RowTemplate.Height = 29;
            dbdModules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dbdModules.Size = new Size(776, 245);
            dbdModules.TabIndex = 22;
            dbdModules.CellClick += dbdModules_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 71, 218);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(693, 371);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 23;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMoUpdate);
            groupBox1.Controls.Add(btnMoCreate);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(371, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 70);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create and Update";
            // 
            // Modules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 6, 94);
            ClientSize = new Size(800, 422);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dbdModules);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtMoLink);
            Controls.Add(txtMoCode);
            Controls.Add(txtMoName);
            Controls.Add(txtMoDesc);
            Name = "Modules";
            Text = "Module";
            Load += MoUpdate_Create_Load;
            ((System.ComponentModel.ISupportInitialize)dbdModules).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMoLink;
        private TextBox txtMoCode;
        private TextBox txtMoName;
        private TextBox txtMoDesc;
        private Button btnMoUpdate;
        private Button btnMoCreate;
        private DataGridView dbdModules;
        private Button button1;
        private GroupBox groupBox1;
    }
}