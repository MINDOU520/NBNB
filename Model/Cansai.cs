using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Cansai
    {
        private int cs_id;
        private int s_id;
        private int userid;
        private int cs_num;

        public int CS_Id
        {
            get { return this.cs_id; }
            set { this.cs_id = value; }
        }
        public int S_Id
        {
            get { return this.s_id; }
            set { this.s_id = value; }
        }
        public int UserId
        {
            get { return this.userid; }
            set { this.userid= value; }
        }
        public int CS_Num
        {
            get { return this.cs_num; }
            set { this.cs_num= value; }
        }
    }
}