using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Comment
    {
        private string c_c_id;             //商品评论编号
        private string t_c_id;             //帖子评论编号
        private string z_c_id;             //战报评论编号

        public string C_C_Id
        {
            get { return this.c_c_id;}
            set {this.c_c_id=value;}
        }
        public string T_C_Id
        {
            get { return this.t_c_id; }
            set { this.t_c_id = value; }
        }
        public string Z_C_Id
        {
            get { return this.z_c_id; }
            set { this.z_c_id = value; }
        }
    }
}
