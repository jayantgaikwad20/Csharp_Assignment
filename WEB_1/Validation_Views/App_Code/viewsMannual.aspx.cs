using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

public partial class viewsMannual : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataSource ds = new SqlDataSource(WebConfigurationManager.ConnectionStrings["customConn"].ConnectionString,"select * from userTable");
        ds.ID = "customDs";
        GridView1.DataSourceID = "customDs";
        Page.Controls.Add(ds);
        GridView1.DataBind();
    }
}