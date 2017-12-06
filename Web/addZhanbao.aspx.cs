using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
        public partial class addZhanbao : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
                fileBrowser.BasePath = "ckfinder/";  //设置CKFinder的基路径  
               fileBrowser.SetupCKEditor(txtContent);
        }

            protected void btnNoticeUp_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtContent.Text))
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入信息后再点击！');</script>");
                }
                else
                {
                    Model.Zhanbao ns = new Model.Zhanbao();
                    ns.Z_Title = txtTitle.Text;
                    ns.Z_Time = System.DateTime.Now;
                    ns.Z_Content = txtContent.Text;
                    if (ZhanbaoManager.AddZhanbao(ns) == 1)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('新闻上传成功！');</script>");
                        Response.Redirect("Zhanbao.aspx");
                    }
                }

            }
        }
    }