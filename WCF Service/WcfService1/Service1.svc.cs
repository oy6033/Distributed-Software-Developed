using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public string password(string firstName, string lastName, int age)
        {
            string ch_first = firstName.Substring(firstName.Length-2);
            string ch_last = lastName.Substring(0, 2);
            string age_mod = (age % 5).ToString();
            string passWord = ch_last + ch_first + age_mod;

            return passWord;
        }

        public int loginId(int age)
        {
            Random number = new Random();
            int Id = number.Next(100, 200) * age;
            return Id;
        }
    }
}
