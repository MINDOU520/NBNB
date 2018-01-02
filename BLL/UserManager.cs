using DAL;
using DALFactory;
using IDAL;
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
        private static IUsers iusers= (IUsers)DataAccess.Get<SqlServerUser>();
        public static DataTable SelectID(int UserId)
        {
            return iusers.SelectID(UserId);
        }
        public static SqlDataReader SelectName(string name)
        {
            return iusers.SelectName(name);
        }
        public static int AddUser(Users us)
        {
            return iusers.Insert(us);
        }
        public static SqlDataReader Login(string username, string userpassword)
        {
            return iusers.Login(username, userpassword);
        }
    }
}
