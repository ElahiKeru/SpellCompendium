using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellLibrary
{
    public static class Utilities
    {
        /// <summary>
        /// Attempts to parse a string to determine if it's a boolean value
        /// </summary>
        /// <param name="target">string to parse</param>
        /// <returns>bool - defaults to false if the string is not a bool</returns>
        public static bool StringToBool(string target)
        {
            switch(target)
            {
                case "Yes":
                case "yes":
                case "YES":
                case "Y": 
                case "y": 
                case "true": 
                case "True": 
                case "TRUE":
                    return true;
                case "No":
                case "no":
                case "NO":
                case "N":
                case "n":
                case "False":
                case "false":
                case "FALSE":
                    return false;
                default:
                    return false;
            }
        }
    }
}
