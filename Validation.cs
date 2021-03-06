﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {
        public Boolean FirstNameValidation(string firstName)
        {
            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
            if(regularExpression.IsMatch(firstName))
                return true;
            else
                return false;

        }
        public Boolean LastNameValidation(string lastName)
        {

            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
                if(regularExpression.IsMatch(lastName))
                return true;
            else
                return false;
        }
        public Boolean EmailidValidation(string email)
        {
            Regex regularExpression = new Regex("^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}$");
            if (regularExpression.IsMatch(email))
                return true;
            else
                return false;
        }
        public Boolean MobileNumberValidation(string mobileNo)
        {
            Regex regularExpression = new Regex("^[0-9]{2,3}\\s[1-9]{10}$");
            if (regularExpression.IsMatch(mobileNo))
                return true;
            else
                return false;
        }
        public Boolean PasswordValidation(string password1)
        {
            Regex regularExpression=new Regex(@"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)");
            if (regularExpression.IsMatch(password1))
                return true;
            else
                return false;
        }
    }
}
