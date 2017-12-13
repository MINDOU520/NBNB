using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
     public  class CommodityService
    {

        public static int Insert(Commodity cm)
        {
            string sql = "insert into Commodity values(@c_name,@c_photo,@c_price)";
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@c_name",cm.C_Name),
                new SqlParameter("@c_photo",cm.C_Photo),
                new SqlParameter("@c_price",cm.C_Price),
               
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public static DataTable SelectAll()
        {
            string sql = "select  * from Commodity";
            return DBHelper.GetFillData(sql);
        }


        public static DataTable SelectTop3()
        {
            string sql = "Select top 3 * from Commodity";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }
        public static DataTable SelectTop1()
        {
            string sql = "Select top 1 * from Commodity";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }
        public static DataTable SelectID(object C_Id)
        {
            string sql = "select  * from Commodity  where c_id=@c_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@c_id", C_Id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
    }
}
