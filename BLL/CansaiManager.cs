using DAL;
using DALFactory;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CansaiManager
    {
        private static ICansai icansai= (ICansai)DataAccess.Get<SqlServerCansai>();

        /// <summary>
        /// 添加参赛记录
        /// </summary>
        /// <param name="canSai">参赛实体对象</param>
        /// <returns>返回受影响的行数</returns>
        public static int AddCansai(Cansai canSai)
        {
            return icansai.Insert(canSai);
        }
    }
}
