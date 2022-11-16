using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number !");
            string number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            //teen siia if ja else loogikaga vastused
            // siin jääb programm seisma ja pead enterit vajutama
            Console.ReadKey();
            if (numberParsed >= 1 && numberParsed <= 49)
            {
                Console.WriteLine("Hea");
            }
            else if (numberParsed >= 50 && numberParsed < 99)
            {
                Console.WriteLine("Halb");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
