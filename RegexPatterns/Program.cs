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
            pinCode.IsValidPinCode("400086");
            Console.ReadLine();
        }
    }
}
