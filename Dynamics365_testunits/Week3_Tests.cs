﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamics365_code.Week_3;
using System.Collections.Generic;

namespace Dynamics365_testunits
{
    [TestClass]
    public class Week3_Tests_TwoAddends
    {
        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 13, 6, 7)]
        [DataRow(-1, -3, 5, 6, 7, 2, 98, -4, -1, -3)]
        public void ReturnTwoAddendsMethod_Correct(int arr1, int arr2, int arr3, int arr4, int arr5, int arr6, int arr7, int inputSum, int result1, int result2)
        {
            int[] inputArr = new int[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };
            int[] expectedResult = new int[] { result1, result2 };

            int[] result = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr, inputSum);
            
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 15)]
        public void ReturnTwoAddendsMethod_Returns_Null(int arr1, int arr2, int arr3, int arr4, int arr5, int arr6, int arr7, int inputSum)
        {
            int[] inputArr = new int[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };
            int[] result = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr, inputSum);

            int[] inputArr2 = new int[] { arr1, arr3 };
            int[] result2 = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr2, 2);

            CollectionAssert.AreEqual(null, result);
            CollectionAssert.AreEqual(null, result2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ReturnTwoAddendsMethod_Throws_InvalidOperationException_When_Array_Is_Empty()
        {
            int[] emptyArr = new int[] { };

            ReturnTwoAddends.ReturnTwoAddendsMethod(emptyArr, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ReturnTwoAddendsMethod_Throws_InvalidOperationException_When_Array_Is_One_Length()
        {
            int[] oneLengthArr = new int[] { 1 };

            ReturnTwoAddends.ReturnTwoAddendsMethod(oneLengthArr, 3);
        }
    }

    [TestClass]
    public class Week3_Tests_Sum3
    {
        [TestMethod]
        public void Sum3Method_Returns_Correctly()
        {
            int[] inputArr = new int[] { 1, 2, 3, 4, 0 };
            const int sum = 6;
            int[] inputArr2 = new int[] { 0, -1, 1, 3, -2, 2, -3 };
            const int sum2 = 0;

            List<int[]> expectedResult = new List<int[]> {
                new int[] { 1, 2, 3 },
                new int[] { 0, 2, 4 } };
            List<int[]> expectedResult2 = new List<int[]> {
                new int[] { -1, 0, 1 },
                new int[] { -3, 0, 3 },
                new int[] { -2, 0, 2 },
                new int[] { -2, -1, 3},
                new int[] { -3, 1, 2} };

            var result = Sum3.Sum3Method(inputArr, sum);
            var result2 = Sum3.Sum3Method(inputArr2, sum2);

            foreach (int[] item in expectedResult)
            {
                CollectionAssert.AreEqual(item, result[expectedResult.IndexOf(item)]);
            }

            foreach (int[] item in expectedResult2)
            {
                CollectionAssert.AreEqual(item, result2[expectedResult2.IndexOf(item)]);
            }
        }

        [DataTestMethod]
        [DataRow(0, 1, 2)]
        public void Sum3Method_Returns_Null(int sum, int arr1, int arr2)
        {
            int[] inputArr = null;
            int[] inputArr2 = new int[1] { arr1 };
            int[] inputArr3 = new int[2] { arr1, arr2 };

            var result = Sum3.Sum3Method(inputArr, sum);
            var result2 = Sum3.Sum3Method(inputArr2, sum);
            var result3 = Sum3.Sum3Method(inputArr3, sum);

            Assert.AreEqual(null, result);
            Assert.AreEqual(null, result2);
            Assert.AreEqual(null, result3);
        }
    }
}