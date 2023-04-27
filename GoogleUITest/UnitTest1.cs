using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleUITest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestSearchStreettFighterVThenVerifyStreetFighterVIsDisplayed()
    {

        //This line of code initializes a locator named googleSearchBar of type
        //By with a value of Name equal to "q", which can be used to find the
        //corresponding element on a web page.
        By googleSearchBar = By.Name("q");
        By googleSearchButton = By.Name("btnk");
        By googleSearchResult = By.XPath(".//div//h3[text()='Street Fighter V - Wikipedia']");

        //This line of code creates a new instance of the ChromeDriver class
        //and assigns it to a variable named webDriver of type IWebDriver,
        //which can be used to control the Chrome web browser.
        IWebDriver webDriver = new ChromeDriver();
        webDriver.Navigate().GoToUrl("https://www.google.com/");

        webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V - Wikipedia");
        webDriver.FindElement(googleSearchButton).Click();

        var actualResultText = webDriver.FindElement(googleSearchResult);
        Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V - Wikipedia"));

        webDriver.Quit();





    }
}
