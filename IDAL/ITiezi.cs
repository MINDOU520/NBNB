using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface ITiezi
    {
        DataTable SelectID(int t_Id);
        DataTable SelectAll();
        int Insert(Tiezi ns);
    }
}
