using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class TieziDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int tid = Convert.ToInt32(Request.QueryString["id"]);
                ViewState["tid"] = tid;
             }
            BindTieziDetail();    
            }

        

        private void BindTieziDetail()
        {
            int tid = Convert.ToInt32(ViewState["tid"]);
            DataTable dt = BLL.TieziManager.SelectID(tid);
            if (dt != null && dt.Rows.Count != 0)
            {
               
                Literal1.Text = dt.Rows[0][3].ToString();
            }
        }
    }

      

    }
