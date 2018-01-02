using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddTiezi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["role"].ToString() != "3")
            {
                Session["callerh"] = Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect("login.aspx");
            }
            if (Session["M_Name"] == null || Session["role"].ToString() != "3")
            {
                Session["callerh"] = Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect("ManagerLogin.aspx");
            }

            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "../ckfinder/";  //设置CKFinder的基路径  
            fileBrowser.SetupCKEditor(txtContent);
        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Tiezi ns = new Model.Tiezi();
            ns.UserId= Convert.ToInt32(Session["userid"].ToString());
            ns.T_Time = System.DateTime.Now;
            ns.T_Content = txtContent.Text;
            try
            { 
             if (TieziManager.AddTiezil(ns) == 1)
            {
                txtContent.Text= "";
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('添加成功！');</script>");
            }
            else
            { Page.ClientScript.RegisterClientScriptBlock(typeof(object), "alert", "<script>alert('添加失败！');</script>"); }

            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex.Message);
            }

        }

    }
    }

