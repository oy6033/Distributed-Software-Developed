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
    public partial class TryAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string geturl = this.TextBox11.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page9/Service1.svc/wordfiter?str=" + geturl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            this.TextBox12.Text = reader.ReadToEnd();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string geturl = this.TextBox9.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page9/Service1.svc/getTop10word?url=" + geturl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            this.TextBox10.Text = reader.ReadToEnd();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string geturl = this.TextBox1.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page7/Service1.svc/Top10ContentWords?url=" + geturl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            char[] delimiterChars = { ',' };
            string[] words = reader.ReadToEnd().Split(delimiterChars);
            string x = "";
            foreach (string word in words)
            {
                x = word + "\r\n" + x;
            }
            x = x.Replace("\"", "");
            this.TextBox2.Text = x;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string getzip = this.TextBox3.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page7/Service1.svc/FindLatLon?zipcode=" + getzip;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string[] parts = reader.ReadLine().Replace("[", "").Replace("]", "").Split(',');
            TextBox4.Text = parts[0];
            TextBox5.Text = parts[1];
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string geturl = this.TextBox8.Text;
            string url = "http://" + "webstrar36.fulton.asu.edu/page7/Service1.svc//countWords?url=" + geturl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            TextBox7.Text = reader.ReadToEnd();
        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}