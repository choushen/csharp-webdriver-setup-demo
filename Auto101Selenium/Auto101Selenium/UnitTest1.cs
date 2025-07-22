using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;



namespace Auto101Selenium
{
    public class UnitTest1 : IDisposable
    {

        private WebDriver _driver;
        private EdgeOptions _edgeOptions;


        // Implement this
        public void WaitAndClick()
        {

        }


        // Implement this
        public void ScrollAndClick()
        {

        }

        public UnitTest1()
        {
            _edgeOptions = new EdgeOptions();

            // Default Edge browser installation location
            _edgeOptions.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            // Replace <path-to-driver> with the path to the edgedriver in the resources folder (download the latest driver here and drop it into the project resource folder: https://developer.microsoft.com/en-gb/microsoft-edge/tools/webdriver?form=MA13LH)
            var driverPath = @"<path-to-driver>\Resources\msedgedriver.exe";

            _edgeOptions.AddArgument("--start-maximized");

            _driver = new EdgeDriver(driverPath, _edgeOptions);
        }

        [Fact]
        public void Test1()
        {
            //_driver.Navigate().GoToUrl("https://www.google.co.uk");

            _driver.Url = "https://www.google.com";

            var actions = new Actions(_driver);
            actions.ScrollByAmount(0, 300).Perform();

            // I want to wait for this element for 5 seconds, check to see if it's there every 250 ms
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5))
            {
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };

            // implicit wait _driver - tells the driver to wait for 5 seconds
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Getting the element using a fluent wait (same as explicit only with polling)
            var btnAcceptAll = wait.Until(drvr =>
            {
                try
                {
                    var element = drvr.FindElement(By.XPath("//div[text()=\"Accept all\"]"));

                    return (element.Displayed && element.Enabled) ? element : null;
                }
                catch (NoSuchElementException e)
                {
                    // a little more info from the error
                    string? errorMsg = e.StackTrace; // optionals
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
            });

            btnAcceptAll.Click();

            IWebElement searchBtn = _driver.FindElement(By.XPath("(//input[@value=\"Google Search\" and @role=\"button\"])[2]"));

            var dog = searchBtn.GetAttribute("value");

            Assert.Equal("Google Search", dog);
        }

        // Forces the driver to close and dispose of resources by implementing IDisposable this method is called when the test is done
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}