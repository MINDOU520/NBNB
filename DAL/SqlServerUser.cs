using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlServerUser:IUsers
    {
        public  SqlDataReader SelectName(string username)
        {
            string sql = "select * from Users where username=@username";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Username",username)
            };
            return DBHelper.GetDataReader(sql, sp);
        }

        public  int Insert(Users us)
        {
            string sql = "insert into Users values(@username,@userpassword)";
            SqlParameter[] sp = new SqlParameter[]{
               
                new SqlParameter("@username",us.UserName),
                new SqlParameter("@userpassword",us.UserPassword),
                //new SqlParameter("@useremail",us.UserEmail),
                //new SqlParameter("@usertpl",us.UserTpl),
                //new SqlParameter("@usersex",us.UserSex),
                //new SqlParameter("@userheight",us.UserHeight),
                //new SqlParameter("@userweight",us.UserWeight),
                //new SqlParameter("@userage",us.UserAge),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public  SqlDataReader Login(string username, string userpassword)
        {
            string sql = "select * from Users where username=@username and userpassword=@userpassword";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@username",username),
                new SqlParameter("@userpassword",userpassword)
            };
            return DBHelper.GetDataReader(sql, sp);

        }

        public  DataTable SelectID(int UserId)
        {
            string sql = "select  * from Users  where userid=@userid";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@userid",UserId)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
      
    }
}
