using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserService
    {
        public static SqlDataReader SelectName(string username)
        {
            string sql = "select * from Users where username=@username";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@Username",username)
            };
            return DBHelper.GetDataReader(sql, sp);
        }

        public static int Insert(Users us)
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
        public static SqlDataReader Login(string username, string userpassword)
        {
            string sql = "select * from Users where username=@username and userpassword=@userpassword";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@username",username),
                new SqlParameter("@userpassword",userpassword)
            };
            return DBHelper.GetDataReader(sql, sp);

        }
    }
}
