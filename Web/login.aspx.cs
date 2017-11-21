using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //string checkCode = Session["CheckCode"].ToString();
            //if (checkCode.ToLower() == TextBox3.Text || checkCode.ToUpper() == TextBox3.Text)
            //{
            //    Label1.Text = "验证码正确！";
            //}
            //else
            //{
            //    Label1.Text = "验证码错误！";
            //}
        }
    }
}