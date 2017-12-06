using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Photos
    {
        private string p_id;                 //图片编号
        private string p_name;               //图片名字
        private string p_description;          //图片描述
        private string p_savepath;             //图片存储路径

        public string P_Id
        {
            get { return this.p_id; }
            set { this.p_id = value; }
        }
        public string P_Name
        {
            get { return this.p_name; }
            set { this.p_name = value; }
        }
        public string P_Description
        {
            get { return this.p_description; }
            set { this.p_description = value; }
        }
        public string P_SavePath
        {
            get { return this.p_savepath; }
            set { this.p_savepath = value; }
        }
    }
}
