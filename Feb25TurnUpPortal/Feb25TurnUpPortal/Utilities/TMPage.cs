using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal.Utilities
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)   //IWebDriver driver is the parameter of CreateTimeRecord method
        {
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select time from drop down
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typecodeDropdown.Click();

            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeoption.Click();

            //type code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TA PROGRAMME");

            //type description into description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("this ia description");

            //type price into price textbox
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");
           
            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);
           
            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if time record has been created successfully
            IWebElement gotoLast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLast.Click();


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "TA PROGRAMME")
            {
                Console.WriteLine("time successfully recorded");
            }
            else
            {
                Console.WriteLine("new item not found");

            }
        }
public void EditTimeRecord(IWebDriver driver)
        {
            //edit code
        }
        public void DeleteTimeRecord(IWebDriver driver) 
        { 
        //delete code
        }


    }

    
}
