using PSI_System.Managers;
using PSI_System.Models;
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
    public partial class frmPODetails : Form
    {
        public frmPODetails()
        {
            InitializeComponent();
            this.dtpArrivalDate.Format = DateTimePickerFormat.Custom;
            this.dtpArrivalDate.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dgvPODetail.AutoGenerateColumns = false;
        }

        public string UserName = string.Empty;
        public string Pid = string.Empty;
        public string ArrivalDate = string.Empty;
        private PO_Manager _manager = new PO_Manager();
        private PO_Model _model = null;
        private void PODetailsForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pid))
            {
                _model = new PO_Model();
                this.txtPID.Text = "儲存時建立";
                this.dtpArrivalDate.Value = DateTime.Now;
                this.txtItems.Text = string.Empty;
                this.txtQty.Text = string.Empty;
                this.txtTotal.Text = string.Empty;
                var list = _manager.GetProducts();
                this.dgvPODetail.DataSource = list;
            }
            else
            {
                _model = _manager.ReadPO(Pid);
                this.txtPID.Text = Pid;
                this.dtpArrivalDate.Value = _model.ArrivalTime;
                this.txtItems.Text = _model.Items.ToString();
                this.txtQty.Text = _model.QTY.ToString();
                this.txtTotal.Text = _model.Total.ToString();
                var list = _manager.GetViewPODetails(Pid);
                this.dgvPODetail.DataSource = list;

            }

        }

        private void dgvPODetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPODetail.Rows[e.RowIndex];
            //0=>數量 1=>小計 2=>編號 3=>名稱 4=>單價

            var aa = row.Cells[0].Value;
            var bb = row.Cells[1].Value;
            var cc = row.Cells[2].Value;
            var dd = row.Cells[3].Value;
            var ee = row.Cells[4].Value;

            if (row.Cells[3].Value == null)
            {
                row.Cells[4].Value = null;          
                return;
            }

            int qty;
            bool isNumber = int.TryParse(row.Cells[3].Value.ToString(), out qty);

            if (!isNumber || qty < 0 || qty > 300)
            {
                MessageBox.Show("請輸入數字，範圍請在0~300之間");
                row.Cells[0].Value = null;
                row.Cells[1].Value = null;
                return;
            }
            
            row.Cells[4].Value = qty * Convert.ToDecimal(row.Cells[2].Value);

            
            
            //decimal unitPrice = Convert.ToDecimal(row.Cells[this.dgvPODetail.Columns["ProductUnitPrice"].Index].Value);

            //decimal qty = Convert.ToDecimal(row.Cells[this.dgvPODetail.Columns["ProductQTY"].Index].Value);

            //row.Cells[this.dgvPODetail.Columns["ProductAmount"].Index].Value = unitPrice * qty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int countRows = this.dgvPODetail.Rows.Count;
            if (countRows == 0)
            {
                MessageBox.Show("必須挑選至少一項商品");
                return;
            }

            //BindingSource bs = (BindingSource)this.dgvPODetail.DataSource;

            string pid = _manager.GetNewPID();
            DataTable dt = new DataTable();
            dt.Columns.Add("PID");
            dt.Columns.Add("ID");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Amount");

            int countNull = 0;
            for (int i = 0; i < countRows; i++)
            {
                DataRow dr = dt.NewRow();
                
                var id = this.dgvPODetail.Rows[i].Cells[0].Value;
                var qty = this.dgvPODetail.Rows[i].Cells[3].Value;
                var amount = this.dgvPODetail.Rows[i].Cells[4].Value;
                if (qty != null || Convert.ToDecimal(qty) != 0)
                {
                    dr["PID"] = (this.txtPID.Text == "儲存時建立")? pid : _model.PID;
                    dr["ID"] = id;
                    dr["QTY"] = qty;
                    dr["Amount"] = amount;
                    dt.Rows.Add(dr);
                }
                else
                {
                    countNull++;
                    if(countNull == 4)
                    {
                        MessageBox.Show("必須至少挑選一樣商品");
                        return;
                    }
                    
                }
                
            }

            if(this.txtPID.Text == "儲存時建立")
            {
                _model.PID = pid;
                _model.Items = int.Parse(this.txtItems.Text);
                _model.QTY = int.Parse(this.txtQty.Text);
                _model.ArrivalTime = this.dtpArrivalDate.Value;
                _model.Total = decimal.Parse(this.txtTotal.Text);
                _model.CreateDate = DateTime.Now;
                _model.Creator = UserName;

                _manager.CreatePO(_model, dt);

                MessageBox.Show("新增成功");
                this.txtPID.Text = pid;
            }
            else
            {
                _model.Items = int.Parse(this.txtItems.Text);
                _model.QTY = int.Parse(this.txtQty.Text);
                _model.ArrivalTime = this.dtpArrivalDate.Value;
                _model.Total = decimal.Parse(this.txtTotal.Text);
                _model.ModifyDate = DateTime.Now;
                _model.Modifier = UserName;

                _manager.UpdatePO(_model, dt);

                MessageBox.Show("修改成功");
            }
            
        }


        private void dgvPODetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int items = 0;
            int qty = 0;
            decimal total = 0;
            for (int i = 0; i < this.dgvPODetail.Rows.Count; i++)
            {
                if (this.dgvPODetail.Rows[i].Cells[3].Value != null)
                {
                    items++;
                    qty += Convert.ToInt32(this.dgvPODetail.Rows[i].Cells[3].Value);
                }
                if (this.dgvPODetail.Rows[i].Cells[4].Value != null)
                    total += Convert.ToDecimal(this.dgvPODetail.Rows[i].Cells[4].Value);
            }

            this.txtItems.Text = items.ToString();
            this.txtQty.Text = qty.ToString();
            this.txtTotal.Text = total.ToString("#,0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("你確定要取消嗎?(輸入資料將不被保留)", "是否取消", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
            
        }
    }
}
