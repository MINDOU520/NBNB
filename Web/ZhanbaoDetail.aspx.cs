using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Model;
using BLL;

namespace Web
{
    public partial class ZhanbaoDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            //{
            //    ViewState["HFood_id"] = Convert.ToInt32(Request.QueryString["id"]);
            //    ViewState["Users_id"] = Convert.ToInt32(Request.QueryString["id"]);
            //}

            //BindNewDetail();
            //BindElseNews();
            //ListView1();



            //int id;

            //if (Request.QueryString["id"] != null)
            //{
            //    id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            //    DataTable dt= NewsManager.SelectID(id);
            //    if (dt != null && dt.Rows.Count != 0)
            //    {
            //        lbl1.Text = dt.Rows[0][1].ToString();
            //        lbl2.Text = dt.Rows[0][2].ToString();
            //        lt1.Text = dt.Rows[0][3].ToString();
            //    }
            //}

            if (!IsPostBack)
            {
                ViewState["nid"] = Convert.ToInt32(Request.QueryString["id"]);

                BindNewDetail();
                BindElseNews();
                ListView1();
            }
            //BindNewDetail();
            //BindElseNews();
            //ListView1();
        }
        private void BindNewDetail()
        {
            int nid = Convert.ToInt32(ViewState["nid"]);
            DataTable dt = BLL.ZhanbaoManager.SelectID(nid);
            if (dt != null && dt.Rows.Count == 1)
            {
                txtNTitle.Text = dt.Rows[0][1].ToString();
                txtCreateTime.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][2]);
                txtNContent.Text = dt.Rows[0][3].ToString();
            }
            //int nid = Convert.ToInt32(ViewState["HFood_id"]);
            //DataTable dt = BLL.ZhanbaoManager.SelectID(nid);
            //if (dt != null && dt.Rows.Count == 1)
            //{
            //    Image1.ImageUrl = ResolveUrl(dt.Rows[0][4].ToString());

            //    txtNTitle.Text = dt.Rows[0][2].ToString();
            //    txtName.Text = dt.Rows[0][7].ToString();
            //    Createtime.Text = string.Format("{0:yyyy-MM-dd hh:mm}", dt.Rows[0][5]);
            //    Createtime2.Text = dt.Rows[0][6].ToString();
            //    txtContent.Text = dt.Rows[0][3].ToString();
            //}
        }

        private void BindElseNews()
        {
            DataTable dt = BLL.ZhanbaoManager.SelectTop(10);
            if (dt != null && dt.Rows.Count != 0)
            {
                ElseNewsListView.DataSource = dt;
                ElseNewsListView.DataBind();
            }
        }

        private void ListView1()
        {
            int nid = Convert.ToInt32(Request.QueryString["id"].ToString());
            DataTable dt = BLL.Z_CommentManager.SelectID(nid);
            if (dt != null && dt.Rows.Count != 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }

        protected void pinglun_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (Session["UserName"] != null)
            {
                try
                {
                    Model.Z_Comment CS = new Model.Z_Comment();
                    CS.Z_Id = Convert.ToInt32(Request.QueryString["ID"].ToString());
                    CS.UserId = int.Parse(Session["userid"].ToString());
                    CS.Z_C_Time = DateTime.Now;
                    CS.Z_C_Content = FCKeditor1.Text;
                    if (Z_CommentManager.addz_comment(CS) == 1)
                    {
                        FCKeditor1.Text = "";
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('评论成功！');", true);
                        ListView1();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('评论失败！');", true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("错误原因：" + ex.Message);
                }
            }
            else
            {

                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('对不起，请先登录！');", true);
            }
        }

        protected void BttLogin_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (Session["userName"] != null)
            {
                try
                {
                    Model.Z_Reply RS = new Model.Z_Reply();    
                    RS.Z_C_Id = Int32.Parse((bt.Parent.FindControl("HiddenField1") as HiddenField).Value);
                    RS.UserId = int.Parse(Session["userid"].ToString());
                    RS.Z_R_Time = DateTime.Now;
                    string str = (bt.Parent.FindControl("Texthuifu") as TextBox)?.Text.Trim();
                    RS.Z_R_Content = str;
                    if (Z_ReplyManager.addZ_Reply(RS) == 1)
                    {
                   
                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复成功！');", true);
                        ListView1();
                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('回复失败！');", true);

                    }

                }
                catch (Exception ex)
                {
                    Response.Write("错误原因：" + ex.Message);
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('对不起，请先登录！');", true);
            }

        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rpt = e.Item.FindControl("Repeater2") as Repeater;//找到里层的repeate;
                int id = Convert.ToInt32(((Label)e.Item.FindControl("Label3")).Text);
                DataTable sdr = Z_ReplyManager.SelectID(id);
                rpt.DataSource = sdr;
                rpt.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel pl = (bt.Parent.FindControl("Panel1") as Panel);
            pl.Visible = !pl.Visible;
        }
        protected string SplitChar(string sObj, int intLen)
        {
            if (sObj.Length > intLen)
            {
                return sObj.Substring(0, intLen) + "…";
            }
            return sObj;
        }
    }
}
  