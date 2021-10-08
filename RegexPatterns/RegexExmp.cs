using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatterns
{
    class RegexExmp
    {
        // CHECKING FOR VALIDATING INDIA  PINCODE WITHOUT CHARECTERS //
        const string POSTAL_PIN_CHECK = "^[0-9]{6}$";

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

    }
}

