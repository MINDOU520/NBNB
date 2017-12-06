using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Record
    {
        private string r_id;                 //记录编号
        private DateTime r_time;             //记录时间
        private string r_adder;               //记录地址
        private string r_content;              //
        private string userid;                //用户编号
        private string username;               //用户名称

        public string R_Id
        {
            get { return this.r_id; }
            set { this.r_id = value; }
        }
        public DateTime R_Time
        {
            get { return this.r_time; }
            set { this.r_time = value; }
        }
        public string R_Adder
        {
            get { return this.r_adder; }
            set { this.r_adder = value; }
        }
        public string R_Content
        {
            get { return this.r_content; }
            set { this.r_content = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }
    }
}
