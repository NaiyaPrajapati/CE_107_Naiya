using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb5
{
    public partial class _2_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Naiya" && password.Text == "Naiya")
            {
                Session["username"] = username.Text;
                Response.Redirect("2_Home.aspx");
            }
            else
            {
                Lbl1.Text = "Username or password are invalid!";
            }
        }
    }
}