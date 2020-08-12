using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CE107_Task1
{
    public partial class _1_WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["myCookie"];
            if (c != null)
            {
                Label1.Text = "Cookie Available";
                Label2.Text = c["name"].ToString();
                Label3.Text = c["Password"].ToString();
            }
            else
            {
                Label1.Text = "Cookie Not Available";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["myCookie"].Expires = DateTime.Now.AddYears(-1);
        }
    }
}