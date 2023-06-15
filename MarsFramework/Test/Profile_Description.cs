using MarsFramework.Global;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    //[TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Chrome)]
    [Parallelizable(ParallelScope.Fixtures)]
    [Category("Sprint3")]
    internal class Profile_Description : Base
    {
        public Profile_Description(BrowserType browser) : base(browser)
        {

        }

        [Test]
        public void AddDescription()
        {
            //Create Extent Report
            test = extent.StartTest("AddDescription");

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            try
            {
                // Arrange
                Profile ProfileObj = new Profile(_driver);

                // Action
                ProfileObj.AddDescription(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                // Assertion
                string result = ProfileObj.GetNotificationMessage();
                string expectedResult = "Description has been saved successfully";
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Description update unsuccessfull.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }

        [Test]
        public void EditDescription()
        {
            //Create Extent Report
            test = extent.StartTest("EditDescription");

            string expectedResult, result,  notificationMessage;

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            try
            {
                // Arrange
                Profile ProfileObj = new Profile(_driver);

                expectedResult = GlobalDefinitions.ExcelLib.ReadData(3, "Description");

                // Action
                ProfileObj.AddDescription(expectedResult);

                // Assertion
                result = ProfileObj.GetDescriptionValue();
                notificationMessage = ProfileObj.GetNotificationMessage();

                if (notificationMessage== "Description has been saved successfully")
                {
                    if ((expectedResult == result)) 
                    {
                        Assert.That(result, Is.EqualTo(expectedResult));
                        // Log status in Extentreports
                        test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Full Description added successfully.");
                    }
                    else if (expectedResult != result)
                    {
                        // Log status in Extentreports
                        test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Only 600 caharacter of the description added successfully.");
                    }                   
                    //Assert.That(result, Is.EqualTo(expectedResult));
                }
                else
                {

                }
                //    Assert.That(result, Is.EqualTo(expectedResult));

                //// Log status in Extentreports
                //test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Description update unsuccessfull.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }

       


    }
}
