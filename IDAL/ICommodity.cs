using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface ICommodity
    {
        DataTable SelectTop1();
        DataTable SelectID(object c_Id);
        DataTable SelectTop3();
        DataTable SelectAll();
        int Insert(Commodity cm);
    }
}
