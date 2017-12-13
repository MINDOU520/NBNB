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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindZhanbao();
                BindVideo();
            }
        }

        private void BindVideo()
        {
            DataTable dt = VideoManager.selectTop(4);
            if (dt != null && dt.Rows.Count != 0)
            {
                VideoTopListView.DataSource = dt;
                VideoTopListView.DataBind();
            }
        }

        private void BindZhanbao()
        {
            DataTable dt = ZhanbaoManager.SelectTop(5);
            if (dt != null && dt.Rows.Count != 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
    }
}
        
     
      
 