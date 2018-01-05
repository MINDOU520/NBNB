using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class SqlServerTiezi : ITiezi
    {


        public DataTable SelectID(int T_Id)
        {
            string sql = "select  * from tiezi where t_id=@t_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@t_id", T_Id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
       
        public DataTable SelectAll()
        {
            string sql = @"select Tiezi.*,
                                            Users.UserTouxiang as [usertouxiang],
                                            Users.UserName as [username]
                                   from Tiezi, Users 
                                   order by t_time desc";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectTouxiang()
        {
            string sql = @"select Tiezi.*,
                                            Users.UserTouxiang as [usertouxiang],
                                   from Tiezi, Users ";
                           
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectUsername()
        {
            string sql = "select username from users ,tiezi where tiezi.userid=users.userid";
            return DBHelper.GetFillData(sql);
        }

        public int Insert(Tiezi ns)
        {
            string sql = "insert into [Tiezi]([UserId],[T_Time],[T_Content]) values(@userid,@t_time,@t_content)";
            SqlParameter[] sp = new SqlParameter[]
            {new SqlParameter("@userid",ns.UserId),
            new SqlParameter("@t_time",ns.T_Time),
            new SqlParameter("@t_content",ns.T_Content)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        
        public int Dianzan(int T_Id)
        {
            string sql = "update Tiezi set t_DianzanNum=t_DianzanNum+1 where T_Id=@T_Id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@T_Id",T_Id)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
