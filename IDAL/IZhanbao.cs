using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Model;

namespace IDAL
{
    public interface IZhanbao
    {
        DataTable SelectTop5();


        int Insert(Zhanbao ns);
        
        DataTable SelectTop(int top);
        
        DataTable SelectAll();

        DataTable SelectID(int z_Id);
    
    }
}
