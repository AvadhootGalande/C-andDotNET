using System;
using System.Net.Mail;

namespace ConsoleApp_Assignment
{
    internal class Program
    {
        //Reverse string function
        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        //Email validation function 
        private static bool IsValidEmail(string EmailToCheck)
        {
            try
            {
                MailAddress mail = new MailAddress (EmailToCheck);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        //Enum Function
        enum countries
        {
            INDIA,
            AUSTRALIA,
            USA,
            JAPAN,
            FRANCE,
            ENGLAND
        }
  
        static void Main(string[] args)
        {
            //Creating String
            string str1 = "This is Avadhoot my first name.";
            string str2 = "Galande is my last name";

            //Printing Strings
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //Comparing Strings
            if (str1 == str2)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("NO");

            //Concat Operation
            Console.WriteLine(str1 + str2);

            //Substring Operation
            Console.WriteLine(str1.Substring(16));

            //Reversing String 
            Console.WriteLine(ReverseString("Avadhoot"));

            //ENUM 
            Console.WriteLine("Value of INDIA is " + (int)countries.INDIA);
            Console.WriteLine("Value of AUSTRALIA is " + (int)countries.AUSTRALIA);
            Console.WriteLine("Value of USA is " + (int)countries.USA);
            Console.WriteLine("Value of JAPAN is " + (int)countries.JAPAN);
            Console.WriteLine("Value of FRANCE is " + (int)countries.FRANCE);
            Console.WriteLine("Value of ENGLAND is " + (int)countries.ENGLAND);

            //E-mail Valiadtion

            string EmailToCheck = Console.ReadLine();

            if (IsValidEmail(EmailToCheck))
            {
                Console.WriteLine("Valid Mail");
            }
            else Console.WriteLine("Invalid Mail");

            Main(args);

            
               
        }
    }
}
