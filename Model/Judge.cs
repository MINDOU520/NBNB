using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Judge
    {

        private int j_id;         //裁判编号 
        private int userid;       //用户编号
        private string j_adder;   //裁判地址

        public int J_id
        {
            get { return this.j_id; }
            set { this.j_id = value; }
        }
        public int UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
       
        public string J_Adder
        {
            get { return this.j_adder; }
            set { this.j_adder = value; }
        }
        
    }
}
