using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video
    {
        private int v_id;
        private string v_screenlmg;
        private string v_name;
        private DateTime v_time;
        private string v_clicknum;
        private string v_downloadnum;
        private string v_savepath;
        public int  V_Id
        {
            get { return this.v_id; }
            set { this.v_id = value; }
        }

        public string V_ScreenImg
        {
            get { return this.v_screenlmg; }
            set { this.v_screenlmg = value; }
        }

        public string V_Name
        {
            get { return this.v_name; }
            set { this.v_name = value; }
        }

        public DateTime V_Time
        {
            get { return this.v_time; }
            set { this.v_time = value; }
        }

        public string V_ClickNum
        {
            get { return this.v_clicknum; }
            set { this.v_clicknum = value; }
        }
        public string V_DownloadNum
        {
            get { return this.v_downloadnum; }
            set { this.v_downloadnum = value; }
        }
        public string V_Savepath
        {
            get { return this.v_savepath; }
            set { this.v_savepath = value; }
        }


    }
}
