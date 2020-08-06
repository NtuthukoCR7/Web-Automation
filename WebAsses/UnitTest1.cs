using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebAsses.Models;

namespace WebAsses
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    
    [TestCase("Tuts", "Chakalaka","tets","test","test@test.com","123454")]
    [TestCase("Mandla", "mandla", "tets1", "test1", "tes1t@test.com", "1123454")]
    public void Add_New_User(string firstName, string lname,string username, string pass,string email, string cellphone)
    {
      var user = new User {FirstName = firstName, LastName = lname, UserName = username, Password = pass, Email = email, CellPhone = cellphone};

     
      //create the reference for our browser
      var driver = GetWebDriver();
      NavigateToURL(driver);

      //find the element
      AddNewUSer(driver, user);

    }

    private static void AddNewUSer(IWebDriver driver, User user)
    {
      IWebElement AddUser = driver.FindElement(By.XPath("//button[@class='btn btn-link pull-right'][contains(.,'Add User')]"));
      AddUser.Click();
      Thread.Sleep(1000);

      IWebElement FirstName = driver.FindElement(By.Name("FirstName"));
      FirstName.SendKeys(user.FirstName);
      Thread.Sleep(1000);


      IWebElement LastName = driver.FindElement(By.Name("LastName"));
      LastName.SendKeys(user.LastName);
      Thread.Sleep(1000);

      IWebElement UserName = driver.FindElement(By.Name("UserName"));
      UserName.SendKeys(user.UserName);
      Thread.Sleep(1000);

      IWebElement password = driver.FindElement(By.Name("Password"));
      password.SendKeys(user.Password);
      Thread.Sleep(1000);

      IWebElement radio = driver.FindElement(By.XPath("(//input[contains(@type,'radio')])[1]"));
      radio.Click();
      Thread.Sleep(1000);

      new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'RoleId')]"))).SelectByIndex(1);
      Thread.Sleep(1000);

      IWebElement Email = driver.FindElement(By.Name("Email"));
      Email.SendKeys(user.Email);
      Thread.Sleep(1000);

      IWebElement Mobilephone = driver.FindElement(By.Name("Mobilephone"));
      Mobilephone.SendKeys(user.CellPhone);
      Thread.Sleep(1000);

      IWebElement Save = driver.FindElement(By.XPath("//button[@ng-click='save(user)'][contains(.,'Save')]"));
      Save.Click();
    }

    private static IWebDriver GetWebDriver()
    {
      IWebDriver driver = new ChromeDriver();
      return driver;
    }

    private static void NavigateToURL(IWebDriver driver)
    {
      driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/webtables/");
      Thread.Sleep(1000);
    }
  }
}