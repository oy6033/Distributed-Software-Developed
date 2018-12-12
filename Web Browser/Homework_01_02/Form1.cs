using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Homework_01_02
{
    public partial class Form1 : Form
    {
        ServiceReference2.ServiceClient myClient_2 = new ServiceReference2.ServiceClient();
        string str;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "4";
           
        }

        private void go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient myClient = new ServiceReference1.ServiceClient();
            try
            {
                label3.Text = myClient.Encrypt(textBox2.Text);
            }
            catch(Exception excpetion)
            {
                label3.Text = excpetion.Message.ToString();
            }
            try
            {
                label5.Text = myClient.Decrypt(label3.Text);
            }
            catch(Exception excpetion)
            {
                label5.Text = excpetion.Message.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            str = myClient_2.GetVerifierString(textBox3.Text);
            pictureBox1.Image = Bitmap.FromStream(myClient_2.GetImage(str));

            if (button4.Text =="Show me Image String")
            {
                button4.Text = "Show me Antoher Image String";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (str != textBox4.Text)
            {
                label8.Text = "I am sorry, the string you entered does not match the image. Please try again!";
            }
            else
            {
                label8.Text = "Congratulation. The code you entered is correct!";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
