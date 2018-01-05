using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Z_Reply
    {
        private int z_r_id;
        private int z_c_id;
        private int userid;
        private DateTime z_r_time;
        private String z_r_content;

        public int Z_R_Id
        {
            get { return this.z_r_id; }
            set { this.z_r_id = value; }

        }
        public int Z_C_Id
        {
            get { return this.z_c_id; }
            set { this.z_c_id = value; }
        }
        public int UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public DateTime Z_R_Time
        {
            get { return this.z_r_time; }
            set { this.z_r_time = value; }
        }
        public String Z_R_Content
        {
            get { return this.z_r_content; }
            set { this.z_r_content = value; }
        }
    }
}
