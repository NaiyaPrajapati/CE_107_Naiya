using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb8_Task4
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insert_Details(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("Update_dets.aspx");
        }

        protected void Delete_Details(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx");
        }

    }
}