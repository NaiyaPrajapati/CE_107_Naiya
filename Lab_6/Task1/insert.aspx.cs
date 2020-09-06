using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab6_student
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn1_Click(object sender,EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "INSERT INTO student(id,name,sem,mobile_no,email)VALUES(@id,@name,@sem,@mobile_no,@email)";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id",id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@sem", Int32.Parse(sem.Text));
                    cmd.Parameters.AddWithValue("@mobile_no", Int64.Parse(mobile_no.Text));
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    int res = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
            }
            Response.Redirect("show.aspx");
        }
    }
}