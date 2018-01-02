using DAL;
using DALFactory;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class ZhanbaoManager
    {
        private static IZhanbao izhanbao = (IZhanbao)DataAccess.Get<SqlServerZhanbao>();
        public static DataTable SelectTop5()
        {
            return izhanbao.SelectTop5();
        }
        public static DataTable SelectAll()
        {
            return izhanbao.SelectAll();
        }
        public static DataTable SelectID(int Z_Id)
        {
            return izhanbao.SelectID(Z_Id);
        }
        public static DataTable SelectTop(int top)
        {
            return izhanbao.SelectTop(top);
        }
        public static int AddZhanbao(Zhanbao ns)
        {
            return izhanbao.Insert(ns);
        }
    }
}

