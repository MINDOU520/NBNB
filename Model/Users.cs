using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Users
    {
        private int userId;
        private string username;
        private string userpassword;
        private string useremail;
        private string usertpl;
        private string usersex;
        private string userheight;
        private string userweight;
        private string userage;

        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string UserPassword
        {
            get { return this.userpassword; }
            set { this.userpassword = value; }
        }
        public string UserEmail
        {
            get { return this.useremail; }
            set { this.useremail = value; }
        }
        public string UserTpl
        {
            get { return this.usertpl; }
            set { this.usertpl = value; }
        }
        public string UserSex
        {
            get { return this.usersex; }
            set { this.usersex = value; }
        }
      

        public string UserHeight
        {
            get { return this.userheight; }
            set { this.userheight = value; }
        }

        public string UserWeight
        {
            get { return this.userweight; }
            set { this.userweight = value; }
        }

        public string UserAge
        {
            get { return this.userage; }
            set { this.userage = value; }
        }

    }
}
