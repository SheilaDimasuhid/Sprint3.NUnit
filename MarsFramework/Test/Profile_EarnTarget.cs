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
    [Category("Profile Earn Target")]

    public class Profile_EarnTarget : Base
    {
        public Profile_EarnTarget(BrowserType browser) : base(browser)
        {

        }

        [Test]
        public void SelectEarnTarget()
        {

            //Create Extent Report
            test = extent.StartTest("SelectEarnTarget");

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Select Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget");
                ProfileObj.EarnTarget(expectedResult);

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Earn Target successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Select action unsuccessfull.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }

        [Test]
        public void EditEarnTarget()
        {

            //Create Extent Report
            test = extent.StartTest("EditEarnTarget");

            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Edit Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = "More than $1000 per month";
                ProfileObj.EarnTarget(expectedResult);

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Earn Target successfully updated.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Update Unsuccessful.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }
    }
}
