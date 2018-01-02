using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Luntan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTiezi();
            }
        }

        private void BindTiezi()
        {
            DataTable dt = BLL.TieziManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                TieziListView.DataSource = dt;
                TieziListView.DataBind();
            }


        }
    }
}