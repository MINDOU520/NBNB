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
            string sql = "insert into Saishi values(@s_name,@s_time,@s_adder)";
            SqlParameter[] sp = new SqlParameter[]{new SqlParameter("@s_name",ns.S_Name),
                                                 new SqlParameter("@s_time",ns.S_Time),
                                                 new SqlParameter("@s_adder",ns.S_Adder)};
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public  DataTable SelectID(int S_Id)
        {
            string sql = "select  * from saishi where s_id=@s_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@s_id", S_Id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
    }
}
