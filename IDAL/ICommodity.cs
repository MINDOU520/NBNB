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
        DataTable SelectlanqiuTop4();
        DataTable SelectAll();
        int Insert(Commodity cm);
        DataTable selectlanqiu();
        DataTable SelectqiufuTop4();
        DataTable SelectqiuxieTop4();
        DataTable SelecthujuTop4();
        DataTable SelectotherTop4();
        DataTable Selectqiufu();
        DataTable Selectqiuxie();
        DataTable Selecthuju();
        DataTable Selectother();
        int publishanngping(Commodity ns);
    }
}
