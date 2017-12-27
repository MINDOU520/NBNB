using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Zhanbao : System.Web.UI.Page
    {
        bool isDataPager = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["caller"] = Request.AppRelativeCurrentExecutionFilePath;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (isDataPager)
            {
                BindZhanbao();
            }
        }
        private void BindZhanbao()
        {
            DataTable dt = BLL.ZhanbaoManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                NewsListView.DataSource = dt;
                NewsListView.DataBind();
            }
        }

       
    }
}