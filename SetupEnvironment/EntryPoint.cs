using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/name");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("The input text field on the Name page is available.");
        }
        else {
            RedMessage("The input text field on the Name page is not available.");
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