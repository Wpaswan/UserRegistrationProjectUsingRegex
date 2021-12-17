using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProject
{
    internal class Registration
    {
        public static string FirsName = "^[A-Z]{1}[a-zA-Z0-9]{2,29}$";
        public static string LastName = "^[A-Z]{1}[a-zA-Z0-9]{2,29}$";
        public static string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public bool ValidateFirstName(string uName)
        {
            return Regex.IsMatch(uName, FirsName);
        }
        public bool ValidateLasttName(string uName)
        {
            return Regex.IsMatch(uName, LastName);
        }
        public bool ValidateEmail(string uName)
        {
            return Regex.IsMatch(uName, regex_email);
        }
    }
}
