using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string geturl = this.TextBox1.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page7/Service1.svc/Top10ContentWords?url=" + geturl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            char[] delimiterChars = {','};
            string[] words = reader.ReadToEnd().Split(delimiterChars);
            string x = "";
            foreach(string word in words)
            {
                x = word +"\r\n" + x;
            }
            x = x.Replace("\"", "");
            this.TextBox2.Text = x;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

 


    }
}