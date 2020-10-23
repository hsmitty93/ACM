using System;

namespace Acme.Common
{
    
    public static class StringHandler
    {
        // this is an extension so you can directly call this method from prop ie. _productName.InsertSpaces()
        // instead of return StringHandler.InsertSpaces(_productName);
        /// <summary>Adds a space before each captial letter in a string</summary>
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
