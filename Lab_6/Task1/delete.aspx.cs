using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab6_student
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            string sid = TextBox1.Text;
            try
            {
                using (con)
                {
                    string command = "DELETE student WHERE id='" + sid + "'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    int res = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("show.aspx");
        }
    }
}
