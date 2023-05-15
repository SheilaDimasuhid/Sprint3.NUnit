using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace MarsFramework.Pages
{
    internal class SignIn
    {
        private RemoteWebDriver _driver;
        public SignIn(RemoteWebDriver driver) => _driver = driver;

        // PageFactory.InitElements(driver, this);

        #region  Initialize Web Elements -- With Pagefactory
        /*
    //Finding the Sign Link
    //[FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div[1]/div[1]/div/a[2]")]
    [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
    private IWebElement SignIntab { get; set; }

    // Finding the Email Field
    // [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/form/div[1]/input")]
    [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
    private IWebElement Email { get; set; }

    //Finding the Password Field
    // [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/form/div[2]/input")]
    [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
    private IWebElement Password { get; set; }

    //Finding the Login Button
    // [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/form/div[4]/div")]
    [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
    private IWebElement LoginBtn { get; set; }
    */

        #endregion

        #region  Initialize Web Elements 
        //Finding the Sign Link
        private IWebElement SignIntab => _driver.FindElementByXPath("//*[@id='home']/div/div/div[1]/div/a");

        // Finding the Email Field
        private IWebElement Email => _driver.FindElementByXPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input");

        //Finding the Password Field
        private IWebElement Password => _driver.FindElementByXPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input");

        //Finding the Login Button
        IWebElement LoginBtn => _driver.FindElementByXPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");

        #endregion

        internal void LoginSteps()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            _driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));


            //Click on Sign In tab
            SignIntab.Click();
            //Enter the data in Username textbox
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter the password 
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            ////Click on Login button
            LoginBtn.Click();
            if (_driver.WaitForElementDisplayed(By.XPath("//a[contains(text(),'Mars Logo')]"), 60))
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            } else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login failed");
            }

        }
    }
}