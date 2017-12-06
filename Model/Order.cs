using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Order
    {
        private string o_id;                 //订单编号
        private string c_id;                 //商品编号
        private string c_name;               //商品名称
        private DateTime o_time;             //订单时间
        private string userid;               //用户编号
        private string o_adder;              //订单地址
        private string o_tpl;                //订单电话
        private string o_name;               //订单名称
        private string wl_id;                //物流编号

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
         public string C_Name
        {
            get { return this.c_name; }
            set { this.c_name = value; }
        }
         public DateTime O_Time
        {
            get { return this.o_time; }
            set { this.o_time = value; }
        }
         public string UserId
        {
            get { return this.userid;}
            set { this.userid = value; }
        }
         public string O_Adder
        {
            get { return this.o_adder; }
            set { this.o_adder = value; }
        }
         public string O_Tpl
        {
            get { return this.o_tpl; }
            set { this.o_tpl = value; }
        }
         public string O_Name
        {
            get { return this.o_name; }
            set { this.o_name = value; }
        }
         public string WL_Id
        {
            get { return this.wl_id; }
            set { this.wl_id = value; }
        }
    }
}
