using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatterns
{
    class RegexExmp
    {
        // CHECKING FOR VALIDATING INDIA  PINCODE WITHOUT CHARECTERS //
        const string POSTAL_PIN_CHECK = "(^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$)";   //[ "^[1-9]{6}$" ] for without spacing code
        const string EMAIL_VALIDATE = "^[a-z]{3}.[a-z]*@bridgelabzs.co.[a-z]*";
        // Function to validate the pin code of India.
       public void IsValidPinCode(string pinCode)
       {

        // Return true if the pin code
        // matched the ReGex
               if (Regex.IsMatch(pinCode,POSTAL_PIN_CHECK))
               {
                Console.WriteLine(" Pincode is valid ");
                return;
               }
          Console.WriteLine(" Not Valid Pincode ");
       }
        public void IsValidEmail(string email)
        {
             // checking for starts with abc //
             if (Regex.IsMatch(email, EMAIL_VALIDATE))
             {
                Console.WriteLine("U enter Valid Email id");
                return;
             }
            Console.WriteLine("Not Valid Email");
        }
    }
}

