using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb6_1
{
    public partial class _2_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            string pwd = TextBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;

            try
            {

                using (con)
                {
                    string command = "SELECT * FROM [user] WHERE uid=@uid and pwd=@pwd";
                    SqlCommand cmd = new SqlCommand(command, con);

                    //SqlDataReader rdr = cmd.ExecuteReader();
                    //int res = cmd.ExecuteNonQuery();
                    SqlParameter p1 = new SqlParameter("@uid", TextBox1.Text);
                    SqlParameter p2 = new SqlParameter("@pwd", TextBox2.Text);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    con.Open();

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        Session["uid"] = id;
                        Response.Redirect("2_Product.aspx");

                    }
                    else
                    {
                        Response.Write("Invalid");
                    }
                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }

        }
    }
}