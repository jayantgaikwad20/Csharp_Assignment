using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Index.aspx");
        }


        if (!Page.IsPostBack)
        // for first time condition !post  back
        // ensure that page is being first time or again
        {

            state_list.Items.Add("pune");
            state_list.Items.Add("mumbai");
            state_list.Items.Add("sangli");
            state_list.Items.Add("kolhapur");

        }
    }
   

    protected void submit_Click(object sender, EventArgs e)
    {
       
        string uname = username_lb.Text;
        string pass =passname_lb.Text;
        string fname =firstname_lb.Text;
        string lname =lastname_lb.Text ;
        string addr =add_lb.Text;
        string state =state_list.SelectedValue.ToString();
        string no =no_lb.Text;
        string birth = date.Text.ToString();
        string message = remark_lb.InnerText;
        DAL d = new DAL();
        bool result = d.insertData(uname, pass, fname, lname, addr, state, no, birth, message);
        if (result==true)
        {
            insert_label.Text = "Data Inserted Successfully!!!";
        }
        else
        {
            insert_label.Text = "Data not Inserted !!!";
        }
    }






  
}

