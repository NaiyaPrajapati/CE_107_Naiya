using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            String uname = username.Text;
            String pwd = password.Text;
            if(uname.Equals("admin") && pwd.Equals("admin"))
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Lbl1.Text = "Incorrect credentials";
            }


        }
    }
}