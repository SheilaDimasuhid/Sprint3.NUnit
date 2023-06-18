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
    [Category("Profile Hours")]

    public class Profile_Hours : Base
    {
        public Profile_Hours(BrowserType browser) : base(browser)
        {

        }
        [Test]
        public void SelectHours()
        {

            //Create Extent Report
            test = extent.StartTest("SelectHours");

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Select Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableHours");
                ProfileObj.SelectHours(expectedResult);

                // Assertion
                string result = ProfileObj.GetHoursValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Hours successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Failed, Select action unsuccessfull.");
                test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ex.Message);
            }
        }

        [Test]
        public void EditHours()
        {

            //Create Extent Report
            test = extent.StartTest("EditHours");

            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Edit Availability     
                Profile ProfileObj = new Profile(_driver);
                string expectedResult = "As needed";
                ProfileObj.SelectHours(expectedResult);

                // Assertion
                string result = ProfileObj.GetHoursValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Passed, Hours successfully updated.");
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
