using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tsuhan_scgl_yh
	/// </summary>
	public partial class tsuhan_scgl_yh
	{
		public tsuhan_scgl_yh()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.tsuhan_scgl_yh model)
		{
			StringBuilder strSql=new StringBuilder();
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

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tsuhan_scgl_yh model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tsuhan_scgl_yh set ");
			strSql.Append("工号=@工号,");
			strSql.Append("姓名=@姓名,");
			strSql.Append("密码=@密码,");
			strSql.Append("用户级别=@用户级别,");
			strSql.Append("工序名称=@工序名称,");
			strSql.Append("性别=@性别,");
			strSql.Append("联系电话=@联系电话,");
			strSql.Append("AB班=@AB班,");
			strSql.Append("登录次数=@登录次数");
			strSql.Append(" where ");
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

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tsuhan_scgl_yh ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_scgl_yh GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数 from tsuhan_scgl_yh ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.tsuhan_scgl_yh model=new Maticsoft.Model.tsuhan_scgl_yh();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.tsuhan_scgl_yh DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tsuhan_scgl_yh model=new Maticsoft.Model.tsuhan_scgl_yh();
			if (row != null)
			{
				if(row["工号"]!=null)
				{
					model.工号=row["工号"].ToString();
				}
				if(row["姓名"]!=null)
				{
					model.姓名=row["姓名"].ToString();
				}
				if(row["密码"]!=null)
				{
					model.密码=row["密码"].ToString();
				}
				if(row["用户级别"]!=null)
				{
					model.用户级别=row["用户级别"].ToString();
				}
				if(row["工序名称"]!=null)
				{
					model.工序名称=row["工序名称"].ToString();
				}
				if(row["性别"]!=null)
				{
					model.性别=row["性别"].ToString();
				}
				if(row["联系电话"]!=null)
				{
					model.联系电话=row["联系电话"].ToString();
				}
				if(row["AB班"]!=null)
				{
					model.AB班=row["AB班"].ToString();
				}
				if(row["登录次数"]!=null && row["登录次数"].ToString()!="")
				{
					model.登录次数=int.Parse(row["登录次数"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select 工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数 ");
			strSql.Append(" FROM tsuhan_scgl_yh ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" 工号,姓名,密码,用户级别,工序名称,性别,联系电话,AB班,登录次数 ");
			strSql.Append(" FROM tsuhan_scgl_yh ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tsuhan_scgl_yh ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from tsuhan_scgl_yh T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tsuhan_scgl_yh";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

