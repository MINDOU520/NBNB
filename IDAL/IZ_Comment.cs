using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IDAL
{
    public interface IZ_Comment
    {
        int addz_comment(Z_Comment z_comment);
        DataTable SelectAll();
        //DataTable SelectcoutID(int Comment_ST_id);
        DataTable SelectTop(int top);
        DataTable SelectID(int id);
        int Delete(int id);
        int CountComment();
    }
}