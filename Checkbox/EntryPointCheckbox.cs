using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPointCheckbox
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/check-button-test-3";
        string option = "3";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector(".entry-content > p:nth-child(8) > input:nth-child(" + option + ")"));

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked.");
        }
        else
        {
            Console.WriteLine("The checkbox is not checked.");
        }

        checkBox.Click();

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked.");
        }
        else
        {
            Console.WriteLine("The checkbox is not checked.");
        }

        driver.Quit();
    }
}

