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
    public partial class Display : Form
    {
        DataHandler handler = new DataHandler();
        public Display()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSearch.Text != null)
                {
                    if (handler.Search(txtSearch.Text) == null)
                    {
                        MessageBox.Show("The table is empty");
                    }
                    else
                    {
                        dataGridView1.DataSource = handler.Search(txtSearch.Text);
                    }
                }
                else
                {
                    MessageBox.Show("The text box is empty");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Update student = new Update();
            student.Show();
            this.Hide();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            Modules module = new Modules();
            module.Show();
            this.Hide();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSearch.Text != null)
                {
                    if (btnSearch.Text != null)
                    {
                        handler.Delete(txtSearch.Text);
                        if (handler.getAllInfo() == null)
                        {
                            MessageBox.Show("The table is empty");
                        }
                        else
                        {
                            dataGridView1.DataSource = handler.getAllInfo();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The text box is empty");
                }

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                throw;
            }
        }

        private void Display_Load(object sender, EventArgs e)
        {
            if (handler.getAllInfo() == null)
            {
                MessageBox.Show("The table is empty");
            }
            else
            {
                dataGridView1.DataSource = handler.getAllInfo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
