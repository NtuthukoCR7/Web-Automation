using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace Web_Automation
{
  class Program
  {
    static void Main(string[] args)
    {

      var cell = 0791777900;
      //create the reference for our browser
      IWebDriver driver = new ChromeDriver();
      driver.Navigate().GoToUrl("http://www.way2automation.com/angularjs-protractor/webtables/");
      Thread.Sleep(1000);

      //find the element
      IWebElement AddUser = driver.FindElement(By.XPath("//button[@class='btn btn-link pull-right'][contains(.,'Add User')]"));
      AddUser.Click();
      Thread.Sleep(1000);

      IWebElement FirstName = driver.FindElement(By.Name("FirstName"));
      FirstName.SendKeys("Ntuthuko");
      Thread.Sleep(1000);


      IWebElement LastName = driver.FindElement(By.Name("LastName"));
      LastName.SendKeys("Ntshakala");
      Thread.Sleep(1000);

      IWebElement UserName = driver.FindElement(By.Name("UserName"));
      UserName.SendKeys("NtuthukoNtshakala");
      Thread.Sleep(1000);

      IWebElement password = driver.FindElement(By.Name("Password"));
      password.SendKeys("pasword12345");
      Thread.Sleep(1000);

      IWebElement radio = driver.FindElement(By.XPath("(//input[contains(@type,'radio')])[1]"));
      radio.Click();
      Thread.Sleep(1000);

      new SelectElement(driver.FindElement(By.XPath("//select[contains(@name,'RoleId')]"))).SelectByIndex(1);
      Thread.Sleep(1000);

      IWebElement Email = driver.FindElement(By.Name("Email"));
      Email.SendKeys("Ntshakala@gmil.com");
      Thread.Sleep(1000);

      IWebElement Mobilephone = driver.FindElement(By.Name("Mobilephone"));
      Mobilephone.SendKeys(""+cell);
      Thread.Sleep(1000);

      IWebElement Save = driver.FindElement(By.XPath("//button[@ng-click='save(user)'][contains(.,'Save')]"));
      Save.Click();
    


      

    }
  }
}
