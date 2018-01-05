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
    public class Z_CommentManager
    {
        private static IZ_Comment iz_comment = (IZ_Comment)DataAccess.Get<SqlServerZ_Comment>();

        public static DataTable SelectAll()
        {
            return iz_comment.SelectAll();
        }
        public static DataTable SelectID(int id)
        {
            return iz_comment.SelectID(id);
        }
        public static DataTable SelectTop(int top)
        {
            return iz_comment.SelectTop(top);
        }
        public static int addz_comment(Z_Comment z_comment)
        {
            return iz_comment.addz_comment(z_comment);
        }
        public static DataTable SelectcoutID(int id)
        {
            return iz_comment.SelectID(id);
        }
        public static int Delete(int id)
        {
            return iz_comment.Delete(id);
        }
        public static int CountComment()
        {
            return iz_comment.CountComment();
        }
    }
}

