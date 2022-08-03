using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(String ctrlName, String value)
        {
            IWebElement combocontrol = driver.FindElement(By.XPath($"//input[@id='{ctrlName}-awed']"));
            combocontrol.Clear();
            combocontrol.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{ctrlName}-dropmenu']//li[text()='{value}']"));

        }
    }
}
