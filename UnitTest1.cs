using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace lb4
{
    public class Tests
    {
        [Test]
        public void Login()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            Thread.Sleep(10000);
            IWebElement login = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));

            login.SendKeys("Admin");
            password.SendKeys("admin123");
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("button")).Click();

            Thread.Sleep(1000);

            driver.Quit();
        }
        [Test]
        public void LoginPage()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            Thread.Sleep(10000);
            IWebElement login = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));

            Thread.Sleep(1000);
            login.SendKeys("Admin");
            password.SendKeys("admin123");
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("button")).Click();

            String expectedUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
            String actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);

            driver.Quit();
        }
        [Test]
        public void FalseLogin()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            Thread.Sleep(10000);
            IWebElement login = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Name("password"));

            login.SendKeys("Admin");
            password.SendKeys("123");
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("button")).Click();

            Thread.Sleep(1000);
            String expectedUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            String actualUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);

            driver.Quit();

        }
    }
}