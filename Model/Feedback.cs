using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Feedback
    {
        private string fb_id;                    //111
        private string userid;                   //111
        private string f_content;                //111
        private DateTime f_time;                 //111
        private string return_content;           //111
        private DateTime return_time;            //111

        public string FB_Id
        {
            get { return this.fb_id; }
            set { this.fb_id = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public string F_Content
        {
            get { return this.f_content; }
            set { this.f_content = value; }
        }
        public DateTime F_Time
        {
            get { return this.f_time; }
            set { this.f_time = value; }
        }
        public string Return_Content
        {
            get { return this.return_content; }
            set { this.return_content = value; }
        }
        public DateTime Return_Time
        {
            get { return this.return_time; }
            set { this.return_time = value; }
        }

    }
}
