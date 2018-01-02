using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ManagerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string M_Name= txtName.Text.Trim();
            string M_Password = txtPassword.Text.Trim();
            //获取验证码
            string checkCode = txtCheckcode.Text;
            try
            {
                if (Request.Cookies["checkCode"].Value == checkCode)
                {
                    SqlDataReader dr = ManagerManager.Login(M_Name, M_Password);
                    if (dr.Read())
                    {
                        Session["M_Id"] = dr[0];
                        Session["M_Name"] = dr[1].ToString();
                        Session["role"] = 3;
                        if (Session["callerh"] != null)
                        {
                            Response.Redirect(Session["callerh"].ToString());
                        }
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