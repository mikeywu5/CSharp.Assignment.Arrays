using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Tests
{
    public class ArrayCreationTests
    {
        private dynamic _object;

        public ArrayCreationTests()
        {
            _object = new ArrayCreation();
        }

        [Fact]
        [Trait("Category", "Easy")]
        public void FizzArray()
        {

            Int32[] expected, actual;

            expected = new[] { 0, 1, 2, 3 };
            actual = _object.FizzArray(4);
            Assert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.FizzArray(1);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            actual = _object.FizzArray(10);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzArray(0);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1 };
            actual = _object.FizzArray(2);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6 };
            actual = _object.FizzArray(7);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void FizzArray2()
        {

            String[] expected, actual;

            expected = new[] { "0", "1", "2", "3" };
            actual = _object.FizzArray2(4);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            actual = _object.FizzArray2(10);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1" };
            actual = _object.FizzArray2(2);
            Assert.Equal(expected, actual);

            expected = new[] { "0" };
            actual = _object.FizzArray2(1);
            Assert.Equal(expected, actual);

            expected = new string[0];
            actual = _object.FizzArray2(0);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6" };
            actual = _object.FizzArray2(7);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            actual = _object.FizzArray2(9);
            Assert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            actual = _object.FizzArray2(11);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void FizzArray3()
        {

            Int32[] expected, actual;

            expected = new[] { 5, 6, 7, 8, 9 };
            actual = _object.FizzArray3(5, 10);
            Assert.Equal(expected, actual);

            expected = new[] { 11, 12, 13, 14, 15, 16, 17 };
            actual = _object.FizzArray3(11, 18);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            actual = _object.FizzArray3(1, 3);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.FizzArray3(1, 2);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzArray3(1, 1);
            Assert.Equal(expected, actual);

            expected = new[] { 1000, 1001, 1002, 1003, 1004 };
            actual = _object.FizzArray3(1000, 1005);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void SquareUp()
        {

            Int32[] expected, actual;

            expected = new[] { 0, 0, 1, 0, 2, 1, 3, 2, 1 };
            actual = _object.SquareUp(3);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 1 };
            actual = _object.SquareUp(2);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1 };
            actual = _object.SquareUp(4);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SquareUp(1);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SquareUp(0);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 1, 0, 0, 0, 3, 2, 1, 0, 0, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2, 1 };
            actual = _object.SquareUp(6);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Medium")]
        public void SeriesUp()
        {

            Int32[] expected, actual;

            expected = new[] { 1, 1, 2, 1, 2, 3 };
            actual = _object.SeriesUp(3);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4 };
            actual = _object.SeriesUp(4);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2 };
            actual = _object.SeriesUp(2);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SeriesUp(1);
            Assert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SeriesUp(0);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 };
            actual = _object.SeriesUp(6);
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void Subarray()
        {
            int[] a = SampleArray();
            int[] actual, expected;
            expected = null;
            actual = _object.Subarray(null, 0, 0);
            Assert.Equal(expected, actual);

            expected = new[] { 2 };
            actual = _object.Subarray(a, 0, 0);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16 };
            actual = _object.Subarray(a, 0, 1);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1 };
            actual = _object.Subarray(a, 0, 2);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14 };
            actual = _object.Subarray(a, 0, 3);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11 };
            actual = _object.Subarray(a, 0, 5);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            actual = _object.Subarray(a, 0, 8);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            actual = _object.Subarray(a, 0, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 0, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.Subarray(a, 4, 4);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11 };
            actual = _object.Subarray(a, 4, 5);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11 };
            actual = _object.Subarray(a, 4, 6);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6 };
            actual = _object.Subarray(a, 4, 7);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17 };
            actual = _object.Subarray(a, 4, 9);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            actual = _object.Subarray(a, 4, 12);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            actual = _object.Subarray(a, 4, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.Subarray(a, 8, 8);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17 };
            actual = _object.Subarray(a, 8, 9);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14 };
            actual = _object.Subarray(a, 8, 10);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9 };
            actual = _object.Subarray(a, 8, 11);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4 };
            actual = _object.Subarray(a, 8, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            actual = _object.Subarray(a, 8, 16);
            Assert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 8, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.Subarray(a, 12, 12);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4 };
            actual = _object.Subarray(a, 12, 13);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19 };
            actual = _object.Subarray(a, 12, 14);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13 };
            actual = _object.Subarray(a, 12, 15);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9 };
            actual = _object.Subarray(a, 12, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            actual = _object.Subarray(a, 12, 20);
            Assert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.Subarray(a, 16, 16);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9 };
            actual = _object.Subarray(a, 16, 17);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7 };
            actual = _object.Subarray(a, 16, 18);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17 };
            actual = _object.Subarray(a, 16, 19);
            Assert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17, 20, 3 };
            actual = _object.Subarray(a, 16, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 20 };
            actual = _object.Subarray(a, 20, 20);
            Assert.Equal(expected, actual);

            expected = new[] { 20, 3 };
            actual = _object.Subarray(a, 20, 21);
            Assert.Equal(expected, actual);

            expected = new[] { 3 };
            actual = _object.Subarray(a, 21, 21);
            Assert.Equal(expected, actual);




            //var sb = new StringBuilder();


            //for (int i = 0; i <= 24; i += 4)
            //{
            //    int p = 0, q = 1;
            //    if (i == 24) i = 21;
            //    for (int j = i; j < a.Length; j = i + q)
            //    {
            //        q = p + q;
            //        p = q - p;
            //        sb.AppendLine($"expected = new [] {_object.Subarray(a, i, j).ToCode()};");
            //        sb.AppendLine($"actual = _object.Subarray(a, {i}, {j});");
            //        sb.AppendLine("Assert.Equal(expected, actual);");
            //        sb.AppendLine();
            //    }
            //}
            //Assert.Fail(sb.ToString());

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void Copyarray()
        {

            int[] actual, expected, a;

            expected = null;
            actual = _object.Copyarray(null);
            Assert.Equal(expected, actual);

            expected = new[] { 20 };
            a = new[] { 20 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            a = new[] { 1, 2 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { -13, 34, 55 };
            a = new[] { -13, 34, 55 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            a = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Copyarray(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            Assert.Equal(expected, actual);

        }

        [Fact]
        [Trait("Category", "Easy")]
        public void ReplaceZero()
        {
            int[] actual = null;
            int[] expected;
            _object.ReplaceZero(actual, 10);
            Assert.Null(actual);

            actual = new[] { 1, 2, 0, 4 };
            expected = new[] { 1, 2, 3, 4 };
            _object.ReplaceZero(actual, 3);
            Assert.Equal(expected, actual);

            actual = new[] { 0, 2, 0, 4 };
            expected = new[] { 10, 2, 0, 4 };
            _object.ReplaceZero(actual, 10);
            Assert.Equal(expected, actual);

            actual = new[] { 1, 2, 3, 0 };
            expected = new[] { 1, 2, 3, 10 };
            _object.ReplaceZero(actual, 10);
            Assert.Equal(expected, actual);

            actual = new[] { 1, 2, 3, 4 };
            expected = new[] { 1, 2, 3, 4 };
            _object.ReplaceZero(actual, 10);
            Assert.Equal(expected, actual);

            actual = new[] { 0, 0, 0, 0 };
            expected = new[] { 10, 0, 0, 0 };
            _object.ReplaceZero(actual, 10);
            Assert.Equal(expected, actual);
            expected = new[] { 10, 20, 0, 0 };
            _object.ReplaceZero(actual, 20);
            Assert.Equal(expected, actual);
            expected = new[] { 10, 20, 30, 0 };
            _object.ReplaceZero(actual, 30);
            Assert.Equal(expected, actual);
            expected = new[] { 10, 20, 30, 40 };
            _object.ReplaceZero(actual, 40);
            Assert.Equal(expected, actual);
            expected = new[] { 10, 20, 30, 40 };
            _object.ReplaceZero(actual, 50);
            Assert.Equal(expected, actual);

            actual = new int[0];
            expected = new int[0];
            _object.ReplaceZero(actual, 10);
            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait("Category", "Medium")]
        public void MultiplicativePersistence()
        {
            string s;
            long num, actual, expected;
            long[] expectedArray, actualArray;

            for (num = -9; num < 10; num++)
            {
                expectedArray = new long[1];
                actualArray = new long[1];
                actual = _object.MultiplicativePersistence(num, actualArray);
                expected = 0;
                expectedArray = new long[1];
                Assert.Equal(expected, actual);
                Assert.Equal(expectedArray, actualArray);
            }

            num = 11;
            expected = 1;
            actualArray = new long[12];
            expectedArray = new long[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 25;
            expected = 2;
            actualArray = new long[12];
            expectedArray = new long[] { 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);


            num = 39;
            expected = 3;
            actualArray = new long[12];
            expectedArray = new long[] { 4, 14, 27, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 77;
            expected = 4;
            actualArray = new long[12];
            expectedArray = new long[] { 8, 18, 36, 49, 0, 0, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 679;
            expected = 5;
            actualArray = new long[12];
            expectedArray = new long[] { 6, 32, 48, 168, 378, 0, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 6788;
            expected = 6;
            actualArray = new long[12];
            expectedArray = new long[] { 0, 20, 54, 336, 768, 2688, 0, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 68889;
            expected = 7;
            actualArray = new long[12];
            expectedArray = new long[] { 0, 20, 54, 336, 768, 2688, 27648, 0, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 2677889;
            expected = 8;
            actualArray = new long[12];
            expectedArray = new long[] { 0, 20, 54, 336, 768, 2688, 27648, 338688, 0, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 26888999;
            expected = 9;
            actualArray = new long[12];
            expectedArray = new long[] { 00, 20, 54, 336, 768, 2688, 27648, 338688, 4478976, 0, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 3778888999;
            expected = 10;
            actualArray = new long[12];
            expectedArray = new long[] { 0, 20, 54, 336, 768, 2688, 27648, 338688, 4478976, 438939648, 0, 0 };
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);

            num = 277777788888899;
            expected = 11;
            expectedArray = new long[] { 0, 20, 54, 336, 768, 2688, 27648, 338688, 4478976, 438939648, 4996238671872, 0 };
            actualArray = new long[12];
            actual = _object.MultiplicativePersistence(num, actualArray);
            Assert.Equal(expected, actual);
            s = string.Join(", ", actualArray);
            Assert.Equal(expectedArray, actualArray);
        }

        private int[] SampleArray()
        {
            return new int[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
        }
    }
}
