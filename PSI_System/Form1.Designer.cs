
namespace PSI_System
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSI_System.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(119, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(33, 137);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(82, 24);
            this.lblAccount.TabIndex = 6;
            this.lblAccount.Text = "帳號：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(37, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 1);
            this.panel1.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(119, 135);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(243, 25);
            this.txtAccount.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(91, 342);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(245, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(119, 223);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '＊';
            this.txtPwd.Size = new System.Drawing.Size(243, 25);
            this.txtPwd.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Location = new System.Drawing.Point(37, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1);
            this.panel2.TabIndex = 7;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPwd.Location = new System.Drawing.Point(33, 225);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 24);
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "密碼：";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClear.Location = new System.Drawing.Point(311, 294);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(51, 22);
            this.lblClear.TabIndex = 9;
            this.lblClear.Text = "清除";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 445);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblClear;
    }
}

