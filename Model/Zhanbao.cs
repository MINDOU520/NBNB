using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public  class Zhanbao
    {

        private int z_id;
        private string z_title;
        private DateTime z_time;
        private string z_content;
        private string z_viewnum;
        private int  z_c_id;
        private string z_commentnum;
        private string z_zhuanfa;
        private int v_id;

        public int  Z_Id
        {
            get { return this.z_id; }
            set { this.z_id = value; }
        }

      
        public string Z_Title
        {
            get { return this.z_title; }
            set { this.z_title = value; }
        }
        public DateTime Z_Time
        {
            get { return this.z_time; }
            set { this.z_time = value; }
        }

        public string Z_Content
        {
            get { return this.z_content; }
            set { this.z_content = value; }
        }

        public  string  Z_Viewnum
        {
            get { return this.z_viewnum; }
            set { this.z_viewnum = value; }
        }

        public  int Z_C_Id
        {
            get { return this.z_c_id; }
            set { this.z_c_id = value; }
        }

        public  string  Z_Commentnum
        {
            get { return this.z_commentnum; }
            set { this.z_commentnum = value; }
        }

        public string  Z_Zhuanfa
        {
            get { return this.z_zhuanfa; }
            set { this.z_zhuanfa = value; }
        }

        public  int V_Id
        {
            get { return this.v_id; }
            set { this.v_id= value; }
        }
    }
}
