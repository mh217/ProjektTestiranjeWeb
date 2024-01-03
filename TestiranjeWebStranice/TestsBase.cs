using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using static System.Net.WebRequestMethods;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace ParallelTests
{
    public class TestsBase
    {

        protected IWebDriver driver;

        public void Setup(String browserName)
        {
            if (browserName.Equals("edge"))
                driver = new EdgeDriver();
            else if (browserName.Equals("chrome"))
                driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "edge", "chrome" };
            foreach (String browser in browsers)
            {
                yield return browser;
            }
        }
    }
}