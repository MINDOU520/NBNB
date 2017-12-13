using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        public static SqlDataReader SelectName(string username)
        {
            return UserService.SelectName(username);
        }
        public static int AddUser(Users us)
        {
            return UserService.Insert(us);
        }
        public static SqlDataReader Login(string username, string userpassword)
        {
            return UserService.Login(username, userpassword);
        }
        public static DataTable SelectID(int UserId)
        {
            return UserService.SelectID(UserId);
        }

    }
}
