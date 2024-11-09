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
    public partial class Modules : Form
    {
        DataHandler handler = new DataHandler();
        public Modules()
        {
            InitializeComponent();
        }
        private void btnMoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMoCode.Text == null) || (txtMoDesc.Text == null) || (txtMoLink.Text == null) || (txtMoName.Text == null))
                {
                    MessageBox.Show("Make sure all the fields has a value");
                }
                else
                {
                    Module module = new Module(txtMoName.Text, txtMoLink.Text, txtMoDesc.Text, txtMoCode.Text);
                    handler.MoUpdate(module);
                    dbdModules.DataSource = handler.getModule();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }
        }
        private void btnMoCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtMoCode.Text == null) || (txtMoDesc.Text == null) || (txtMoLink.Text == null) || (txtMoName.Text == null))
                {
                    MessageBox.Show("Make sure all the fields has a value");
                }
                else
                {
                    Module module = new Module(txtMoName.Text, txtMoLink.Text, txtMoDesc.Text, txtMoCode.Text);
                    handler.MoInsert(module);
                    dbdModules.DataSource = handler.getModule();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }
        }
        private void MoUpdate_Create_Load(object sender, EventArgs e)
        {
            if (handler.getModule() == null)
            {
                MessageBox.Show("Table is empty");
            }
            else
            {
                dbdModules.DataSource = handler.getModule();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Hide();
        }

        private void dbdModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMoCode.Text = dbdModules.SelectedRows[0].Cells[0].Value.ToString();
                txtMoName.Text = dbdModules.SelectedRows[0].Cells[1].Value.ToString();
                txtMoDesc.Text = dbdModules.SelectedRows[0].Cells[2].Value.ToString();
                txtMoLink.Text = dbdModules.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
