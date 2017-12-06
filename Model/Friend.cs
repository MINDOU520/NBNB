using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Friend
    {   
        private int  f_id;                      //好友ID
        private DateTime f_time;                //好友时间
        private string f_name;              //好友名字
        private string userid;                  //用户ID
        

        public int F_id
        {
            get { return this.f_id; }
            set { this.f_id = value; }
        }
        public DateTime F_time
        {
            get { return this.f_time; }
            set { this.f_time = value; }
        }
        public string F_name
        {
            get { return this.f_name; }
            set { this.f_name = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
       
    }
}
