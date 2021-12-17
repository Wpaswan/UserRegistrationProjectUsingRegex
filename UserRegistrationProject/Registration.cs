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
        public static string regex_mobile = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
        public static string regex_passwordRule1 = "^[a-zA-Z0-9]{8,}$";
        public static string regex_passwordRule2 = "^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        public static string regex_passwordRule3 = "^(?=.[A-Z])(?=.[0-9])[a-zA-Z0-9]{8,}$";
        public static string regex_passwordRule4 = "^(?=.[A-Z])(?=.[0-9])(?=.+[!@#$%^&*])[a-zA-Z0-9]{8,}$";
        public static string regex_emailsample = "^[\\w!#$%&'+/=?`{|}~^-]+(?:\\.[\\w!#$%&'+/=?`{|}~^-]+)*@(?:([0-9-]{1}|[a-zA-Z]{3,5})\\.)+[a-zA-Z]{2,3}$";
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
        public bool ValidateMobileNumber(string uName)
        {
            return Regex.IsMatch(uName, regex_mobile);
        }
        public bool ValidatePasswordRule1(string uName)
        {
            return Regex.IsMatch(uName, regex_passwordRule1);



        }
        public bool ValidatePasswordRule2(string uName)
        {
            return Regex.IsMatch(uName, regex_passwordRule2);



        }
        public bool ValidatePasswordRule3(string uName)
        {
            return Regex.IsMatch(uName, regex_passwordRule3);



        }
        public bool ValidatePasswordRule4(string uName)
        {
            return Regex.IsMatch(uName, regex_passwordRule4);



        }
        public bool ValidateAnyEmail(string uName)
        {
            return Regex.IsMatch(uName, regex_emailsample);



        }

    }
}
