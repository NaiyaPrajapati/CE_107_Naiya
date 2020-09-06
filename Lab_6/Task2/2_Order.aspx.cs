using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb6_1
{
    public partial class _2_Order : System.Web.UI.Page
    {
        int uid;
        protected void Page_Load(object sender, EventArgs e)
        {
            uid = int.Parse(Session["uid"].ToString());
            if (!IsPostBack)
            {
                DisplayRecord();
            }
        }
        public DataTable DisplayRecord()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
            SqlDataAdapter Adp = new SqlDataAdapter("select pname,cost from [product] where pid in (select pid from [order] where uid='" + uid + "')", con);
            SqlCommand cmd = new SqlCommand("select cost from [product] where pid in (select pid from [order] where uid='" + uid + "')", con);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            long sum = 0;
            while (rdr.Read())
            {

                sum = sum + int.Parse(rdr["cost"].ToString());
            }
            Label1.Text = sum.ToString();
            return Dt;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}