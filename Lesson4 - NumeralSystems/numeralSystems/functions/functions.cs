using System;

namespace Functions
{
   public class Functions
    {
       // universal function for Reverse of string :O
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
        }
    }
}
