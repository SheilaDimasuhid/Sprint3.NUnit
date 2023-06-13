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
        public void AddDescripriton()
        {
            //Create Extent Report
            test = extent.StartTest("SelectAvailability");

            //try
            //{
            //    // Arrange
            //    Profile ProfileObj = new Profile();

            //    // Action
            //    ProfileObj.AddDescription("Enter test description text area here.");

            //    // Assertion
            //    string result = ProfileObj.GetDescriptionValue();
            //    string expectedResult = "Enter test description text area here.";
            //    Assert.That(result, Is.EqualTo(expectedResult));

            //    // Log status in Extentreports
            //    test.Log(Status.Pass, "Passed, action successfull.");
            //}
            //catch (Exception ex)
            //{
            //    // Log status in Extentreports
            //    test.Log(Status.Fail, "Failed, action unsuccessfull.");
            //    test.Log(Status.Info, ex.Message);
            //}
        }


    }
}
