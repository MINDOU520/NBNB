using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Video ns = new Model.Video();
            ns.V_Name = TextBox1.Text.Trim();
            ns.V_Time = System.DateTime.Now;
            try
            {
                if (FileUpload1.HasFile)
                {
                    string filePath = FileUpload1.PostedFile.FileName;
                    string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath(@"img\") + filename;
                    string relativepath = @"img\" + filename;
                    FileUpload1.PostedFile.SaveAs(serverpath);
                    ns.V_ScreenImg = relativepath;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传封面照！');</script>");
                    return;
                }
            }
            catch (Exception ex)
            {
                Response.Write("错误原因：" + ex.Message);
            }
            try
            {
                if (FileUpload2.HasFile)
                {
                    string filePath = FileUpload2.PostedFile.FileName;
                    string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath(@"Video\") + filename;
                    string relativepath = @"Video\" + filename;
                    FileUpload2.PostedFile.SaveAs(serverpath);
                    ns.V_Savepath = relativepath;
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('请先上传视频文件！');</script>");
                    return;
                }
                if (VideoManager.publishVideo(ns) == 1)
                {
                    TextBox1.Text = "";
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