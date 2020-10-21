using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
        public static string Name_Regex = "^[A-Z]{1}[A-Za-z]{30,}$";
        public static string Email_Regex = "^[6-9]{1}[0-9]{9}$";
        public static string PhoneNumb_Regex = "^[0-9a-zA-Z]+[.+-]{0,1}[0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-z]{2,3}){,1}";
        public static string Month_Regex = "";
    }
    

       
    
        public static bool ValidateName()
        {
            string text = "Please enter a valid name:";
            Console.WriteLine(text);
            if (!Regex.Match(text, "^[A - Z]{ 1}[A-Za - z]{ 30,}*$").Success) 
            {
                Console.WriteLine("Sorry name not valid.");
            }

        }    
    }
}

