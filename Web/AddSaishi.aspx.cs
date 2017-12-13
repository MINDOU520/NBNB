using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AddSaishi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["sid"] = Convert.ToInt32(Request.QueryString["id"]);
            }
            BindsaishiDetail();
            
        }
        private void BindsaishiDetail()
        {
            int nid = Convert.ToInt32(ViewState["sid"]);
            DataTable dt = BLL.SaishiManager.SelectID(nid);
            if (dt != null && dt.Rows.Count == 1)
            {
                txtname.Text = dt.Rows[0][2].ToString();
                txttime.Text =  dt.Rows[0][3].ToString();
                txtadder.Text = dt.Rows[0][4].ToString();
                //Label1.Text = DateTime.Now.ToString("yyyy-MM-dd:HH:mm");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = System.DateTime.Now.ToShortDateString();
            if (this.IsValid)
            {
                string strCnn = ConfigurationManager.ConnectionStrings["NBNB"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCnn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string s_name= txtname.Text.Trim();
                string s_time = txttime.Text.Trim();
                string  s_adder= txtadder.Text.Trim();

          
                cmd.CommandText = "insert into  Saishi(s_name,s_time,s_adder)values('" + s_name+ "','" + s_time + "','" + s_adder + "')";
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    Label2.Text = "赛事发布成功！";
                }
                catch (Exception ex)
                {
                    Label2.Text = "赛事发布失败，错误原因：" + ex.Message;
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }

        
    }
    }