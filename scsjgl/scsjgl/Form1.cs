using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maticsoft.Model;
using BLL;


namespace scsjgl
{
    public partial class Form1 : Form
    {
        YhBLL yhbll = new YhBLL();
        Login1 froTwo;
        public Form1(Login1 log)
        {
            froTwo = log;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var gt = yhbll.GetModel(froTwo.txtUserName.Text);
            if (gt.用户级别 == "系统管理员")
            {
                this.toolStripMenuItem1.Enabled = true;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = true;
                this.toolStripMenuItem7.Enabled = true;
            }
            else if (gt.用户级别 == "班长" || gt.用户级别 == "组长")
            {
                this.toolStripMenuItem1.Enabled = false;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = true;
                this.注销ToolStripMenuItem.Enabled = true;
                this.人员管理ToolStripMenuItem.Enabled = true;
            }
            else if (gt.用户级别 == "普通员工")
            {
                this.toolStripMenuItem1.Enabled = false;
                this.toolStripMenuItem6.Enabled = true;
                this.toolStripMenuItem2.Enabled = false;
                this.toolStripMenuItem7.Enabled = true;
                this.注销ToolStripMenuItem.Enabled = true;
                this.人员管理ToolStripMenuItem.Enabled = false;
                this.toolStripMenuItem8.Enabled = false;
                this.toolStripMenuItem9.Enabled = true;
                this.规格书录入ToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChanPin cp = new ChanPin(froTwo);
            cp.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SuiGongDanGX sgdgx = new SuiGongDanGX(froTwo);///随工单公信
            sgdgx.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
           // Login fromLogin = new Login();//登录
            SuiGongDanJTXX sdj = new SuiGongDanJTXX(froTwo);
            sdj.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            GuiGeShu ggs = new GuiGeShu(froTwo);///规格书
            ggs.ShowDialog();
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();//人员管理
            reg.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            KeHuXX khxx = new KeHuXX(froTwo);//客户信息
            khxx.ShowDialog();
        }

        //private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("确定要更换其他账户登录吗？？？", "提示", MessageBoxButtons.YesNo);

        //    if (dr == DialogResult.Yes)
        //    {

        //        Login1 log = new Login1();
        //        log.ShowDialog();
        //    }
        //}

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //点击注销按钮事件里面写： 

            if (MessageBox.Show("您确定要注销登录,更换其他账户吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            } 
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ChengPin cp = new ChengPin(froTwo);
            cp.ShowDialog();
        }


        private void 出货查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rk rk = new Rk();
            rk.ShowDialog();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select st = new Select();
            st.ShowDialog();
        }

        private void 规格书录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiGeShu ggs = new GuiGeShu(froTwo);///规格书
            ggs.ShowDialog();
        }

        private void 返修数据记录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FanXiu fx = new FanXiu();
            fx.ShowDialog();
        }

        private void 返修数据记录出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FanXiuC fxc = new FanXiuC();
            fxc.ShowDialog();
        }

        private void 关联码导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaoGLM d = new DaoGLM();
            d.ShowDialog();
        }
    }
}
