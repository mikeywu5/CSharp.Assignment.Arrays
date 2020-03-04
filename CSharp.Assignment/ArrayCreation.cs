using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class ArrayCreation
    {
        /// <summary>
        /// Given a number n, create and return a new int array of length n, containing the numbers 0, 1, 2, ... n-1. The given n may be 0, in which case just return a length 0 array. You do not need a separate if-statement for the length-0 case; the for-loop should naturally execute 0 times in that case, so it just works. The syntax to make a new int array is: new int[desired_length] 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] FizzArray(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a number n, create and return a new string array of length n, containing the strings "0", "1" "2" .. through n-1. N may be 0, in which case just return a length 0 array.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string[] FizzArray2(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given start and end numbers, return a new array containing the sequence of integers from start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal to the start number. Note that a length-0 array is valid.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int[] FizzArray3(int start, int end)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, create an array length n*n with the following pattern, shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] SquareUp(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, create an array with the pattern {1,    1, 2,    1, 2, 3,   ... 1, 2, 3 .. n} (spaces added to show the grouping). Note that the length of the array will be 1 + 2 + 3 ... + n, which is known to sum to exactly n*(n + 1)/2.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] SeriesUp(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will simply return a new subarray that is in the original array, containing values from the first index to the last index.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndeSetx"></param>
        /// <example>If your array is { 2, 4, 6, 8, 10, 1, 3, 5, 7} and if the first index is 3 and the last index is 5, the method will return a new array, {8, 10, 1}. </example>
        /// <returns>the subarray</returns>
        public int[] Subarray(int[] array, int firstIndex, int lastIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will simply create and return a copy of the original array by calling the Subarray method. 
        /// </summary>
        /// <param name="array"></param>
        /// <seealso cref="Subarray(int[], int, int)"/>
        /// <returns></returns>
        public int[] Copyarray(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replace the first zero in the array with another value. If no zeros are found, do not replace them.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        public void ReplaceZero(int[] array, int value)
        {

        }

        /// <summary>
        /// Create a method that returns the multiplicative
        /// persistence of a long integer n (64-bit integer).
        /// In general, multiplicative persistence is the number
        /// of steps required to multiply all the digits of a
        /// number n by each other, repeating with the product
        /// until a single digit is obtained. In addition, populate the products
        /// array with all the products in descending order,
        /// starting from index 0.
        /// </summary>
        /// <example>
        /// For example, the number 277 has a multiplicative persistence
        /// of 4 because 2×7×7=98, 9×8=72, 7×2=14, and 1×4=4. 
        /// </example>
        /// <param name="num">input number</param>
        /// <param name="products">contains all the positive products of the digits in ascending order</param>
        /// <returns></returns>
        public int MultiplicativePersistence(long num, long[] products)
        {
            throw new NotImplementedException();
        }
    }
}