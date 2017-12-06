using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class T_Comment
    {
        private string t_c_id;                   //帖子评论编号
        private DateTime t_c_time;                  //帖子评论时间
        private string userid;                      //用户ID
        private string t_c_content;                    //帖子评论内容

        public string T_C_Id
        {
            get { return this.t_c_id; }
            set { this.t_c_id = value; }
        }
        public DateTime T_C_Time
        {
            get { return this.t_c_time; }
            set { this.t_c_time = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public string T_C_Content
        {
            get { return this.t_c_content; }
            set { this.t_c_content = value; }
        }
    }
}
