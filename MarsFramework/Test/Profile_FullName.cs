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
    [Category("Profile FullName")]
    public class Profile_FullName : Base
    {
        public Profile_FullName(BrowserType browser) : base(browser)
        {
        }

        [Test]
        public void EditProfileFullName()
        {

            //Create Extent Report
            test = extent.StartTest("EditProfileFullName");
            // Create Share Skills      
            Profile obj = new Profile(_driver);
            obj.EditFullName();

        }
    }
}
