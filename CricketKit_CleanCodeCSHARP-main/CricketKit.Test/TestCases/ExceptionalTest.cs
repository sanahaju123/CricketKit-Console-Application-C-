using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class ExceptionalTest
    {
        private readonly ITestOutputHelper _output;
        private static string type = "Exception";
        public ExceptionalTest(ITestOutputHelper output)
        {
            _output = output;
        }
       
        /// <summary>
        /// Test user input count is <= 15 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckUserinputStringCount()
        {
            //Arrange
            bool res = false;
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            string str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string[] collectionVal = str1.Split(',');
            //Act
            try
            {
                if (collectionVal != null)
                {
                    if (collectionVal.Length <= 18)
                    {
                        res = true;
                    }
                }
            }
            catch (Exception)
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


        /// <summary>
        /// Try to test and check output in correct count
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckOutputInCorrectCount()
        {
            //Arrange
            bool res = false;
            string str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
              Purchase p = new Purchase();
              p = Purchase.obtainPurchaseWithAmount(str1);
              string finalOutput = p.ToString();
              string[] collectionVal = finalOutput.Split(',');
              if (collectionVal != null)
                {
                    if (collectionVal.Length == 3)
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
    }
}
