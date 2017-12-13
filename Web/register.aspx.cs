using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security;
using Model;
using BLL;

namespace Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                string strCnn = ConfigurationManager.ConnectionStrings["NBNB"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCnn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string username = txtuserName.Text.Trim();
                string userpassword = txtuserPassword.Text.Trim();
                cmd.CommandText = "insert into Users(username,userpassword)values(N'" + username + "','" + userpassword + "')";
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    Label1.Text = "用户添加成功！";
                }
                //catch (Exception ex)
                //{
                //    Label1.Text = "用户添加失败，错误原因：" + ex.Message;
                //}
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }
            //if (IsValid)
            //{
            //    try
            //    {
            //        Users us = new Users();
            //        us.UserName = txtuserName.Text;
            //        us.UserPassword = txtuserPassword.Text;
                   
            //        int i = UserManager.AddUser(us);
            //        if (i == 1)
            //        {
            //            Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('注册成功！');</script>");
            //            Response.Redirect("~/index.aspx");
            //        }

            //    }
                //catch
                //{
                //    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('注册失败！');</script>");
                //}
                //finally
                //{
                   
                //}
            }
        }
