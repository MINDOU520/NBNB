using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
using IDAL;
using DALFactory;

namespace BLL
{
   
    public class SaishiManager
    {
        private static ISaishi isaishi= DataAccess.CreateSaishi();
        public static int AddSaishi(Saishi ns)
        {
            return isaishi.Insert(ns);
        }

        public static DataTable SelectID(int S_Id)
        {
            return isaishi.SelectID(S_Id);
        }
        public  static int updateS_clickNum(int S_Id)
        {
            return isaishi.updateS_clickNum(S_Id);
        }
        public static DataTable SelectAll()
        {
            return isaishi.SelectAll();
        }
    }
}
