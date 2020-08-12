﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb5
{
    public partial class _2_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Purchase"] != null)
            {
                Dictionary<string, int> cart = (Dictionary<string, int>)Session["Purchase"];
                int amount = 0;
                foreach (KeyValuePair<string, int> i in cart)
                {
                    Label1.Text += i.Key + ":        " + i.Value + " Rs<br/>";
                    amount += i.Value;
                }
                Label1.Text += "<br/>Total amount:        " + amount + " Rs";
                Session.Abandon();
            }
            else
            {
                Label1.Text = "You haven't made any purchases!";
            }
        }
    }
}