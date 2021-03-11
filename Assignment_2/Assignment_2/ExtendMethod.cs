using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Assignment_2
{
    public static class ExtendMethod
    {
        public static int WordCount(this string a)
        {
            int b = 0, myWord = 1;
            while (b <= a.Length - 1)
            {
                if (a[b] == ' ' || a[b] == '\n' || a[b] == '\t')
                {
                    myWord++;
                }
                b++;
            }
            return myWord;
        }
        public static string ConvertLower(this string a)
        {
            return a.ToLower();
        }
        public static string ConvertUpper(this string a)
        {
            return a.ToUpper();
        }
        public static bool IsLower(this string a)
        {
            string Mystring = a;
            char[] chars;
            char ch;
            int length = Mystring.Length;
            int cnt;
            int totalcntlower = 0;

            chars = Mystring.ToCharArray(0, length);
            for (cnt = 0; cnt < length; cnt++)
            {
                ch = chars[cnt];
                if (char.IsLower(ch))
                {
                    totalcntlower++;
                }
            }
            if(totalcntlower == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsUpper(this string a)
        {
            string Mystring = a;
            char[] chars;
            char ch;
            int length = Mystring.Length;
            int cnt;
            int totalcntupper = 0;

            chars = Mystring.ToCharArray(0, length);
            for (cnt = 0; cnt < length; cnt++)
            {
                ch = chars[cnt];
                if (char.IsUpper(ch))
                {
                    totalcntupper++;
                }
            }
            if (totalcntupper == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ConvertCapitalize(this string a)
        {
            return char.ToUpper(a[0]) + a.Substring(1);
        }
        public static string ConvertTitleCase(this string a)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a);
        }
        public static string RemoveLastCharacter(this string a)
        {
            return a.Remove(a.Length - 1, 1);
        }
        public static bool ValidNumeric(this string a)
        {
            int number1 = 0;
            return int.TryParse(a, out number1);
        }
        public static int? StringToNumber(this string a)
        {
            if (a.ValidNumeric())
            {
                return int.Parse(a);
            }
            else
                return null;
        }
    }
}
