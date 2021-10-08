using System;

namespace RegexPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the Regular Expression Patterns");
            RegexExmp pinCode = new RegexExmp();

            // valid pincode //
           // pinCode.IsValidPinCode("400086");
            // Test case 2 for adding charcter before the pin
            pinCode.IsValidPinCode("A400086");
            Console.ReadLine();
        }
    }
}
