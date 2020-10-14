using System;
using System.Diagnostics;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert Spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
               // result += source[0];

               //for (var i = 1; i < source.Length; i++)
                foreach (char letter in source)
                {
                    //if (!char.IsWhiteSpace(letter))
                    
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                    
                }
            }
            return result.Trim();
        }
    }
}
