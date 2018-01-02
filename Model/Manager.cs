using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public    class Manager
    {
        private int m_id;                 //管理员编号
        private string m_name;               //管理员名字
        private string m_password;             //管理员密码

        public int M_Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }
        public string M_Name
        {
            get { return this.m_name; }
            set { this.m_name = value; }
        }
     
        public string M_Password
        {
            get { return this.m_password; }
            set { this.m_password = value; }
        }
    }
}
