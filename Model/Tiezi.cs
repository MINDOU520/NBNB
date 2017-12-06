using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Tiezi
    {
        private string t_id;                //帖子编号
        private string userid;              //用户编号
        private DateTime t_time;            // 帖子时间
        private string t_viewnum;           //
        private string t_c_id;              //帖子评论编号
        private string t_commentnum;        //帖子评论数
        private string t_dianzannum;        //帖子点赞数
        private string t_zhuanfanum;        //帖子转发数
        private string p_id;                //图片编号
        private string v_id;                //视频编号

        public string T_Id
        {
            get { return this.t_id; }
            set { this.t_id = value; }
        }
        public string UserId
        {
            get { return this.userid; }
            set { this.userid = value; }
        }
        public DateTime T_Time
        {
            get { return this.t_time; }
            set { this.t_time = value; }
        }
        public string T_ViewNum
        {
            get { return this.t_viewnum; }
            set { this.t_viewnum = value; }
        }
        public string T_C_Id
        {
            get { return this.t_c_id; }
            set { this.t_c_id = value; }
        }
        public string T_CommentNum
        {
            get { return this.t_commentnum; }
            set { this.t_commentnum = value; }
        }
        public string T_DianzanNum
        {
            get { return this.t_dianzannum; }
            set { this.t_dianzannum = value; }
        }
        public string T_ZhuanfaNum
        {
            get { return this.t_zhuanfanum; }
            set { this.t_zhuanfanum = value; }
        }
        public string P_Id
        {
            get { return this.p_id; }
            set { this.p_id = value; }
        }
        public string V_Id
        {
            get { return this.v_id; }
            set { this.v_id = value; }
        }
        
    }
}
