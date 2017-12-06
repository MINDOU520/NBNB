using DAL;
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
        public static DataTable SelectTop5()
        {
            return ZhanbaoService.SelectTop5();
        }
        public static DataTable SelectAll()
        {
            return ZhanbaoService.SelectAll();
        }
        public static DataTable SelectID(int Z_Id)
        {
            return ZhanbaoService.SelectID(Z_Id);
        }
        public static DataTable SelectTop(int top)
        {
            return ZhanbaoService.SelectTop(top);
        }
        public static int AddZhanbao(Zhanbao ns)
        {
            return ZhanbaoService.Insert(ns);
        }
    }
}

