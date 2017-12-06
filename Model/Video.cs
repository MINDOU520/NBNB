using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video
    {
        public string V_Id
        {
            get { return this.V_Id; }
            set { this.V_Id= value; }
        }

        public string V_ScreenImg
        {
            get { return this.V_ScreenImg; }
            set { this.V_ScreenImg = value; }
        }

        public string V_Name
        {
            get { return this.V_Name; }
            set { this.V_Name = value; }
        }

        public string V_Time
        {
            get { return this.V_Time; }
            set { this.V_Time = value; }
        }

        public string V_ClickNum
        {
            get { return this.V_ClickNum; }
            set { this.V_ClickNum = value; }
        }
        public string V_DownloadNum
        {
            get { return this.V_DownloadNum; }
            set { this.V_DownloadNum = value; }
        }
        public string V_Savepath
        {
            get { return this.V_Savepath; }
            set { this.V_Savepath = value; }
        }


    }
}
