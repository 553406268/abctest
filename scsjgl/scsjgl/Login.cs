using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Maticsoft.Model;
using System.Threading;

namespace scsjgl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        YhBLL yhbll = new YhBLL();
        public string name;
        public int pwd;
        private void btnDeng_Click(object sender, EventArgs e)
        {
           
            if (txtUserName.Text == "" || txtUserPwd.Text == "")
            {
                MessageBox.Show("用户名或密码未输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result;
            var name = this.txtUserName.Text;
            var pwd = this.txtUserPwd.Text;
            result = yhbll.Exists(name, pwd);
            //if (result == true)
            //{
            //    SuiGongDanJTXX sgdxx = new SuiGongDanJTXX();//随工单信息
            //    this.Hide(); 
                              
            //    sgdxx.ShowDialog();
            //    if (sgdxx.DialogResult == DialogResult.OK)
            //    {
            //        Thread t = new Thread(new ThreadStart(delegate { Application.Run(new SuiGongDanJTXX()); }));
            //        t.Start();
            //        this.Dispose(true); 
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("请正确输入信息！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
            //this.txtUserName.Text = name;
            //this.txtUserPwd.Text = pwd;

        }
    }
}
