using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Maticsoft.DBUtility;
using Maticsoft.Model;

namespace DAL
{
    public class YhDAL
    {
        DbHelperSQLP dbhelper3 = new DbHelperSQLP(PubConstant.GetConnectionString("connectionString"));
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string name,string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tsuhan_scgl_yh");
            strSql.Append(" where 工号=@工号 and 密码=@密码");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.VarChar,40),
                    new SqlParameter("@密码",SqlDbType.VarChar,40)
                                        };
            parameters[0].Value = name;
            parameters[1].Value = pwd;

            return dbhelper3.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exist(string 工号)
        {
            string sql = "select * from tsuhan_scgl_yh where 工号='" + 工号 + "'";
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.NVarChar,30)};
            parameters[0].Value = 工号;
            return dbhelper3.Exists(sql, parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string 姓名)
        {
            string sql = "select * from tsuhan_scgl_yh where 姓名='" + 姓名 + "'";
            

            SqlParameter[] parameters = {
					new SqlParameter("@姓名", SqlDbType.NVarChar,40)};
            parameters[0].Value = 姓名;
            return dbhelper3.Exists(sql, parameters);
        }


        /// <summary>
        /// 根据工号查询工序名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tsuhan_scgl_yh GetModel(string 工号)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数 from tsuhan_scgl_yh ");
            strSql.Append(" where 工号=@工号");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.VarChar,30)		};
            parameters[0].Value = 工号;
            tsuhan_scgl_yh model = new tsuhan_scgl_yh();
            DataSet ds = dbhelper3.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            };
        }

        /// <summary>
        /// 根据姓名查询工序名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public tsuhan_scgl_yh GetModelName(string 姓名)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数 from tsuhan_scgl_yh ");
            strSql.Append(" where 姓名=@姓名 ");
            SqlParameter[] parameters = {
					new SqlParameter("@姓名", SqlDbType.VarChar,40)			};
            parameters[0].Value = 姓名;
            tsuhan_scgl_yh model = new tsuhan_scgl_yh();
            DataSet ds = dbhelper3.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            };
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tsuhan_scgl_yh DataRowToModel(DataRow row)
        {
            tsuhan_scgl_yh model = new tsuhan_scgl_yh();
            if (row != null)
            {
                if (row["工号"] != null)
                {
                    model.工号 = row["工号"].ToString();
                }
                if (row["姓名"] != null)
                {
                    model.姓名 = row["姓名"].ToString();
                }
                if (row["密码"] != null)
                {
                    model.密码 = row["密码"].ToString();
                }
                if (row["用户级别"] != null)
                {
                    model.用户级别 = row["用户级别"].ToString();
                }
                if (row["工序名称"] != null)
                {
                    model.工序名称 = row["工序名称"].ToString();
                }
                if (row["性别"] != null)
                {
                    model.性别 = row["性别"].ToString();
                }
                if (row["联系电话"] != null)
                {
                    model.联系电话 = row["联系电话"].ToString();
                }
                if (row["AB班"] != null)
                {
                    model.AB班 = row["AB班"].ToString();
                }
                if (row["登录次数"] != null && row["登录次数"].ToString() != "")
                {
                    model.登录次数 = int.Parse(row["登录次数"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 查询所有的用户信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsuhan_scgl_yh ");
            return dbhelper3.Query(strSql.ToString());
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Add(tsuhan_scgl_yh model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsuhan_scgl_yh(");
            strSql.Append("工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数)");
            strSql.Append(" values (");
            strSql.Append("@工号,@姓名,@密码,@用户级别,@工序名称,@性别,@联系电话,@AB班,@登录次数)");
            SqlParameter[] parameters = {
					new SqlParameter("@工号", SqlDbType.VarChar,30),
					new SqlParameter("@姓名", SqlDbType.VarChar,40),
					new SqlParameter("@密码", SqlDbType.VarChar,40),
					new SqlParameter("@用户级别", SqlDbType.VarChar,30),
					new SqlParameter("@工序名称", SqlDbType.VarChar,30),
					new SqlParameter("@性别", SqlDbType.VarChar,10),
					new SqlParameter("@联系电话", SqlDbType.VarChar,50),
					new SqlParameter("@AB班", SqlDbType.VarChar,10),
					new SqlParameter("@登录次数", SqlDbType.Int,4)};
            parameters[0].Value = model.工号;
            parameters[1].Value = model.姓名;
            parameters[2].Value = model.密码;
            parameters[3].Value = model.用户级别;
            parameters[4].Value = model.工序名称;
            parameters[5].Value = model.性别;
            parameters[6].Value = model.联系电话;
            parameters[7].Value = model.AB班;
            parameters[8].Value = model.登录次数;

            int rows = dbhelper3.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="yh"></param>
        /// <returns></returns>
        public bool Update(tsuhan_scgl_yh model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsuhan_scgl_yh set ");
            strSql.Append("姓名=@姓名,");
            strSql.Append("密码=@密码,");
            strSql.Append("用户级别=@用户级别,");
            strSql.Append("工序名称=@工序名称,");
            strSql.Append("性别=@性别,");
            strSql.Append("联系电话=@联系电话,");
            strSql.Append("AB班=@AB班,");
            strSql.Append("登录次数=@登录次数");
            strSql.Append(" where 工号=@工号");
            SqlParameter[] parameters = {
					new SqlParameter("@姓名", SqlDbType.VarChar,40),
					new SqlParameter("@密码", SqlDbType.VarChar,40),
					new SqlParameter("@用户级别", SqlDbType.VarChar,30),
					new SqlParameter("@工序名称", SqlDbType.VarChar,30),
					new SqlParameter("@性别", SqlDbType.VarChar,10),
					new SqlParameter("@联系电话", SqlDbType.VarChar,50),
					new SqlParameter("@AB班", SqlDbType.VarChar,10),
					new SqlParameter("@登录次数", SqlDbType.Int,4),
					new SqlParameter("@工号", SqlDbType.VarChar,30)};
            
            parameters[0].Value = model.姓名;
            parameters[1].Value = model.密码;
            parameters[2].Value = model.用户级别;
            parameters[3].Value = model.工序名称;
            parameters[4].Value = model.性别;
            parameters[5].Value = model.联系电话;
            parameters[6].Value = model.AB班;
            parameters[7].Value = model.登录次数;
            parameters[8].Value = model.工号;

            int rows = dbhelper3.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
