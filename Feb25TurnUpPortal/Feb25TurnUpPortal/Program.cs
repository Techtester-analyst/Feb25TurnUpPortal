using Feb25TurnUpPortal.Pages;
using Feb25TurnUpPortal.Tests;
using Feb25TurnUpPortal.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

internal class Program
{
    private static void Main(string[] args)    //main Method
    {
        //Open the chrome Browser
        IWebDriver driver = new ChromeDriver();   //driver name of variable

        //implicit wait
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();  //loginPageObj -----instance , LoginPage is class , Starting a class here
        loginPageObj.LoginActions(driver);

        //HomePage object initialization and definition

        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TMPage object initialization and definition
        TMPage tMPageObj = new TMPage();
        tMPageObj.CreateTimeRecord(driver);

        //edit time record
        tMPageObj.EditTimeRecord(driver);

        tMPageObj.DeleteTimeRecord(driver);








    }



}