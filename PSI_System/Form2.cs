using PSI_System.Managers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PSI_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //讀取進貨單明細
        private void LoadGridView()
        {
            var manager = new PO_Manager();
            var list = manager.ReadPOs();
            this.dgvPO.AutoGenerateColumns = false;
            this.dgvPO.ReadOnly = true;
            this.dgvPO.DataSource = list;
        }

        //建立進貨單明細Form表單的物件
        frmPODetails poFrm = new frmPODetails();

        private void Form2_Load(object sender, EventArgs e)
        {
            //使用者名稱為當前登錄者名稱
            this.lblUserName.Text = "Hi! " + Form1.UserName;

            LoadGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            poFrm.Pid = string.Empty;
            poFrm.ShowDialog();

            LoadGridView();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string pid = this.dgvPO.CurrentRow.Cells["PID"].Value.ToString();
            string arrivalDate = this.dgvPO.CurrentRow.Cells["ArrivalTime"].Value.ToString();

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
                string currentUser = Form1.UserName;
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
        
        private void btnPdtFrom_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Any())
            {
                Application.OpenForms.OfType<Form3>().First().BringToFront();
            }
            else
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                var result = MessageBox.Show($"已無其他表單，將關閉程式，您確定嗎?", "是否刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(Environment.ExitCode);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
