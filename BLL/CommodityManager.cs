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
    public class CommodityManager
    {
      
        public static int AddCommodity(Commodity cm)
        {
            return CommodityService.Insert(cm);
        }
        public static DataTable SelectAll()
        {
            return CommodityService.SelectAll();
        }

        public static DataTable SelectTop3()
        {
            return CommodityService.SelectTop3();
        }
        public static DataTable SelectTop1()
        {
            return CommodityService.SelectTop1();
        }

        public static DataTable SelectID(object C_Id)
        {
            return CommodityService.SelectID(C_Id);
        }

       
    }
}
