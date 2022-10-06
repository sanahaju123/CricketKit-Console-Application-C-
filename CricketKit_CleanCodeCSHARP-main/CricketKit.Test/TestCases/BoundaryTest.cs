using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CricketKit.Test.TestCases
{
    public class BoundaryTest
    {
        private readonly ITestOutputHelper _output;
        private static string type = "Boundary";
        public BoundaryTest(ITestOutputHelper output)
        {
            _output = output;
        }
        
        /// <summary>
        /// Test to validate using output PurchaseId is correct or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputIdCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.purchaseId == 3)
                {
                    res = true;
                }
            }
            catch(Exception)
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



        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputUserCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.user == "Jack")
                {
                    res = true;
                }
            }
            catch(Exception)
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



        [Fact]
        public async Task<bool> testFor_TryCheckUserOutputTotalAmountCorrectOrNot()
        {
            //Arrange
            bool res = false;
            String str1 = "3,12-12-2012,Jack,Bat,1500,7,Ball,60,1,Stump,340,5,helmet,925,5,Pad,600,15";
            string testName;string status;
            testName = CallAPI.GetCurrentMethodName();
            Purchase p = new Purchase();
            //Act
            try
            {
                p = Purchase.obtainPurchaseWithAmount(str1);
                if (p.totalAmount == 25885)
                {
                    res = true;
                }
            }
            catch(Exception)
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
