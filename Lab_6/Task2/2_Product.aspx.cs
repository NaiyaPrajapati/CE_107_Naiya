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
    public partial class _2_Product : System.Web.UI.Page
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
            SqlDataAdapter Adp = new SqlDataAdapter("select pname,cost from product", con);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();

            SqlDataAdapter Adp1 = new SqlDataAdapter("select pname from product", con);
            DataSet myDataSet = new DataSet();
            Adp1.Fill(myDataSet, "product");

            DataTable myDataTable = myDataSet.Tables[0];
            DataRow tempRow = null;
            foreach (DataRow tempRow_Variable in myDataTable.Rows)
            {

                tempRow = tempRow_Variable;

                ListBox1.Items.Add((tempRow["pname"].ToString()));

            }
            return Dt;
        }


        protected void ListBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    ListBox2.Items.Add(new ListItem(item.Text));

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach (ListItem item in ListBox2.Items)
            {
                int pid = 0;

                // lb3.Items.Add(new ListItem(item.Value, item.Text));
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;
                    using (con)
                    {
                        string command = "SELECT pid from product where pname='" + item.Text + "'";
                        SqlCommand cmd = new SqlCommand(command, con);
                        con.Open();

                        SqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {

                            pid = int.Parse(rdr["pid"].ToString());
                        }
                        //con.Close();
                    }
                }
                catch (Exception err) { Response.Write(err.Message); }
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = WebConfigurationManager.ConnectionStrings["contest"].ConnectionString;

                    using (con)
                    {
                        string command1 = "INSERT INTO [order](uid,pid)VALUES(@uid,@pid)";
                        SqlCommand cmd1 = new SqlCommand(command1, con);
                        con.Open();
                        cmd1.Parameters.AddWithValue("@uid", uid);
                        cmd1.Parameters.AddWithValue("@pid", pid);

                        int res = cmd1.ExecuteNonQuery();
                    }
                }
                catch (Exception err)
                {
                    Response.Write(err.Message);
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("2_Order.aspx");
        }
    }
}