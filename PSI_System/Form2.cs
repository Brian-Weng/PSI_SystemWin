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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 Main = null;
        frmPODetails poFrm = new frmPODetails();
        public string UserName = string.Empty;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lblUserName.Text = "Hi! " + this.UserName;

            LoadGridView();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            poFrm.UserName = this.Main.UserName;
            poFrm.Pid = string.Empty;
            poFrm.ShowDialog();

            LoadGridView();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string pid = this.dgvPO.CurrentRow.Cells["PID"].Value.ToString();
            string arrivalDate = this.dgvPO.CurrentRow.Cells["ArrivalTime"].Value.ToString();

            poFrm.UserName = this.Main.UserName;
            poFrm.Pid = pid;
            poFrm.ArrivalDate = arrivalDate;
            poFrm.ShowDialog();

            LoadGridView();

        }     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pid = this.dgvPO.CurrentRow.Cells["PID"].Value.ToString();

            var result = MessageBox.Show($"你確定要刪除進貨單 {pid} 嗎?", "是否刪除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string currentUser = this.Main.UserName;
                var manager = new PO_Manager();
                manager.DeletePO(pid, currentUser);

                LoadGridView();
            }
            else
            {
                return;
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CrystalReportForm report = new CrystalReportForm();
            report.Show();
        }

        private void LoadGridView()
        {
            var manager = new PO_Manager();
            var list = manager.ReadPOs();
            this.dgvPO.AutoGenerateColumns = false;
            this.dgvPO.ReadOnly = true;
            this.dgvPO.DataSource = list;
        }

        private void btnPdtFrom_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Any())
            {
                Application.OpenForms.OfType<Form3>().First().BringToFront();
            }
            else
            {
                Form3 frm3 = new Form3();
                frm3.UserName = this.Main.UserName;
                frm3.Show();
            }
            
        }
    }
}
