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
        public bool ValidateFirstName(string uName)
        {
            return Regex.IsMatch(uName, FirsName);
        }
        public bool ValidateLasttName(string uName)
        {
            return Regex.IsMatch(uName, LastName);
        }
    }
}
