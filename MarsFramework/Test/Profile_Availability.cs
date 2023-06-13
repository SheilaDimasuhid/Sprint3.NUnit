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
    public class Profile_Availability : Base
    {
        public Profile_Availability(BrowserType browser) : base(browser)
        {
        }

        [Test]
        public void SelectAvailability()
        {

            //Create Extent Report
            test = extent.StartTest("SelectAvailability");

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Select Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime");
                ProfileObj.SelectAvailability(expectedResult);

                // Assertion
                string result = ProfileObj.GetAvailabilityValue();                
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Availability successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Select action unsuccessfull.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }

        [Test]
        public void EditAvailability()
        {

            //Create Extent Report
            test = extent.StartTest("EditAvailability");

            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Edit Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = "Part Time";
                ProfileObj.SelectAvailability(expectedResult);

                // Assertion
                string result = ProfileObj.GetAvailabilityValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Availability successfully updated.");
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
