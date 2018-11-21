using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamics365_code.Week_3;

namespace Dynamics365_testunits
{
    [TestClass]
    public class Week3_Tests_TwoAddends
    {
        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 13, 6, 7)]
        public void ReturnTwoAddendsMethod_Correct(int arr1, int arr2, int arr3, int arr4, int arr5, int arr6, int arr7, int inputSum, int result1, int result2)
        {
            int[] inputArr = new int[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };
            int[] expectedResult = new int[] { result1, result2 };

            int[] result = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr, inputSum);
            
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 15)]
        public void ReturnTwoAddendsMethod_Returns_Empty_Array(int arr1, int arr2, int arr3, int arr4, int arr5, int arr6, int arr7, int inputSum)
        {
            int[] inputArr = new int[] { arr1, arr2, arr3, arr4, arr5, arr6, arr7 };
            int[] expectedResult = new int[] { };

            int[] result = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr, inputSum);

            int[] inputArr2 = new int[] { arr1, arr3 };
            int[] result2 = ReturnTwoAddends.ReturnTwoAddendsMethod(inputArr2, 2);

            CollectionAssert.AreEqual(expectedResult, result);
            CollectionAssert.AreEqual(expectedResult, result2);
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
}


