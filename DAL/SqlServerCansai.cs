using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlServerCansai : ICansai
    {
        public int Insert(Cansai canSai)
        {
            string sql = "insert into Cansai([S_Id], [UserId]) values(@S_Id, @UserId)";

            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@S_Id", canSai.S_Id),
                new SqlParameter("@UserId", canSai.UserId)
             };

            return DBHelper.GetExcuteNonQuery(sql, sp);
         }
     }
}
