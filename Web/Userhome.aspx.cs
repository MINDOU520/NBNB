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
    public partial class Userhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            
                BindUser();
            }

        }

     

        private void BindUser()
        {

            if (Session["UserId"] != null && (int)Session["UserId"] != 0)
            {
                DataTable dt = UserManager.SelectID((int)Session["UserId"]);

                if (dt != null && dt.Rows.Count != 0)
                {
                    DataList1.DataSource = dt;
                    DataList1.DataBind();
                }
            }

          
        }
    }
}