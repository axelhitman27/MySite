using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SharkSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = GetData();
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = GetData();
            GridView1.DataBind();
        }

        private DataTable GetData()
        {
            var dataDT = new DataTable();
            dataDT.Columns.Add("Firstname");
            dataDT.Columns.Add("Lastname");
            dataDT.Columns.Add("Email");

            dataDT.Rows.Add("John", "Doe", "john@example.com");
            dataDT.Rows.Add("Mary", "Moe", "mary @example.com");
            dataDT.Rows.Add("July", "Dooley", "july@example.com");

            return dataDT;
        }
    }
}