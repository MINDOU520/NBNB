using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class SaishiManager
    {
        public static int AddSaishi(Saishi ns)
        {
            return SaishiService.Insert(ns);
        }

        public static DataTable SelectID(int S_Id)
        {
            return SaishiService.SelectID(S_Id);
        }
    }
}
