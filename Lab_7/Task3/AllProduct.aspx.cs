﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb8_Task3
{
    public partial class AllProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}