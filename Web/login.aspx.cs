using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Configuration;
using Model;
using BLL;
namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text.Trim();
            string UserPassword = txtPassword.Text.Trim();
            //获取验证码
            string checkCode = txtCheckcode.Text;
            try
            {
                if (Request.Cookies["checkCode"].Value == checkCode)
                {
                    SqlDataReader dr = UserManager.Login(UserName, UserPassword);
                    if (dr.Read())
                    {
                        Session["UserName"] = dr[0].ToString();
                        Response.Redirect("~/index.aspx");
                    }
                    else
                    {
                        label1.Text = "用户名或密码错误！";
                    }

                }
                else
                {
                    label1.Text = "验证码输入有误!";
                }
            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex.Message);
            }
        }
    }
}