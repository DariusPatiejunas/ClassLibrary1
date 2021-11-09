// 2021-11-08, Darius Patiejunas, vartutechnika
using System;

namespace ClassLibrary4
{
    internal class WebDriverWait
    {
        private IWebDriver driver;
        private TimeSpan timeSpan;

        public WebDriverWait(IWebDriver driver, TimeSpan timeSpan)
        {
            this.driver = driver;
            this.timeSpan = timeSpan;
        }
    }
}