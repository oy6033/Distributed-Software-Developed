using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label2.Text = "show password here";
            this.Label1.Text = "show Id here";
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            string password = proxy.password(this.TextBox1.Text, this.TextBox2.Text, Convert.ToInt32(this.TextBox3.Text));
            int ID = proxy.loginId(Convert.ToInt32(this.TextBox3.Text));
            this.Label2.Text = password;
            this.Label1.Text = ID.ToString();
        }
    }
}