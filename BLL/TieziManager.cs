using DALFactory;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class TieziManager
    {
        //private static ITiezi itiezi = DataAccess.CreateTiezi();

        private static ITiezi itiezi = (ITiezi)DataAccess.Get<SqlServerTiezi>();

        public static DataTable SelectID(int T_Id)
        {
            return itiezi.SelectID(T_Id);
        }

     public  static DataTable SelectAll()
        {
            return itiezi.SelectAll();
        }
        public static DataTable SelectTouxiang()
        {
            return itiezi.SelectTouxiang();
        }
        public static  DataTable SelectUsername()
        {
            return itiezi.SelectUsername();
        }

        public static int Dianzan(int T_Id)
        {
            return itiezi.Dianzan(T_Id);
        }


        public static int AddTiezil(Tiezi ns)
        {
            return itiezi.Insert(ns);
        }
    }
}
