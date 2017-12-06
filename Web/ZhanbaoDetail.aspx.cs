using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ZhanbaoDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
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
            }
            BindNewDetail();
            BindElseNews();
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
    }
}
  