using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2_Class_Practise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Attributes
        //assigning Owner (not more than 1)
        [Owner("Nabeel")]
        //Desciription
        [Description("Test is demo Test")]
        //WorkItem Different Tasks jo kisi kam k soorat me hon like Epic, Feature, Task, User story etc. Yhan lkhe sy ye isk sth associate ni hua hai this is just for documentation purpose
        [WorkItem(1123)]
        //ye multiple time askata hai
        [TestCategory("BAT"), TestCategory("Critical"), TestCategory("Positive") ]
        public void TestCase_001()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("Nabeel0075");
            driver.FindElement(By.Name("password")).SendKeys("NabeelTester123");
            driver.FindElement(By.ClassName("login_button")).Click();

            driver.Close();

        }
        [TestMethod]
        //Attributes
        //assigning Owner (not more than 1)
        [Owner("Usama")]
        //Desciription
        [Description("Test is demo Test")]
        //WorkItem Different Tasks jo kisi kam k soorat me hon like Epic, Feature, Task, User story etc. Yhan lkhe sy ye isk sth associate ni hua hai this is just for documentation purpose
        [WorkItem(1124)]
        //ye multiple time askata hai
        [TestCategory("BAT"), TestCategory("Critical"), TestCategory("Positive")]
        public void TestCase_002()
        {

        }
    }
}
