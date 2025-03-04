using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Feb25TurnUpPortal.Pages
{
    public class LoginPage       //LoginPage is my class
    {
        //Functions that allow users to login to turnup portal
        public void LoginActions(IWebDriver driver)
        {
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            
            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver, "Id", "Password", 7);
            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Identify LOGIN BUTTON and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);


        }
    }
}
