
namespace PSI_System
{
    partial class frmPODetails
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
            this.lblPid = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvPODetail = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPid.Location = new System.Drawing.Point(63, 36);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(130, 24);
            this.lblPid.TabIndex = 0;
            this.lblPid.Text = "單據編號：";
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPID.Location = new System.Drawing.Point(199, 35);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(241, 31);
            this.txtPID.TabIndex = 1;
            this.txtPID.Text = "儲存時建立";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblArrivalDate.Location = new System.Drawing.Point(63, 89);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(130, 24);
            this.lblArrivalDate.TabIndex = 2;
            this.lblArrivalDate.Text = "到達時間：";
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CalendarFont = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpArrivalDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(200, 87);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(240, 31);
            this.dtpArrivalDate.TabIndex = 1;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalQty.Location = new System.Drawing.Point(63, 196);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(130, 24);
            this.lblTotalQty.TabIndex = 4;
            this.lblTotalQty.Text = "進貨數量：";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQty.Location = new System.Drawing.Point(199, 189);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(241, 31);
            this.txtQty.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(63, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "進貨金額：";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(200, 241);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(240, 31);
            this.txtTotal.TabIndex = 7;
            // 
            // dgvPODetail
            // 
            this.dgvPODetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPODetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductUnitPrice,
            this.ProductQTY,
            this.ProductAmount});
            this.dgvPODetail.Location = new System.Drawing.Point(67, 307);
            this.dgvPODetail.Name = "dgvPODetail";
            this.dgvPODetail.RowHeadersWidth = 51;
            this.dgvPODetail.RowTemplate.Height = 27;
            this.dgvPODetail.Size = new System.Drawing.Size(896, 250);
            this.dgvPODetail.TabIndex = 8;
            this.dgvPODetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPODetail_CellEndEdit);
            this.dgvPODetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPODetail_CellValueChanged);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ID";
            this.ProductID.HeaderText = "商品編號";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "商品名稱";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // ProductUnitPrice
            // 
            this.ProductUnitPrice.DataPropertyName = "UnitPrice";
            this.ProductUnitPrice.HeaderText = "單價";
            this.ProductUnitPrice.MinimumWidth = 6;
            this.ProductUnitPrice.Name = "ProductUnitPrice";
            this.ProductUnitPrice.ReadOnly = true;
            this.ProductUnitPrice.Width = 125;
            // 
            // ProductQTY
            // 
            this.ProductQTY.DataPropertyName = "QTY";
            this.ProductQTY.HeaderText = "數量";
            this.ProductQTY.MinimumWidth = 6;
            this.ProductQTY.Name = "ProductQTY";
            this.ProductQTY.Width = 125;
            // 
            // ProductAmount
            // 
            this.ProductAmount.DataPropertyName = "Amount";
            this.ProductAmount.HeaderText = "小計";
            this.ProductAmount.MinimumWidth = 6;
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(67, 592);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(321, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtItems
            // 
            this.txtItems.Enabled = false;
            this.txtItems.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtItems.Location = new System.Drawing.Point(199, 138);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(241, 31);
            this.txtItems.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "貨物種類：";
            // 
            // frmPODetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 691);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPODetail);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.lblPid);
            this.Name = "frmPODetails";
            this.Text = "frmPODetails";
            this.Load += new System.EventHandler(this.PODetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvPODetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label2;
    }
}