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


namespace scsjgl
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        YhBLL yhbll = new YhBLL();
        private void Register_Load(object sender, EventArgs e)
        {
            //绑定所有用户信息
            DataSet ds = yhbll.getAll();
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("确定要新增吗？？？","提示",MessageBoxButtons.YesNo);
             if (dr == DialogResult.Yes)
             {
                 tsuhan_scgl_yh yh = new tsuhan_scgl_yh();
                 yh.工号 = this.txtGH.Text;
                 yh.密码 = "111111";
                 yh.姓名 = this.txtName.Text;
                 yh.性别 = this.cbSex.Text;
                 yh.用户级别 = this.cbYHJB.Text;
                 yh.联系电话 = this.txtPhone.Text;
                 yh.工序名称 = this.cbGW.Text;
                 yh.AB班 = this.cbAB.Text;

                 bool result = false;
                 result = yhbll.Add(yh);
                 if (result == true)
                 {
                     MessageBox.Show("添加成功", "提示");
                     //刷新用户信息
                     DataSet ds = yhbll.getAll();
                     this.dataGridView1.DataSource = ds.Tables[0];
                 }
                 else
                 {
                     MessageBox.Show("添加失败", "提示");
                 }
             }

        }

        /// <summary>
        /// 判断工号是否存在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGH_MouseLeave(object sender, EventArgs e)
        {
            var gh = this.txtGH.Text;
            bool result = false;
            result = yhbll.Exist(gh);
            if (result == true)
            {
                //MessageBox.Show("该工号已经存在,请重新输入", "提示");
                tsuhan_scgl_yh yh = yhbll.GetModel(gh);
                this.cbYHJB.Text = yh.用户级别;
                this.txtName.Text = yh.姓名;
                this.txtPhone.Text = yh.联系电话;
                this.cbGW.Text = yh.工序名称;
                this.cbSex.Text = yh.性别;
                this.cbAB.Text = yh.AB班;
                this.btnAdd.Enabled = false;
                this.btnAdd.BackColor = Color.LightGray;
                this.btnUpdate.Enabled = true;
                this.btnUpdate.BackColor = Color.Gainsboro;
                return;
            }
            else
            {
                this.btnUpdate.Enabled = false;
                this.btnUpdate.BackColor = Color.LightGray;
                this.btnAdd.Enabled = true;
                this.btnAdd.BackColor = Color.Gainsboro;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要修改吗？？？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tsuhan_scgl_yh yh = new tsuhan_scgl_yh();
                var yy = yhbll.GetModel(this.txtGH.Text);
                yh.工号 = this.txtGH.Text;
                yh.姓名 = this.txtName.Text;
                yh.性别 = this.cbSex.Text;
                yh.密码 = yy.密码;
                yh.用户级别 = this.cbYHJB.Text;
                yh.联系电话 = this.txtPhone.Text;
                yh.工序名称 = this.cbGW.Text;
                yh.AB班 = this.cbAB.Text;

                bool result = false;
                result = yhbll.Update(yh);
                if (result == true)
                {
                    MessageBox.Show("修改成功", "提示");
                    //刷新用户信息
                    DataSet ds = yhbll.getAll();
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("修改失败", "提示");
                }
            }
        }


        private void btnCanles_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 双击dataGridView将对应值显示到文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.txtGH.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.cbYHJB.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.cbGW.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.cbSex.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.cbAB.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {

            var name = this.txtName.Text;
            bool result1 = false;
            result1 = yhbll.Exists(name);
            if (result1 == true)
            {
                tsuhan_scgl_yh yh = yhbll.GetModelName(name);
                this.cbYHJB.Text = yh.用户级别;
                this.txtGH.Text = yh.工号;
                this.txtPhone.Text = yh.联系电话;
                this.cbGW.Text = yh.工序名称;
                this.cbSex.Text = yh.性别;
                this.cbAB.Text = yh.AB班;
                this.btnAdd.Enabled = false;
                this.btnAdd.BackColor = Color.LightGray;
                this.btnUpdate.Enabled = true;
                this.btnUpdate.BackColor = Color.Gainsboro;
            }
            else
            {
                this.btnUpdate.Enabled = false;
                this.btnUpdate.BackColor = Color.LightGray;
                this.btnAdd.Enabled = true;
                this.btnAdd.BackColor = Color.Gainsboro;
            }
        }

    }
}
