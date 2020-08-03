using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                city.Items.Clear();
                state.Items.Clear();
                city.Items.Insert(0, new ListItem("Select City", "0"));
                state.Items.Insert(0, new ListItem("Select State", "0"));
                state.Items.Insert(1, new ListItem("Gujarat", "Gujarat"));
                state.Items.Insert(2, new ListItem("Maharastra", "Maharastra"));
            }

        }

       

        protected void btn1_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                fname1.Text = fname.Text;
                age1.Text = age.Text;
                gen1.Text = Gender.Text;
                m1.Text = Monum.Text;
                hobies1.Text = "";
                foreach (ListItem item in Hobbies.Items)
                {
                    if (item.Selected)
                    {
                        hobies1.Text = hobies1.Text + " " + item.Value;
                    }
                }
                S1.Text = state.SelectedValue;
                c1.Text = city.SelectedValue;
                pan1.Text = pannumber.Text.ToString();
                fname1.Visible = true;
                age1.Visible = true;
                gen1.Visible = true;
                m1.Visible = true;
                hobies1.Visible = true;
                S1.Visible = true;
                c1.Visible = true;
                pan1.Visible = true;
            }
            else
            {
                fname1.Visible = false;
                age1.Visible = false;
                gen1.Visible = false;
                m1.Visible = false;
                hobies1.Visible = false;
                S1.Visible = false;
                c1.Visible = false;
                pan1.Visible = false;

            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String PAN = args.Value.ToString();
            if (PAN.Length == 10 && (PAN.StartsWith("A") || PAN.StartsWith("B")))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void state_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (state.SelectedItem.Text == "Maharastra")
            {
                city.Items.Clear();
                city.Items.Add(new ListItem("Mumbai", "Mumbai"));
                city.Items.Add(new ListItem("Pune", "pune"));
            }
            else if (state.SelectedItem.Text == "Gujarat")
            {
                city.Items.Clear();
                city.Items.Add(new ListItem("Ahmedabad", "Ahmedabad"));
                city.Items.Add(new ListItem("Vadodara", "Vadodara"));
            }
            else
            {
                city.Items.Clear();
                city.Items.Add(new ListItem("Select City", "0"));
            }
        }
    }
}