using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal.Utilities;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal.Tests
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            //navigate to time and material page 
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();
            
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]", 10);
            IWebElement timeandMaterialoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandMaterialoption.Click();

            
        }
    }
}
