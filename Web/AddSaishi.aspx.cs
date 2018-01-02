using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Web
{
    public partial class AddSaishi : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["role"].ToString() != "3")
            {
                Session["callerh"] = Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect("login.aspx");
            }
            //if (!IsPostBack)
            //{
            //    ViewState["sid"] = Convert.ToInt32(Request.QueryString["id"]);
            //}
            //BindsaishiDetail();

        }
        //private void BindsaishiDetail()
        //{
        //    int nid = Convert.ToInt32(ViewState["sid"]);
        //    DataTable dt = BLL.SaishiManager.SelectID(nid);
        //    if (dt != null && dt.Rows.Count == 1)
        //    {
        //        txtname.Text = dt.Rows[0][2].ToString();
        //        txttime.Text = dt.Rows[0][3].ToString();
        //        txtadder.Text = dt.Rows[0][4].ToString();
        //        //Label1.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm");
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Saishi ns= new Model.Saishi();

            ns.S_Name= txtname.Text.Trim();
            ns.UserId = Convert.ToInt32(Session["userid"].ToString());
            ns.S_Time = txttime.Text.Trim();
            ns.S_Adder = txtadder.Text.Trim();
            ns.S_Fabutime = System.DateTime.Now;
            try
            {
                if (SaishiManager.AddSaishi(ns) == 1)
                {
                  
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('添加成功！');</script>");
                }
                else
                { Page.ClientScript.RegisterClientScriptBlock(typeof(object), "alert", "<script>alert('添加失败！');</script>"); }

            }
            catch (Exception ex)
            {
                Label2.Text = "赛事发布失败，错误原因：" + ex.Message;
                }
        }
            //if (this.IsValid)
            //{
            //    string strCnn = ConfigurationManager.ConnectionStrings["NBNB"].ConnectionString;
            //    SqlConnection cnn = new SqlConnection(strCnn);
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = cnn;
            //    string s_name = txtname.Text.Trim();
            //    string s_time = txttime.Text.Trim();
            //    string s_adder = txtadder.Text.Trim();


            //    cmd.CommandText = "insert into  Saishi(s_name,s_time,s_adder)values('" + s_name + "','" + s_time + "','" + s_adder + "')";
            //    try
            //    {
            //        cnn.Open();
            //        cmd.ExecuteNonQuery();
            //        Label2.Text = "赛事发布成功！";
            //    }
            //    catch (Exception ex)
            //    {
            //        Label2.Text = "赛事发布失败，错误原因：" + ex.Message;
            //    }
            //    finally
            //    {
            //        if (cnn.State == ConnectionState.Open)
            //            cnn.Close();
            //    }

            //}
        }


    }
