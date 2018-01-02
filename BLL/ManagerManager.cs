using DAL;
using DALFactory;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public  class ManagerManager
    {
        private static IManager imanager = (IManager)DataAccess.Get<SqlServerManager>();
        
        public static SqlDataReader Login(string m_name, string m_password)
        {
            return imanager.Login(m_name,m_password);
        }
    }
}
