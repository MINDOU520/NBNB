using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Shangcheng : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindlanqiu();
                Bindqiufu();
                Bindhuju();
                Bindqiuxie();
                Bindother();
            }
        }

        private void Bindqiufu()
        {
            DataTable dt = BLL.CommodityManager.SelectqiufuTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        private void Bindqiuxie()
        {
            DataTable dt = BLL.CommodityManager.SelectqiuxieTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void Bindlanqiu()
        {
            DataTable dt = BLL.CommodityManager.SelectlanqiuTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        private void Bindhuju()
        {
            DataTable dt = BLL.CommodityManager.SelecthujuTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView4.DataSource = dt;
                ListView4.DataBind();
            }
        }
        private void Bindother()
        {
            DataTable dt = BLL.CommodityManager.SelectotherTop4();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView5.DataSource = dt;
                ListView5.DataBind();
            }
        }
    }
}