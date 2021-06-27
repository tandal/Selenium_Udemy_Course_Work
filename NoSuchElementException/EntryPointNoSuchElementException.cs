using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPointNoSuchElementException
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/css-path";
        string xPathSearch = "//input[@name='s']";

        //In chrome dev tools when you "copy selector" you are getting the css path.
        string cssPathSearch = "#search-2 > form > label > input";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement cssSearchElement;
        IWebElement xPathSearchElement;

        try
        {
            cssSearchElement = driver.FindElement(By.CssSelector(cssPathSearch));
            if (cssSearchElement.Displayed)
            {
                GreenMessage("I can see the css path element.");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can not see the css path element");
        }

        try
        {
            xPathSearchElement = driver.FindElement(By.XPath(xPathSearch));
            if (xPathSearchElement.Displayed)
            {
                GreenMessage("I can see the xpath path element.");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can not see the xpath path element");
        }

        driver.Quit();
    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}