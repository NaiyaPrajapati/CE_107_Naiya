using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab6_student
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            string sid = TextBox1.Text;
            string name = TextBox2.Text;
            int sem = Int32.Parse(TextBox3.Text);
            string mob = (TextBox4.Text);
            string email = TextBox5.Text;
            try
            {
                using (con)
                {
                    string command = "UPDATE student SET name='" + name + "',sem='" + sem + "',mobile_no='" + mob + "',email='" + email + "' WHERE id='" + sid + "'";
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
            string sid = TextBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;

            try
            {

                using (con)
                {
                    string command = "SELECT * FROM student WHERE id=" + sid;
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //int res = cmd.ExecuteNonQuery();

                    while (rdr.Read())
                    {

                        TextBox2.Text = rdr["name"].ToString();
                        TextBox3.Text = rdr["sem"].ToString();
                        TextBox4.Text = rdr["mobile_no"].ToString();
                        TextBox5.Text = rdr["email"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                //Response.Write(err.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("show.aspx");
        }
    }
}