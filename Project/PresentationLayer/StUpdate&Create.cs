using Project.BusinessLayer;
using Project.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.PresentationLayer
{
    public partial class Update : Form
    {
        DataHandler handler = new DataHandler();
        public Update()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtAddress.Text == null) || (txtDOB.Text == null) ||
                    (txtPhone.Text == null) || (txtStName.Text == null) || (txtStNum.Text == null) ||
                    (txtStSurname.Text == null) || (cmbGender.SelectedIndex == -1))
                {
                    MessageBox.Show("Please enter values into all the required fields");
                }
                else
                {
                    Student student = new Student(txtStName.Text, txtStSurname.Text, txtDOB.Text, txtPhone.Text, txtAddress.Text, txtStNum.Text, (cmbGender.SelectedIndex) + 1);
                    handler.StUpdate(student);
                    dbdStudent.DataSource = handler.getStudent();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtAddress.Text == null) || (txtDOB.Text == null) ||
                    (txtPhone.Text == null) || (txtStName.Text == null) || (txtStNum.Text == null) ||
                    (txtStSurname.Text == null) || (cmbGender.SelectedIndex == -1))
                {
                    MessageBox.Show("Please enter values into all the required fields");
                }
                else
                {
                    Student student = new Student(txtStName.Text, txtStSurname.Text, txtDOB.Text, txtPhone.Text, txtAddress.Text, txtStNum.Text, (cmbGender.SelectedIndex) + 1);
                    handler.StInsert(student);
                    dbdStudent.DataSource = handler.getStudent();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            if (handler.getStudent() == null)
            {
                MessageBox.Show("Table is empty");
            }
            else
            {
                dbdStudent.DataSource = handler.getStudent();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Hide();
        }

        private void dbdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStNum.Text = dbdStudent.SelectedRows[0].Cells[0].Value.ToString();
                txtStName.Text = dbdStudent.SelectedRows[0].Cells[1].Value.ToString();
                txtStSurname.Text = dbdStudent.SelectedRows[0].Cells[2].Value.ToString();
                txtDOB.Text = dbdStudent.SelectedRows[0].Cells[3].Value.ToString();
                cmbGender.SelectedIndex = int.Parse(dbdStudent.SelectedRows[0].Cells[4].Value.ToString()) - 1;
                txtPhone.Text = dbdStudent.SelectedRows[0].Cells[0].Value.ToString();
                txtAddress.Text = dbdStudent.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
