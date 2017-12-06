using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Adder
    {
        private string useradder;           //用户地址
        private string o_adder;           //订单地址
        private string s_adder;           //场地地址
        private string j_adder;           //裁判地址
        private string country;             //国家
        private string province;            //省份
        private string city;                 //城市


        public string UserAdder
        {
            get { return this.useradder; }
            set { this.useradder = value; }
        }
        public string O_Adder
        {
            get { return this.o_adder; }
            set { this.o_adder = value; }
        }
        public string S_Adder
        {
            get { return this.s_adder; }
            set { this.s_adder = value; }
        }
        public string J_Adder
        {
            get { return this.j_adder; }
            set { this.j_adder = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Province
        {
            get { return this.province; }
            set { this.province = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

    }
}
