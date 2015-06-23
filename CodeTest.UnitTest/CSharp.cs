using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

using CodeTest.CSharp;

namespace CodeTest.UnitTest
{
    [TestClass]
    public class CSharp
    {
        [TestMethod]
        public void Requirements1()
        {
            // Using the CodeTest.CSharp namespace will provide access to the 
            // static class Requirements1 which contains the extension method

            string testString = null;
            Assert.IsTrue(testString.IsNullOrEmpty(), "Test null value"); //Test null value

            testString = string.Empty;
            Assert.IsTrue(testString.IsNullOrEmpty(), "Test empty value"); //Test empty string

            testString = "";
            Assert.IsTrue(testString.IsNullOrEmpty(), "Test empty value"); //Test empty string

            testString = "a";
            Assert.IsFalse(testString.IsNullOrEmpty(), "Test string value"); //Test string value

            testString = "null";
            Assert.IsFalse(testString.IsNullOrEmpty(), "Test string value"); //Test string value
        }

        [TestMethod]
        public void Requirements2()
        {
            //The private function ListsEqual compares each item in both lists to test the PositiveDivisors function
            var requirements = new Requirements2();

            Assert.IsTrue(this.ListsEqual(requirements.PositiveDivisors(60).ToList(), new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 }), "Positive Divisors of 60");

            Assert.IsTrue(this.ListsEqual(requirements.PositiveDivisors(42).ToList(), new List<int> { 1, 2, 3, 6, 7, 14, 21, 42 }), "Positive Divisors of 42");

            Assert.IsTrue(this.ListsEqual(requirements.PositiveDivisors(1).ToList(), new List<int> { 1 }), "Positive Divisor of 1");

            Assert.IsFalse(this.ListsEqual(requirements.PositiveDivisors(60).ToList(), new List<int> { -60, 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 }), "Positive and negative Divisors of 60");
        }


        [TestMethod]
        public void Requirements3()
        {
            var requirements = new Requirements3();

            Assert.AreEqual<double>(requirements.TriangleArea(3, 4, 5), 6);

            Assert.AreEqual<double>(Math.Round(requirements.TriangleArea(18.5, 24, 23.9), 2), 204.34); // Test values with decimals

            try
            {
                Assert.AreEqual<double>(requirements.TriangleArea(-3, 4, 5), 6); // Sides cannot have a negative number
            }
            catch (InvalidTriangleException ex)
            {
                Assert.AreEqual<string>(ex.Message, "Inputs cannot be negative", ex.Message);
            }

            try
            {
                Assert.AreEqual<double>(requirements.TriangleArea(30, 24, 184), 216); // Invalid sides to a triangle 
            }
            catch (InvalidTriangleException ex)
            {
                Assert.AreEqual<string>(ex.Message, "Inputs form an invalid triangle", ex.Message);
            }
        }

        [TestMethod]
        public void Requirements4()
        {
            var requirements = new Requirements4();

            Assert.IsTrue(this.ListsEqual(requirements.MostCommon(new List<int> { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }), new List<int> { 5, 4 }));

            Assert.IsTrue(this.ListsEqual(requirements.MostCommon(new List<int> { 4, 5, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }), new List<int> { 4, 5 }));

            Assert.IsTrue(this.ListsEqual(requirements.MostCommon(new List<int> { 1, 2, 3, 4, 5, 1, 6, 7 }), new List<int> { 1 }));

            Assert.IsTrue(this.ListsEqual(requirements.MostCommon(new List<int> { 1, 2, 3, 4, 5, 6, 7 }), new List<int> { 1, 2, 3, 4, 5, 6, 7 }));
        }

        /// <summary>
        /// Compare two generic list of integers
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        private bool ListsEqual(List<int> list1, List<int> list2)
        {
            if (list1 == null || list2 == null || list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
