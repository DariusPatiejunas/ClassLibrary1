// 2021-11-17, Darius Patiejunas,PVMsk
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewFolder1Page
{
    class PVMskaiciuoklePage
    {
        private static IWebDriver _driver;

        private IWebElement _PvmTarifas5 => _driver.FindElement(By.Id("vat_percent"));
        private IWebElement _skaicius => _driver.FindElement(By.XPath("//option[. = '5%']"));
        IWebElement _sumabePVM => _driver.FindElement(By.Id("amount_wo_vat"));

        public PVMskaiciuoklePage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void PvmTarifas5(string vat_percent)
        {
            _PvmTarifas5.SendKeys(vat_percent);
        }

        public void SumabePVM(string amount_wo_vat)
        {
            _sumabePVM.Clear();
            _sumabePVM.SendKeys("500");
        }
    }
}
