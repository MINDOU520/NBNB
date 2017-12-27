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
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "ckfinder/";  //设置CKFinder的基路径  
            fileBrowser.SetupCKEditor(txtContent);
        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtContent.Text))
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入信息后再点击！');</script>");
            }
            else
            {
                Model.Tiezi ns = new Model.Tiezi();
                if (Session["user"] != null)
                {
                    Users user = (Users)Session["user"];

                    ns.UserId = user.UserId;
                }
                ns.T_Time = System.DateTime.Now;
                ns.T_Content = txtContent.Text;
                if (TieziManager.AddTiezi(ns) == 1)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('新闻上传成功！');</script>");
                    Response.Redirect("Luntan.aspx");
                }
            }

        }
    }
}
