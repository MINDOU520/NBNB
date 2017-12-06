using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Manager
    {
        private string m_id;                 //管理员编号
        private string m_name;               //管理员名字
        private string userpassword;          //用户密码
        private string m_password;             //管理员密码

        public string M_Id
        {
            get { return this.m_id; }
            set { this.m_id = value; }
        }
        public string M_Name
        {
            get { return this.m_name; }
            set { this.m_name = value; }
        }
        public string UserPassword
        {
            get { return this.userpassword; }
            set { this.userpassword = value; }
        }
        public string M_Password
        {
            get { return this.m_password; }
            set { this.m_password = value; }
        }
    }
}
