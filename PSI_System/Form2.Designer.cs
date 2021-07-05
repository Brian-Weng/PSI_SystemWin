
namespace PSI_System
{
    partial class Form2
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
            this.btnPOForm = new System.Windows.Forms.Button();
            this.btnPdtFrom = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPO = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPOForm
            // 
            this.btnPOForm.BackColor = System.Drawing.Color.Khaki;
            this.btnPOForm.Enabled = false;
            this.btnPOForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOForm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPOForm.Location = new System.Drawing.Point(146, 25);
            this.btnPOForm.Name = "btnPOForm";
            this.btnPOForm.Size = new System.Drawing.Size(182, 37);
            this.btnPOForm.TabIndex = 1;
            this.btnPOForm.Text = "進貨單管理";
            this.btnPOForm.UseVisualStyleBackColor = false;
            // 
            // btnPdtFrom
            // 
            this.btnPdtFrom.BackColor = System.Drawing.Color.Khaki;
            this.btnPdtFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdtFrom.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPdtFrom.Location = new System.Drawing.Point(363, 25);
            this.btnPdtFrom.Name = "btnPdtFrom";
            this.btnPdtFrom.Size = new System.Drawing.Size(182, 37);
            this.btnPdtFrom.TabIndex = 2;
            this.btnPdtFrom.Text = "商品管理";
            this.btnPdtFrom.UseVisualStyleBackColor = false;
            this.btnPdtFrom.Click += new System.EventHandler(this.btnPdtFrom_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(146, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 40);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "進貨單總覽";
            // 
            // dgvPO
            // 
            this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.Items,
            this.QTY,
            this.ArrivalTime,
            this.Total,
            this.CreateDate,
            this.Creator,
            this.ModifyDate,
            this.Modifier});
            this.dgvPO.Location = new System.Drawing.Point(28, 167);
            this.dgvPO.Name = "dgvPO";
            this.dgvPO.RowHeadersWidth = 51;
            this.dgvPO.RowTemplate.Height = 27;
            this.dgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPO.Size = new System.Drawing.Size(932, 289);
            this.dgvPO.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(28, 486);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(73, 42);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(153, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(283, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrint.Location = new System.Drawing.Point(413, 486);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 42);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "列印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserName.Location = new System.Drawing.Point(881, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSI_System.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "單據編號";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.Width = 96;
            // 
            // Items
            // 
            this.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Items.DataPropertyName = "Items";
            this.Items.HeaderText = "貨物種類";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.Width = 96;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "進貨數量";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.Width = 96;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "預計進貨時間";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 150;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "進貨金額";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 96;
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "建立時間";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Width = 150;
            // 
            // Creator
            // 
            this.Creator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Creator.DataPropertyName = "Creator";
            this.Creator.HeaderText = "建立者";
            this.Creator.MinimumWidth = 6;
            this.Creator.Name = "Creator";
            this.Creator.Width = 96;
            // 
            // ModifyDate
            // 
            this.ModifyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ModifyDate.DataPropertyName = "ModifyDate";
            this.ModifyDate.HeaderText = "修改時間";
            this.ModifyDate.MinimumWidth = 6;
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.Width = 96;
            // 
            // Modifier
            // 
            this.Modifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Modifier.DataPropertyName = "Modifier";
            this.Modifier.HeaderText = "修改者";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Width = 96;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvPO);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPdtFrom);
            this.Controls.Add(this.btnPOForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPOForm;
        private System.Windows.Forms.Button btnPdtFrom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPO;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
    }
}