using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lb5
{
    public partial class _2_Home : System.Web.UI.Page
    {

        IDictionary<string, int> electronics = new Dictionary<string, int>();
        IDictionary<string, int> books = new Dictionary<string, int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Welcome.Text = "Welcome " + Session["username"];
            }
            if (electronics.Count == 0)
            {
                electronics.Add("Desktop", 30000);
                electronics.Add("Laptop", 70000);
                electronics.Add("SSD-512",5000);
                electronics.Add("Oneplus 7pro", 55000);
                electronics.Add("Television", 40000);
                electronics.Add("Game setup", 120000);
                electronics.Add("Amazone Echo dot 3", 5000);
            }
            if (books.Count == 0)
            {
                books.Add("Herry Potter",2000);
                books.Add("The Screte", 500);
                books.Add("Little Women",1000);
                books.Add("The lord of the rings", 500);
                books.Add("Fault in our stars", 250);
                books.Add("Krishnayan",5000);
            }
        }

        protected void List_Change(object sender, EventArgs e)
        {
            ListOfItems.Items.Clear();
            string section = Radio.SelectedItem.Text;
            ListOfItems.SelectionMode = ListSelectionMode.Multiple;
            if (section == "Electronics")
            {
                foreach (KeyValuePair<string, int> i in electronics)
                {
                    ListOfItems.Items.Add(String.Format("{0}", i.Key));
                }
            }
            if (section == "Books")
            {
                foreach (KeyValuePair<string, int> i in books)
                {
                    ListOfItems.Items.Add(String.Format("{0}", i.Key));
                }

            }
        }

        protected void CheckOut(object sender, EventArgs e)
        {
            Dictionary<string, int> SelectedItems = new Dictionary<string, int>();
            Dictionary<string, int> section;
            if (Radio.SelectedItem.Text == "Books")
            {
                section = (Dictionary<string, int>)books;
            }
            else
            {
                section = (Dictionary<string, int>)electronics;
            }
            for (int i = 0; i < ListOfItems.Items.Count; i++)
            {
                if (ListOfItems.Items[i].Selected)
                {
                    SelectedItems.Add(ListOfItems.Items[i].Text, section[ListOfItems.Items[i].Text]);
                }
            }
            Session["Purchase"] = SelectedItems;
            Response.Redirect("2_Order.aspx");
        }
    }
}