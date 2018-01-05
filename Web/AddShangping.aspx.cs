using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddShangping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "ckfinder/";  //设置CKFinder的基路径  
            fileBrowser.SetupCKEditor(txtContent);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请输入信息后再点击！');</script>");
            }
            else
            {
                Model.Commodity ns = new Model.Commodity();
                ns.C_Name = TextBox1.Text.Trim();
                ns.C_Price = TextBox2.Text.Trim();
                ns.C_Color = TextBox3.Text.Trim();
                ns.C_Kucun = TextBox4.Text.Trim();
                ns.C_Size = TextBox5.Text.Trim();
                ns.C_Biaoshi = TextBox6.Text.Trim();
                ns.C_Content = txtContent.Text.Trim();

                try
                {
                    if (FileUpload1.HasFile)
                    {
                        string filePath = FileUpload1.PostedFile.FileName;
                        string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                        string serverpath = Server.MapPath(@"img\") + filename;
                        string relativepath = @"img\" + filename;
                        FileUpload1.PostedFile.SaveAs(serverpath);
                        ns.C_Photo = relativepath;
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传商品图片！');</script>");
                        return;
                    }

                    if (CommodityManager.publishShangping(ns) == 1)
                    {

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
}