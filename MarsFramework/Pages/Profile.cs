﻿using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Reflection.Emit;
using NUnit.Framework;

namespace MarsFramework
{
    internal class Profile
    {
        private RemoteWebDriver _driver;
        public Profile(RemoteWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #region  Initialize Web Elements 

        //Click on Full Name dropdown
        [FindsBy(How = How.XPath, Using = "(//I[@class='dropdown icon'])[2]")]
        private IWebElement FullNameDropdownBtn { get; set; }

        //Click on First Name
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[2]")]
        private IWebElement FirstName { get; set; }

        //Click on Last Name
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[3]")]
        private IWebElement LastName { get; set; }

        //Click on Save Full Name button
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='ui teal button'][text()='Save']")]
        private IWebElement SaveFullName { get; set; }

        //Full Name Label
        [FindsBy(How = How.XPath, Using = "//DIV[@class='title']")]
        private IWebElement FullName { get; set; }


        //Click on Edit Availability Time 
        [FindsBy(How = How.XPath, Using = "(//I[@class='right floated outline small write icon'])[1]")]
        private IWebElement EditAvailabilityTime { get; set; }
                
        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//SELECT[@class='ui right labeled dropdown']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Current Availability Time
        [FindsBy(How = How.XPath, Using = "(//SPAN)[10]")]
        private IWebElement CurrentAvailability { get; set; }
       

        //Click on Edit Availability Hour 
        [FindsBy(How = How.XPath, Using = "(//I[@class='right floated outline small write icon'])[2]")]
        private IWebElement EditAvailabilityHours { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//SELECT[@class='ui right labeled dropdown']")]
        private IWebElement AvailabilityHoursOpt { get; set; }

        //Current Availability Hours
        [FindsBy(How = How.XPath, Using = "(//SPAN)[12]")]
        private IWebElement CurrentHours { get; set; }

       
        //Click on edit Earn Target
        [FindsBy(How = How.XPath, Using = "(//I[@class='right floated outline small write icon'])[3]")]
        private IWebElement EditSalary { get; set; }

        //Click on salary option
        [FindsBy(How = How.XPath, Using = "//SELECT[@class='ui right labeled dropdown']")]
        private IWebElement SalaryOpt { get; set; }

        //Current Earn Target Value
        [FindsBy(How = How.XPath, Using = "(//SPAN)[14]")]
        private IWebElement CurrentSalaryValue { get; set; }
        

        //Click Edit Description
        [FindsBy(How = How.XPath, Using = "(//I[@class='outline write icon'])[1]")]
        private IWebElement EditProfileDescription { get; set; }

        //Enter Description Textarea
        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@name='value']")]
        private IWebElement DescriptionTextArea { get; set; }

        //Click Save Description
        [FindsBy(How = How.XPath, Using = "(//BUTTON[@class='ui teal button'][text()='Save'])[2]")]
        private IWebElement SaveDescription { get; set; }
        
        ////Current Profile Description
        //[FindsBy(How = How.XPath, Using = "(//SPAN)[16]")]
        //private IWebElement CurrentDescription { get; set; }


        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        //Display notification message
        //[FindsBy(How = How.XPath, Using = "//div[@class=\"ns-box-inner\"]")]
        //private IWebElement NotificationMsssage { get; set; }

        //Current Profile Description
        IWebElement CurrentDescription => _driver.FindElement(By.XPath("(//SPAN)[16]"));

        //DIV[@class='ns-box-inner'][text()='First character can only be digit or letters']
        IWebElement NotificationMesssage => _driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        private string notificationMessage;

        #endregion

        public void EditFullName()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            //Click on Edit button
            FullNameDropdownBtn.Click();

            FirstName.Clear();
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            LastName.Clear();
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            SaveFullName.Click();

            Thread.Sleep(1000);

            if (FullName.Text == GlobalDefinitions.ExcelLib.ReadData(2, "FullName"))
            {
                //Base.test.Log(LogStatus.Info, "Full Name updated Successfully");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Full Name updated Successfully");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Full Name Not Updated");
            }
        }

        public void SelectAvailability(string availability)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditAvailabilityTime.Click();
            Thread.Sleep(500);
            SelectElement selectAvailability = new SelectElement(AvailabilityTimeOpt);
            selectAvailability.SelectByText(availability);     
        }

        public string GetAvailabilityValue()
        {
            string availability = CurrentAvailability.Text;
            return availability;
        }

        public void SelectHours(string hours)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditAvailabilityHours.Click();
            Thread.Sleep(500);
            SelectElement selectHours = new SelectElement(AvailabilityHoursOpt);
            selectHours.SelectByText(hours);
        }

        public string GetHoursValue()
        {
            string hoursValue = CurrentHours.Text;
            return hoursValue;
        }

        public void EarnTarget(string salary)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditSalary.Click();
            Thread.Sleep(500);
            SelectElement salaryValue = new SelectElement(SalaryOpt);
            salaryValue.SelectByText(salary);
        }

        public string GetEarnTargetValue()
        {
            string salaryValue = CurrentSalaryValue.Text;
            return salaryValue;
        }

        public void AddDescription(string description)
        {
            Thread.Sleep(500);
            EditProfileDescription.Click();
            Thread.Sleep(1000);

            DescriptionTextArea.Clear();
            Thread.Sleep(1000);
            DescriptionTextArea.SendKeys(description);
            Thread.Sleep(1000);
            SaveDescription.Click();

            Thread.Sleep(500);         
            
            notificationMessage = NotificationMesssage.Text;          
            
        }

        public string GetDescriptionValue()
        {
            return CurrentDescription.Text;
        }

        public string GetNotificationMessage()
        {
            return notificationMessage;
        }

        /*
                    //---------------------------------------------------------
                    //Click on Add New Language button
                    AddNewLangBtn.Click();
                    Thread.Sleep(1000);
                    //Enter the Language
                    AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

                    //Choose Lang
                    ChooseLang.Click();
                    Thread.Sleep(1000);
                    ChooseLangOpt.Click();
                    Thread.Sleep(500);
                    AddLang.Click();
                    Base.test.Log(LogStatus.Info, "Added Language successfully");

                    //-----------------------------------------------------------
                    //Click on Add New Skill Button
                    AddNewSkillBtn.Click();
                    //Enter the skill 
                    AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

                    //Click the skill dropdown
                    ChooseSkill.Click();
                    Thread.Sleep(500);
                    ChooseSkilllevel.Click();
                    AddSkill.Click();
                    Thread.Sleep(500);
                    Base.test.Log(LogStatus.Info, "Added Skills successfully");

                    //---------------------------------------------------------
                    //Add Education
                    AddNewEducation.Click();
                    //Enter the University
                    EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

                    //Choose Country
                    ChooseCountry.Click();
                    Thread.Sleep(500);
                    //Choose Country Level
                    ChooseCountryOpt.Click();

                    //Choose Title
                    ChooseTitle.Click();
                    Thread.Sleep(500);
                    ChooseTitleOpt.Click();

                    //Enter Degree
                    Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

                    //Year of Graduation
                    DegreeYear.Click();
                    Thread.Sleep(500);
                    DegreeYearOpt.Click();
                    AddEdu.Click();
                    Thread.Sleep(500);
                    Base.test.Log(LogStatus.Info, "Added Education successfully");

                    //-------------------------------------------------
                    //Add new Certificate
                    AddNewCerti.Click();

                    //Enter Certificate Name
                    EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

                    //Enter Certified from
                    CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

                    //Enter the Year
                    CertiYear.Click();
                    Thread.Sleep(500);
                    CertiYearOpt.Click();
                    AddCerti.Click();
                    Thread.Sleep(500);
                    Base.test.Log(LogStatus.Info, "Added Certificate successfully");

                    //-----------------------------------------------------
                    //Add Description
                    Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
                    Thread.Sleep(500);
                    Save.Click();
                    Base.test.Log(LogStatus.Info, "Added Description successfully");
        */


    }
}