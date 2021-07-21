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
            //進貨單明細表單中的Pid設定為空字串，用來判定為新增模式
            poFrm.Pid = string.Empty;
            poFrm.ShowDialog();

            LoadGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //將當前所選的進貨單編號及到達時間傳到進貨單明細Form，用來判定為更新模式
            string pid = this.dgvPO.CurrentRow.Cells["PID"].Value.ToString();

            poFrm.Pid = pid;
            poFrm.ShowDialog();

            LoadGridView();

        }     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //宣告變數來接取當前選擇的進貨單編號
            string pid = this.dgvPO.CurrentRow.Cells["PID"].Value.ToString();

            if (string.IsNullOrEmpty(pid))
                return;

            //跳出對話視窗，點確認即刪除進貨單，點否則中止此事件
            var result = MessageBox.Show($"你確定要刪除進貨單 {pid} 嗎?", "是否刪除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string currentUser = Form1.UserName;
                var manager = new PO_Manager();
                manager.DeletePO(pid, currentUser);
                MessageBox.Show($"刪除進貨單 {pid} 成功");
                LoadGridView();
            }
            else
            {
                return;
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //印出水晶報表
            CrystalReportForm report = new CrystalReportForm();
            var manager = new PO_Manager();
            report.dataTable_PO = manager.GetPOTable();
            report.Show();
        }
        
        private void btnPdtFrom_Click(object sender, EventArgs e)
        {
            //假設商品管理Form已經存在，提到最前面，否則就開啟商品管理Form
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
            //假設只剩當前畫面，就關閉程式，否則就關閉此表單
            if (Application.OpenForms.Count == 2)
            {
                var result = MessageBox.Show($"已無其他表單，將關閉程式，您確定嗎?", "是否關閉", MessageBoxButtons.YesNo);
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
