using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;



namespace MarsFramework
{
    //[TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Chrome)]
    [Parallelizable(ParallelScope.Fixtures)]
    [Category("Sprint3")]
    public class Program : Base

    {
        public Program(BrowserType browser) : base(browser)
        {
        }
        [Test]
        public void CreateNewSkill()
        {

            //Create Extent Report
            test = extent.StartTest("Share Skills");
            // Create Share Skills      
            ShareSkills obj = new ShareSkills(_driver);
            obj.AddNewSkill();

        }
        [Test]
        public void EditUserProfile()
        {

            //Create Extent Report
            test = extent.StartTest("Profile");
            // Create Share Skills      
            Profile obj = new Profile(_driver);
            obj.EditProfile();

        }

    }
}


