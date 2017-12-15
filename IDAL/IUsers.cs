using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace IDAL
{
    public interface IUsers
    {
        SqlDataReader SelectName(string username);
        int Insert(Users us);
        SqlDataReader Login(string username, string password);
        DataTable SelectID(int UserId);


    }
}
