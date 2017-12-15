using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Model;

namespace IDAL
{
    public interface ISaishi
    {
        DataTable SelectID(int s_Id);
        int Insert(Saishi ns);
    }
}
