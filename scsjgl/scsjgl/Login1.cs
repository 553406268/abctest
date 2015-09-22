using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Threading;

namespace scsjgl
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        YhBLL yhbll = new YhBLL();
        
        private void btnDeng_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserPwd.Text == "")
            {
                MessageBox.Show("用户名或密码未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result;
            var user = this.txtUserName.Text;
            var pwd = this.txtUserPwd.Text;
            result = yhbll.Exists(user, pwd);
            if (result == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请正确输入信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }
    }
}
