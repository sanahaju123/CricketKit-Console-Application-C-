using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private static string type = "Functional";
        public FunctionalTests(ITestOutputHelper output)
        {
            _output = output;
        }


        /// <summary>
        /// Try to test if string array try to parse or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryParseStringArrytoInt()
        {
            //Arrange
            bool res = false;
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string[] collectionVal = str1.Split(',');
            //Act
            try
            {
                if (collectionVal != null)
                {
                    int.TryParse(collectionVal[0], out int resultId);
                    if(resultId == 3 && collectionVal.Length <= 18 )
                    {
                        res = true;
                    }
                }
            }
            catch (Exception)
            {
              //Assert
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            ///Assert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        /// <summary>
        /// test the obtainPurchaseWithAmount method that return correct object or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_obtainPurchaseWithAmountReturnObject()
        {
            //Arrange
            bool res = false;
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            Purchase p = new Purchase();
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                //Act
                if (p != null)
                {
                    res = true;
                }
            }
            catch(Exception)
            {
              status = Convert.ToString(res);
              _output.WriteLine(testName + ":Failed");
              await CallAPI.saveTestResult(testName, status, type);
              return false;
            }
            ///Assert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
