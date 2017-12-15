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
        private static ICommodity icommodity = DataAccess.CreateCommdity();
        public static int AddCommodity(Commodity cm)
        {
            return icommodity.Insert(cm);
        }
        public static DataTable SelectAll()
        {
            return icommodity.SelectAll();
        }

        public static DataTable SelectTop3()
        {
            return icommodity.SelectTop3();
        }
        public static DataTable SelectTop1()
        {
            return icommodity.SelectTop1();
        }

        public static DataTable SelectID(object C_Id)
        {
            return icommodity.SelectID(C_Id);
        }

       
    }
}
