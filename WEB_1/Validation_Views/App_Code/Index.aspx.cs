using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["hits"] == null)
        {
            Application["hits"] = 1;
            
        }
        else
        {
            int no = Convert.ToInt32(Application["hits"]);
            no++;
            Application["hits"]=no;
        }
        no_hits.Text = Application["hits"].ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        DAL d = new DAL();

        if (login_text.Text == "")
        {
            user_error.Text = "username can not be blank ! ";
        }

        else  if (pass_text.Text=="")
        {
            pass_error.Text = "Password can not be blank !";
        }

        else if (login_text.Text != "" && pass_text.Text != " ")
        {
            string login = login_text.Text;
            string pass = pass_text.Text;

            if (d.Login(login,pass))
            {
                Session["user"] = login;
                Response.Redirect("welcome.aspx");
            }
            else
            {
                user_error.Text = " ";
                pass_error.Text = " ";
                login_btn_error.Text = "Invalid Username or  Password !";
            }
        }
    }
}