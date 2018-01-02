using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data;
using IDAL;

namespace DAL
{
    public class SqlServerCommodity : ICommodity
    {

        public int Insert(Commodity cm)
        {
            string sql = "insert into Commodity values(@c_name,@c_photo,@c_price)";
            SqlParameter[] sp = new SqlParameter[]{

                new SqlParameter("@c_name",cm.C_Name),
                new SqlParameter("@c_photo",cm.C_Photo),
                new SqlParameter("@c_price",cm.C_Price),

            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
        public DataTable SelectAll()
        {
            string sql = "select  * from Commodity";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectlanqiuTop4()
        {
            string sql = "Select top 4 * from Commodity where C_Biaoshi='3'";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }
        public DataTable SelectqiufuTop4()
        {
            string sql = "Select top 4 * from Commodity where C_Biaoshi='1'";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectqiuxieTop4()
        {
            string sql = "Select top 4 * from Commodity where C_Biaoshi='2'";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelecthujuTop4()
        {
            string sql = "Select top 4 * from Commodity where C_Biaoshi='4'";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectotherTop4()
        {
            string sql = "Select top 4 * from Commodity where C_Biaoshi='5'";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }

        public DataTable SelectTop1()
        {
            string sql = "Select top 1 * from Commodity";
            DataTable dt = DBHelper.GetFillData(sql);
            return dt;
        }
        public DataTable SelectID(object C_Id)
        {
            string sql = "select  * from Commodity  where c_id=@c_id";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@c_id", C_Id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable selectlanqiu()
        {
            string sql = "select * from Commodity  where C_Biaoshi='3'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable Selectqiufu()
        {
            string sql = "select * from Commodity  where C_Biaoshi='1'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable Selectqiuxie()
        {
            string sql = "select * from Commodity  where C_Biaoshi='2'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable Selecthuju()
        {
            string sql = "select * from Commodity  where C_Biaoshi='4'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable Selectother()
        {
            string sql = "select * from Commodity  where C_Biaoshi='5'";
            return DBHelper.GetFillData(sql);
        }
    }
}
