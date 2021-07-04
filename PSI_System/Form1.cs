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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string UserName = string.Empty;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = this.txtAccount.Text;
            string pwd = this.txtPwd.Text.Trim();

            AccountManager manager = new AccountManager();
            AccountModel model = new AccountModel();
            model = manager.GetAccount(account);

            if (model != null && string.Compare(pwd, model.Password, false) == 0)
            {
                UserName = model.Name;
                Form2 frm2 = new Form2();
                frm2.Main = this;
                //frm2.UserName = this.UserName;
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤，請重新輸入");
                this.txtAccount.Clear();
                this.txtPwd.Clear();
                this.txtAccount.Focus();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            this.txtAccount.Clear();
            this.txtPwd.Clear();
            this.txtAccount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("你確定要離開嗎?", "是否離開" ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
