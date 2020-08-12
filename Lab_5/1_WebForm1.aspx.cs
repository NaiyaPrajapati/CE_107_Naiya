using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CE107_Task1
{
    public partial class _1_WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("myCookie");
            myCookie["Name"] = TextBox1.Text;
            myCookie["Password"] = TextBox2.Text;
            myCookie.Expires = System.DateTime.Now.AddYears(1);
            Response.Cookies.Add(myCookie);
            Response.Redirect("1_WebForm2.aspx");

        }
    }
}