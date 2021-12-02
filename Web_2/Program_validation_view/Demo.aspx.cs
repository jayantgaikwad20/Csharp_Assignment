using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            // for first time condition !post  back
            // ensure that page is being first time or again
        {

            DropDownList1.Items.Add("pune");
            DropDownList1.Items.Add("mumbai");
            DropDownList1.Items.Add("sangli");
            DropDownList1.Items.Add("kolhapur");

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "Selected City is " + DropDownList1.SelectedValue.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Selected City is " + DropDownList1.SelectedValue.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      //  Request.QueryString["data"]= DropDownList1.SelectedValue.ToString();
        Response.Redirect("Demo2.aspx?data="+ DropDownList1.SelectedValue.ToString());
    }
}