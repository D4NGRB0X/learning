using System;
using System.Diagnostics;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
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
