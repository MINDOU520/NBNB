using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
using IDAL;

namespace DAL
{
    public class SqlServerZ_Reply : IZ_Reply
    {
        public int addZ_Reply(Z_Reply z_reply)
        {
            string sql = "insert into Z_Reply values(@Z_C_Id,@UserId,@Z_R_Time,@Z_R_Content)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Z_C_Id",z_reply.Z_C_Id),
                new SqlParameter("@UserId",z_reply.UserId),
                new SqlParameter("@Z_R_Time",z_reply.Z_R_Time),
                new SqlParameter("@Z_R_Content",z_reply.Z_R_Content)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable selectID(int id)
        {
            string sql = "select * from Z_Reply where Z_C_Id=@Z_C_Id";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,Z_Comment b,Z_Reply c ,Users d where c.Z_C_Id='" + id + "'and b.Z_C_Id=c.Z_C_Id and b.UserId=a.UserId and c.UserId=d.UserId";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }
        public int Delete(int id)
        {
            string sql = "delete from Z_Reply where Z_R_Id='" + id + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
        public DataTable SelectAll()
        {
            string sql = "select a.UserName as beforename,d.UserName as aftername,c.* from Users a,Z_Comment b,Z_Reply c ,Users d where b.Z_C_Id=c.Z_C_Id and b.UserId=a.UserId and c.UserId=d.UserId";
            return DBHelper.GetFillData(sql);

        }
    }
}
