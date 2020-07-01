using System;

namespace MessageEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            string message = String.Empty;
            int checksum = 0;

            Console.WriteLine("Enter a message to be coded.");
            input = Console.ReadLine();
            string inputUpperCase = input.ToUpper();
            char[] codeArray = inputUpperCase.ToCharArray();

            foreach(char letter in codeArray)
            {
                int unicodeValue = Convert.ToInt32(letter);
                checksum += unicodeValue;

                message += unicodeValue-64 + "-";

            }
            Console.WriteLine();
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
            
        }
    }
}
