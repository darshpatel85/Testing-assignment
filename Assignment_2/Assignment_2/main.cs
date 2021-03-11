using System;

namespace Assignment_2
{
    public class main
    {
        public static void Main(string[] args)
        {
            string a = "darsh Patel";

            Console.WriteLine("Converted \"" + a + "\" into Uppercase : " + a.ConvertUpper());
            a = "DARSH PATEL";
            Console.WriteLine("Converted \"" + a + "\" into Lowercase : " + a.ConvertLower());
            a = "darsh patel";
            Console.WriteLine("Converted \"" + a + "\" into Titlecase : " + a.ConvertTitleCase());
            a = "darshpatel";
            Console.WriteLine("Checking if all the character of string are in lower case or not \"" + a + "\" : " + a.IsLower());
            a = "darsh patel";
            Console.WriteLine("Converted \"" + a + "\" into Capitalize : " + a.ConvertCapitalize());
            a = "DARSHPATEL";
            Console.WriteLine("Checking if all the character of string are in upper case or not \"" + a + "\" : " + a.IsUpper());
            a = "darsh patel";
            Console.WriteLine("No of word in \"" + a + "\" : " + a.WordCount());
            a = "Darsh Patel";
            Console.WriteLine("After removing last char from string \"" + a + "\" : " + a.RemoveLastCharacter());
            string num = "543A";
            if (num.ValidNumeric() == true)
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            else
                Console.WriteLine("\"" + num + "\" is not valid numeric value");
            if  (num.StringToNumber() == null)
                Console.WriteLine("\"" + num + "\" can not convert in numeric value");
            else
                Console.WriteLine("\"" + num + "\" numeric value is : " + num.StringToNumber());
            
        }
    }
}
