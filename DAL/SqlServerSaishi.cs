using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IDAL;

namespace DAL
{
   public class SqlServerSaishi:ISaishi
    {
        public int Insert(Saishi ns)
        {
            string sql = "insert into Saishi values(@userid,@s_name,@s_time,@s_adder)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@userid",ns.UserId),
                                                 new SqlParameter("@s_name",ns.S_Name),
                                                 new SqlParameter("@s_time",ns.S_Time),
                                                 new SqlParameter("@s_adder",ns.S_Adder)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public  DataTable SelectID(int S_Id)
        {
            string sql = "select a.*,b.UserName from saishi a, Users b where s_id = @s_id and a.Userid = b.Userid";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@s_id", S_Id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int updateS_clickNum(int S_Id)
        {
            string sql = "update Saishi set s_clickNum=s_clickNum+1 where S_Id=@S_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@S_Id",S_Id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
       
       
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.username from saishi a, Users b where a.userid=b.userid order by s_time desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
