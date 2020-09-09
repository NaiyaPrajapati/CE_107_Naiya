using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb8_Task4
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Delete_Details(object sender, EventArgs e)
        {
            using (studentDataContext dbcontext = new studentDataContext())
            {
                student stud = dbcontext.students.SingleOrDefault(x => x.sid == Convert.ToInt32(Sid.Text));
                dbcontext.students.DeleteOnSubmit(stud);
                dbcontext.SubmitChanges();
                Label1.Text = "Data Deleted Successfully!";
            }
        }
        protected void Insert_Details(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }

        protected void Show_Details(object sender, EventArgs e)
        {
            Response.Redirect("Show.aspx");
        }

    }
}