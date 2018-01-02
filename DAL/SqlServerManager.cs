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
    public class SqlServerManager:IManager
    {
        public SqlDataReader Login(string m_name, string m_password)
        {
            string sql = "select * from Manager where m_name=@m_name and m_password=@m_password";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@m_name",m_name),
                new SqlParameter("@m_password",m_password)
            };
            return DBHelper.GetDataReader(sql, sp);

        }
        public int Insert(Manager us)
        {
            string sql = "insert into Manager values(@m_name,@m_password)";
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@m_name",us.M_Name),
                new SqlParameter("@m_password",us.M_Password),
                   };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
