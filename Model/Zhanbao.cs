using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public  class Zhanbao
    {
        public string Z_Id
        {
            get { return this.Z_Id; }
            set { this.Z_Id = value; }
        }

        public DateTime Z_Time
        {
            get { return this.Z_Time; }
            set { this.Z_Time = value; }
        }

        public string Z_Title
        {
            get { return this.Z_Title; }
            set { this.Z_Title = value; }
        }

        public string Z_Content
        {
            get { return this.Z_Content; }
            set { this.Z_Content = value; }
        }
    }
}
