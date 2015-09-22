using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Model
{
    /// <summary>
    /// tsuhan_scgl_yh:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tsuhan_scgl_yh
    {
        public tsuhan_scgl_yh()
        { }
        #region Model
        private string _工号;
        private string _姓名;
        private string _密码;
        private string _用户级别;
        private string _工序名称;
        private string _性别;
        private string _联系电话;
        private string _ab班;
        private int _登录次数;
        /// <summary>
        /// 
        /// </summary>
        public string 工号
        {
            set { _工号 = value; }
            get { return _工号; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 密码
        {
            set { _密码 = value; }
            get { return _密码; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 用户级别
        {
            set { _用户级别 = value; }
            get { return _用户级别; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 工序名称
        {
            set { _工序名称 = value; }
            get { return _工序名称; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 联系电话
        {
            set { _联系电话 = value; }
            get { return _联系电话; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AB班
        {
            set { _ab班 = value; }
            get { return _ab班; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int 登录次数
        {
            set { _登录次数 = value; }
            get { return _登录次数; }
        }
        #endregion Model

    }
}


