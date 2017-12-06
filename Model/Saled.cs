using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Saled
    {
        private string saled_id;                 //出售编号
        private string o_id;                     //订单编号
        private string c_id;                     //商品编号

        public string Saled_Id
        {
            get { return this.saled_id; }
            set { this.saled_id = value; }
        }
        public string O_Id
        {
            get { return this.o_id; }
            set { this.o_id = value; }
        }
        public string C_Id
        {
            get { return this.c_id; }
            set { this.c_id = value; }
        }
    }
}
