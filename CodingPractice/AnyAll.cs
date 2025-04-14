﻿using System;
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


        /*
         * Count & Contains
         * 
         * Implement the CountListsContainingZeroLongerThan method. It takes the following parameters:
         * 
         * - length (int): the minimum length a list must exceed
         * - listsOfNumbers (List<List<int>>): a list of integer lists
         * 
         * This method should return the count of the lists that meet **both** of the following conditions:
         * 
         * 1. Contain the number zero
         * 2. Are longer than the specified length
         * 
         * Example:
         * ----------
         * Input:
         *   length = 3
         *   listsOfNumbers =
         *   {
         *       {1, 2, 5, -1},
         *       {0, 4, 4, 6},
         *       {9, 0}
         *   }
         * 
         * Output:
         *   1
         * 
         * Explanation:
         *   Only the second list contains the number zero and has more than 3 items.
         */

        public static int CountListsContainingZeroLongerThan(
            int length,
            List<List<int>> listsOfNumbers)
        {
            var countListcontainNumberZeroWithLongerThanLength
                = listsOfNumbers.Count(list => list.Contains(0) && list.Count() > length);

            return countListcontainNumberZeroWithLongerThanLength;
        }
    }
}