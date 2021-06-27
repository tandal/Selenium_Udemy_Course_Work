using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPointCssAndXpath
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/css-path";
        string xPathSearch = "//input[@name='s']";

        //In chrome dev tools when you "copy selector" you are getting the css path.
        string cssPathSearch = "#search-2 > form > label > input";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement cssSearchElement = driver.FindElement(By.CssSelector(cssPathSearch));
        IWebElement xPathSearchElement = driver.FindElement(By.XPath(xPathSearch));

        if (cssSearchElement.Displayed)
        {
            GreenMessage("I can see the css Element");
        }
        else {
            RedMessage("I can not see the css Element");
        }


        if (xPathSearchElement.Displayed)
        {
            GreenMessage("I can see the xPath Element");
        }
        else
        {
            RedMessage("I can not see the xPath Element");
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
