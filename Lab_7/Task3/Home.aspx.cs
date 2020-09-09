using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb8_Task3
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (pid.Text != "")
            {
                Response.Redirect("Products.aspx?pid=" + pid.Text);
            }
            else
            {
                Label1.Text = "Please enter product id!";
            }
        }
    }
}