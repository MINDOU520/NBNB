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
    public class CommodityManager
    {
        private static ICommodity icommodity = (ICommodity)DataAccess.Get<SqlServerCommodity>();
        public static int AddCommodity(Commodity cm)
        {
            return icommodity.Insert(cm);
        }
        public static DataTable SelectAll()
        {
            return icommodity.SelectAll();
        }

        public static DataTable SelectlanqiuTop4()
        {
            return icommodity.SelectlanqiuTop4();
        }
        public static  DataTable SelectqiufuTop4()
        {
            return icommodity.SelectqiufuTop4();
        }
        public static  DataTable SelectqiuxieTop4()
        {
            return icommodity.SelectqiuxieTop4();
        }
        public static DataTable SelecthujuTop4()
        {
            return icommodity.SelecthujuTop4();
        }
        public static  DataTable SelectotherTop4()
        {
            return icommodity.SelectotherTop4();
        }
        public static DataTable SelectTop1()
        {
            return icommodity.SelectTop1();
        }

        public static DataTable SelectID(object C_Id)
        {
            return icommodity.SelectID(C_Id);
        }
        public  static DataTable SelectLanqiu()
        {
            return icommodity.selectlanqiu();
        }
        public static DataTable selecthuju()
        {
            return icommodity.Selecthuju();
        }
        public static DataTable selectqiufu()
        {
            return icommodity.Selectqiufu();
        }
        public static DataTable selectqiuxie()
        {
            return icommodity.Selectqiuxie();
        }
        public static DataTable selectother()
        {
            return icommodity.Selectother();
        }

    }
}
