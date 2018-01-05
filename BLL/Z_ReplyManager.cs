using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using DALFactory;


namespace BLL
{
    public class Z_ReplyManager
    {
        private static IZ_Reply iz_reply = (IZ_Reply)DataAccess.Get<SqlServerZ_Reply>();

        public static int addZ_Reply(Z_Reply z_reply)
        {
            return iz_reply.addZ_Reply(z_reply);
        }

        public static DataTable selectID(int id)
        {
            return iz_reply.selectID(id);
        }

        public static DataTable SelectID(int id)
        {
            return iz_reply.SelectID(id);
        }
        public static int Delete(int id)
        {
            return iz_reply.Delete(id);

        }
        public static DataTable SelectAll()
        {
            return iz_reply.SelectAll();
        }
    }
}