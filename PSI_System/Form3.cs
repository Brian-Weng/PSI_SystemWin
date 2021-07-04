using PSI_System.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string UserName = string.Empty;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lblUserName.Text = UserName;
            LoadGridView();
        }

        private void btnPOForm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Any())
            {
                Application.OpenForms.OfType<Form2>().First().BringToFront();
            }
            else
            {
                Form2 frm2 = new Form2();
                //frm2.UserName = this.UserName;
                frm2.Show();
            }
        }

        private void LoadGridView()
        {
            var manager = new PO_Manager();
            var list = manager.GetProducts();
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.DataSource = list;
        }
    }
}
