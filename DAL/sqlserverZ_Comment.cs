using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;
using IDAL;

namespace DAL
{
    public class SqlServerZ_Comment : IZ_Comment
    {
        public int addz_comment(Z_Comment z_comment)
        {
            string sql = "insert into Z_Comment values(@Z_Id,@Z_C_Content,@Z_C_time,@UserId)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Z_Id",z_comment.Z_Id),
                new SqlParameter("@Z_C_Content",z_comment.Z_C_Content),
                new SqlParameter("@Z_C_Time",z_comment.Z_C_Time),
                new SqlParameter("@UserId",z_comment.UserId)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = @"select  a.*,
                                            b.UserName AS UserName,
                                            c.Z_Id 
                                  from Z_Comment a, Users b,ZhanBao c 
                                  where a.UserId=b.UserId 
                                     and a.Z_Id=c.Z_Id";
            return DBHelper.GetFillData(sql);
        }

        //public DataTable SelectcoutID(int Comment_ST_id)
        //{
        //    string sql = "select  * from Z_Commnet where Z_Commnet_id=@Comment_HFood_id";
        //    SqlParameter[] sp = new SqlParameter[]{
        //        new SqlParameter("@Comment_HFood_id",Comment_ST_id)
        //    };
        //    DataTable dt = DBHelper.GetFillData(sql, sp);
        //    return dt;
        //}
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.UserName from Z_Comment a, Users b where a.UserId=b.UserId order by Z_C_time desc";

            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.*,b.UserName from Z_Comment a, Users b where Z_Id='" + id + "'and a.UserId=b.UserId order by Z_C_time";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("Z_C_Id",id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from Z_Comment where Z_C_Id='" + id + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
        public int CountComment()
        {
            string sql = "select count(*) from Z_Comment";
            return DBHelper.ExecuteScalar<int>(sql);
        }

        //public int addz_comment(Z_Comment z_comment)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
