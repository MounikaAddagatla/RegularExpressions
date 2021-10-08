using System;

namespace RegexPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the Regular Expression Patterns");
            RegexExmp regex = new RegexExmp();

            // valid pincode //
            // pinCode.IsValidPinCode("400086");
            // Test case 2 for adding charcter before the pin
            // pinCode.IsValidPinCode( "A400086" );
            // Ends with Char 
            //pinCode.IsValidPinCode("400086B"); // test case 3
            // UC 4 using validate containg Space
            regex.IsValidPinCode("400 088");
            // checking for Email validation
            regex.IsValidEmail("abc.xyz@bridgelabzs.co.in");

            Console.ReadLine();
        }
    }
}
