using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.CodingPractice
{
    public class AnyAll
    {
        /*
                * Any & All
                * 
                * Using LINQ, implement the IsAnyWordWhiteSpace method, which checks if,
                * in a given collection of strings, any word consists only of white space characters.
                * 
                * White space characters are all "empty" characters, such as spaces or newline symbols.
                * We can check if a character is a white space using the char.IsWhiteSpace method.
                * 
                * Examples:
                * 
                * 1. Input: {"hello", "There    "}
                *    Output: false
                *    Explanation: No word consists only of white space characters.
                * 
                * 2. Input: {"hello", "      "}
                *    Output: true
                *    Explanation: The word "      " consists only of white space characters.
                * 
                * 3. Input: {}
                *    Output: false
                *    Explanation: No words exist at all, so none can be only whitespace.
                */

        public static bool IsAnyWordWhiteSpace(List<string> words)
        {
            var hasWhiteSpace = words.Any(word => word.All(character => char.IsWhiteSpace(character)));


            return hasWhiteSpace;
        }
    }
}