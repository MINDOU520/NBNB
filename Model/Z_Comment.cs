using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Z_Comment
    {
        private int z_c_id;                      //战报评论编号
        private int z_id;              
        private DateTime z_c_time;                  //战报评论时间
        private string z_c_content;                 //战报评论内容
        private int userid;                      //用户ID
        //private string username;                    //用户名

        public int Z_C_Id
        {
            get { return this.z_c_id; }
            set { this.z_c_id = value; }
        }
        public int Z_Id
        {
            get { return this.z_id; }
            set { this.z_id = value; }
        }
        public DateTime Z_C_Time
        {
            get { return this.z_c_time; }
            set { this.z_c_time = value; }
        }
        public string Z_C_Content
        {
            get { return this.z_c_content; }
            set { this.z_c_content = value; }
        }
        public int UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        //public string UserName
        //{
        //    get { return this.username; }
        //    set { this.username = value; }
        //}
    }
}
