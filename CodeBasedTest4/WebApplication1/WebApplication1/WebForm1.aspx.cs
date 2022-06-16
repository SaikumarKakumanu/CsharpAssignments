using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Audi", "BMW", "Jeep", "Tata" };
                for(int i=0; i<str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Pics/" + str + ".jfif";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text=DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Audi")
            {
                TextBox1.Text = "Rs. 50Lacks";
            }
            else if(DropDownList1.Text == "BMW")
            {
                TextBox1.Text = "Rs. 1cr";
            }
            else if (DropDownList1.Text == "Jeep")
            {
                TextBox1.Text = "Rs.20,00,000";
            }
            else if (DropDownList1.Text == "Tata")
            {
                TextBox1.Text = "Rs. 10,00,000";
            }
            else
            {
                TextBox1.Text = " ";
            }
        }
    }
}