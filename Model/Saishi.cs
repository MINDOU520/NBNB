using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public   class Saishi
    {
        private int s_id;                 //比赛编号
        private int  userid;   //用户编号 
        private string s_name;
        private string s_time;             //比赛时间
        private string s_adder;               //比赛地址
                   
        private string s_num;
        private DateTime s_fabutime;        
        public int S_Id
        {
            get { return this.s_id; }
            set { this.s_id = value; }
        }
        public int UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public string S_Name
        {
            get { return this.s_name; }
            set { this.s_name = value; }
        }
        public string S_Time
        {
            get { return this.s_time; }
            set { this.s_time = value; }
        }
        public string S_Adder
        {
            get { return this.s_adder; }
            set { this.s_adder = value; }
        }
     
       
        public string S_Num
        {
            get { return this.s_num; }
            set { this.s_num = value; }
        }
        public DateTime S_Fabutime
        {
            get { return this.s_fabutime; }
            set { this.s_fabutime= value; }
        }
    }
}
