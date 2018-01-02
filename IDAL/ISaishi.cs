﻿using System;
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
        int updateS_clickNum(int s_Id);
        DataTable SelectAll();
        int CountSaishi();
        DataTable SelectsaishiById(int S_Id);
    }
}
