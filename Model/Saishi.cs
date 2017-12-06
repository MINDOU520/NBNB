using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Saishi
    {
        private string s_id;                 //比赛编号
        private DateTime s_time;             //比赛时间
        private string s_adder;               //比赛地址
        private string userid;                //用户编号

        public string S_Id
        {
            get { return this.s_id; }
            set { this.s_id = value; }
        }
        public DateTime S_Time
        {
            get { return this.s_time; }
            set { this.s_time = value; }
        }
        public string S_Adder
        {
            get { return this.s_adder; }
            set { this.s_adder = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
    }
}
