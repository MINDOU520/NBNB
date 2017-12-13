using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Commodity
    {
        private int c_id;                                                    //商品ID
        private string c_name;                                              //商品名称
        private string c_photo;                                             //商品价格
        private string c_kucun;                                             //商品库存
        private string c_comment;                                           //商品评论
        private string c_commentnum;                                        //商品评论数目
        private string c_saled;                                             //商品出售
        private string c_viewnum;                                           //商品浏览数
        private string c_size;                                                //商品尺寸
        private string c_color;                                                   //商品颜色

        public int C_Id
        {
            get { return this.c_id; }
            set { this.c_id = value; }
        }
        public string C_Name
        {
            get { return this.c_name; }
            set { this.c_name = value; }
        }
        public string C_Price
        {
            get { return this.c_photo; }
            set { this.c_photo = value; }
        }
        public string C_Photo
        {
            get { return this.c_photo; }
            set { this.c_photo = value; }
        }
        public string C_Kucun
        {
            get { return this.c_kucun; }
            set { this.c_kucun = value; }
        }
        public string C_Comment
        {
            get { return this.c_comment; }
            set { this.c_comment = value; }
        }
        public string C_CommentNum
        {
            get { return this.c_commentnum; }
            set { this.c_commentnum = value; }
        }
        public string C_Saled
        {
            get { return this.c_saled; }
            set { this.c_saled = value; }
        }
        public string C_ViewNum
        {
            get { return this.c_viewnum; }
            set { this.c_viewnum = value; }

        }
        public String C_Size
        {
           get { return this.c_size; }
            set { this.c_size = value; }
        }
        public string C_Color
        {
            get { return this.c_color; }
            set { this.c_color = value; }
        }
    }
}
