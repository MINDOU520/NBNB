using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class C_Comment
    {
        private string c_comment_id;                   //商品评论编号
        private DateTime c_c_time;                  //商品评论时间
        private string userid;                      //用户ID
        private string username;                    //用户名

        public string C_Comment_ID
        {
            get { return this.c_comment_id; }
            set { this.c_comment_id = value; }
        }
        public DateTime C_C_Time
        {
            get { return this.c_c_time; }
            set { this.c_c_time = value; }
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
