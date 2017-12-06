using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuqi.Webdiyer;

namespace Web
{
    public partial class lanqiu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCommodity();
                dlBind();
            }
        }

        private void dlBind()
        {
            int curpage = Convert.ToInt32(this.Label7.Text);
            PagedDataSource ps = new PagedDataSource();
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NBNB"].ConnectionString);
            SqlDataAdapter oda = new SqlDataAdapter("select * from Commodity", con);
            DataSet ds = new DataSet();
            oda.Fill(ds);//这里是数据源

            ps.DataSource = ds.Tables[0].DefaultView;
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 10; //显示的数量
            ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
            this.LinkButton3.Enabled = true;
            this.LinkButton4.Enabled = true;
            this.LinkButton5.Enabled = true;
            this.LinkButton2.Enabled = true;
            if (curpage == 1)
            {
                this.LinkButton2.Enabled = false;//不显示第一页按钮
                this.LinkButton3.Enabled = false;//不显示上一页按钮
            }
            if (curpage == ps.PageCount)
            {
                this.LinkButton4.Enabled = false;//不显示下一页
                this.LinkButton5.Enabled = false;//不显示最后一页
            }
            this.Label2.Text = Convert.ToString(ps.PageCount);
            this.DataList1.DataSource = ps;
            this.DataList1.DataKeyField = "c_id";
            this.DataList1.DataBind();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)  //第一页
        {
            this.Label7.Text = "1";   //Label7.Text为当前页
            this.dlBind();
        }
        protected void LinkButton3_Click(object sender, EventArgs e) //上一页
        {
            this.Label7.Text = Convert.ToString(Convert.ToInt32(this.Label7.Text) - 1);
            this.dlBind();
        }
        protected void LinkButton4_Click(object sender, EventArgs e)  //下一页
        {
            this.Label7.Text = Convert.ToString(Convert.ToInt32(this.Label7.Text) + 1);
            this.dlBind();
        }
        protected void LinkButton5_Click(object sender, EventArgs e)  //最后一页
        {
            this.Label7.Text = this.Label2.Text; //Label2.Text为总页数
            this.dlBind();
        }

        private void BindCommodity()
        {
            DataTable dt = CommodityManager.SelectTop6();
            if (dt != null && dt.Rows.Count != 0)
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }
     
    }
}
