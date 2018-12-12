using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;

namespace CountWords
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int countWords(string url)
        {
            try
            {
                System.Net.WebRequest wReq = System.Net.WebRequest.Create(url);
                System.Net.WebResponse wResp = wReq.GetResponse();
                System.IO.Stream respStream = wResp.GetResponseStream();
                using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding.ASCII))
                {
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t', '?' };
                    string[] words = reader.ReadToEnd().Split(delimiterChars);
                    words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    List<string> list = new List<string>(words);
                    var counts = new Dictionary<string, int>();
                    string localpath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
                    string[] lines = System.IO.File.ReadAllLines(localpath + @"\dictionary.txt");
                    List<string> list2 = new List<string>(lines);
                    foreach (string word in words)
                    {
                        if (!list2.Contains(word))
                        {
                            list.Remove(word);
                        }
                    }
                    int count = list.Count();
                    return count;
                }
            }
            catch (System.Exception ex)
            {
                //errorMsg = ex.Message;
            }
            return 0;
        }

        public string Top10ContentWords(string url)
        {
            try
            {
                System.Net.WebRequest wReq = System.Net.WebRequest.Create(url);
                System.Net.WebResponse wResp = wReq.GetResponse();
                System.IO.Stream respStream = wResp.GetResponseStream();
                using (System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding.ASCII))
                {
                    string Htmlstring = reader.ReadToEnd();
                    Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"<img[^>]*>;", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
                    Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
                    Htmlstring.Replace("<", "");
                    Htmlstring.Replace(">", "");
                    Htmlstring.Replace("\r\n", "");
                    Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
                    Regex rgx = new Regex("[^a-zA-Z0-9% ._]");
                    string str = rgx.Replace(Htmlstring, "");
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t', '?' };
                    string[] words = str.Split(delimiterChars);
                    words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    List<string> list = new List<string>(words);
                    var counts = new Dictionary<string, int>();
                    string localpath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
                    string[] lines = System.IO.File.ReadAllLines(localpath + @"\dictionary.txt");
                    List<string> list2 = new List<string>(lines);
                    foreach (string word in words)
                    {
                        if (word.Equals("a") || word.Equals("an") || word.Equals("in") || word.Equals("on")
                        || word.Equals("is") || word.Equals("are") || word.Equals("to") || word.Equals("am") || !list2.Contains(word)
                        || word.Equals("the") || word.Equals("as") || word.Equals("of") || word.Equals("about") || word.Length == 1)
                        {
                            list.Remove(word);
                        }
                    }
                    string[] newwords = list.ToArray();
                    foreach (string newword in newwords)
                    {
                        if (counts.ContainsKey(newword))
                            counts[newword] = counts[newword] + 1;
                        else
                            counts.Add(newword, 1);
                    }
                    var sortedDict = counts.OrderByDescending(entry => entry.Value)
                                .Take(10)
                                .ToDictionary(pair => pair.Key, pair => pair.Value);
                    string result = "";
                    foreach (KeyValuePair<string, int> Dict in sortedDict)
                    {
                        result = Dict.Key + "-->>" + Convert.ToString(Dict.Value) + "," + result;
                    }
                    return result;
                }
            }
            catch (System.Exception ex)
            {
                //errorMsg = ex.Message;
            }
            return null;
        }

        public double[] FindLatLon(string zipcode)
        {
            string url = @"http://api.geonames.org/postalCodeLookupJSON?postalcode=" + zipcode + @"&country=&username=oy6033";
            System.Net.WebRequest wReq = System.Net.WebRequest.Create(url);
            System.Net.WebResponse wResp = wReq.GetResponse();
            System.IO.Stream respStream = wResp.GetResponseStream();
            StreamReader reader = new StreamReader(respStream);
            var example2Model = new JavaScriptSerializer().Deserialize<CustomerOrderSummary>(reader.ReadToEnd());
            double[] latlon = { example2Model.postalcodes[0].lat, example2Model.postalcodes[0].lng };
            return latlon;
        }
        class CustomerOrderSummary
        {
            public List<postalcodes> postalcodes { get; set; }
        }
        class postalcodes
        {
            public double lng { get; set; }
            public double lat { get; set; }
        }
    }
}
