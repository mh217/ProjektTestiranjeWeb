using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using static System.Net.WebRequestMethods;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using ParallelTests;

namespace TestiranjeWebStranice
{
    public class Tests : TestsBase
    {

        private string baseURL;

        [SetUp]
        public void Setup()
        {
            baseURL = "https://demowebshop.tricentis.com/";
        }


        //Testiranje pretrage 
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test1(String browserName)
        {
            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[3]/form/input[1]")).SendKeys("Laptop");
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[3]/form/input[2]")).Click();

        }

        //Testiranje sortiranja 
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test2(String browserName)
        {
            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/ul[1]/li[1]/a")).Click();
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("products-orderby")));
            dropdown.SelectByText("Price: Low to High");

        }

        //Testiranje registracije 
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test3(String browserName)
        {
            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[1]/a")).Click();
            driver.FindElement(By.Id("gender-female")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("Jane");
            driver.FindElement(By.Id("LastName")).SendKeys("Dow");
            driver.FindElement(By.Id("Email")).SendKeys("janedow@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("mojalozinka");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("mojalozinka");
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/form/div/div[2]/div[4]/input")).Click();
            Thread.Sleep(2000);
        }

        //Testiranje Login-a
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test4(String browserName)
        {

            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("janedow@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("mojalozinka");
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();
        }

        //Testiranje dodavanja u košaricu 
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test5(String browserName)
        {
            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("janedow@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("mojalozinka");
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input")).Click();
            driver.FindElement(By.ClassName("cart-label")).Click();

        }


        //Testiranje kupnje
        [Test]
        [TestCaseSource(typeof(TestsBase), "BrowserToRunWith")]
        public void Test6(String browserName)
        {
            Setup(browserName);
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("janedow@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("mojalozinka");
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();
            driver.FindElement(By.ClassName("cart-label")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            driver.FindElement(By.Name("checkout")).Click();
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("BillingNewAddress_CountryId")));
            dropdown.SelectByText("Croatia");
            driver.FindElement(By.Id("BillingNewAddress_City")).SendKeys("Osijek");
            driver.FindElement(By.Id("BillingNewAddress_Address1")).SendKeys("Vukovarska ulica");
            driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).SendKeys("31000");
            driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).SendKeys("0998645828");
            driver.FindElement(By.XPath("//*[@id=\"billing-buttons-container\"]/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/ol/li[2]/div[2]/div/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/ol/li[3]/div[2]/form/div[2]/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/ol/li[4]/div[2]/div/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/ol/li[5]/div[2]/div/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/ol/li[6]/div[2]/div[2]/input")).Click();
            Thread.Sleep(5000);


        }



    }
}