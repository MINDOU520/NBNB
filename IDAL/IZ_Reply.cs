using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace IDAL
{
    public interface IZ_Reply
    {
        int addZ_Reply(Z_Reply z_reply);
        DataTable selectID(int id);

        DataTable SelectID(int id);
        int Delete(int id);
        DataTable SelectAll();
    }
}