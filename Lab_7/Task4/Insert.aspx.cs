using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb8_Task4
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insert_Details(object sender, EventArgs e)
        {
            using (studentDataContext dbcontext = new studentDataContext())
            {
                student stud = new student
                {
                    name = Name.Text,
                    sem = Convert.ToInt32(Sem.Text),
                    cpi = Convert.ToInt32(CPI.Text),
                    contact_no = Convert.ToDecimal(ContactNo.Text),
                    email_id = Email.Text
                };

                dbcontext.students.InsertOnSubmit(stud);
                dbcontext.SubmitChanges();
                Label1.Text = "Data Inserted Successfully!";
            }
        }

        protected void Update_Details(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }

        protected void Delete_Details(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx");
        }

        protected void Show_Details(object sender, EventArgs e)
        {
            Response.Redirect("Show.aspx");
        }

    }
}