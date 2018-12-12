using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace CSE445_hw04_part_II
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string xmlValidation(string url)
        {
            string x = "1";
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                string localpath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
                settings.Schemas.Add(null, localpath + @"\HotelSchema.xsd");
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.IgnoreWhitespace = true;

                XmlReader hotel = XmlReader.Create(url, settings);
                XmlDocument document = new XmlDocument();
                document.Load(hotel);

                ValidationEventHandler eventHandler = new ValidationEventHandler(validate);
                // the following call to Validate succeeds.
                document.Validate(eventHandler);
                x = "No Error";
            }catch (Exception err)
            {
                x = err.Message;
            }

            return x;
        }

        public List<string> XpathSearch(string url, string path)
        {
            List<string> list = new List<string>();
            string file = @"http://webstrar36.fulton.asu.edu/page10/Hotels.xml";
            XPathDocument dx = new XPathDocument(file);
            XPathNavigator nav = dx.CreateNavigator();
            XPathNodeIterator iterator = nav.Select("/Hotels/Hotel");


            while (iterator.MoveNext())
            {
                XPathNodeIterator name = iterator.Current.Select(path);
                name.MoveNext();
                string data = name.Current.Value;
                list.Add(data);
            }
            return list;
        }

        private static void validate(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
                Console.WriteLine(" Warning" + e.Message);
            else // Error
                Console.WriteLine(" Error message" + e.Message);
        }


    }
}
