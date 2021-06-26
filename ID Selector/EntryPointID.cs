using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPointID
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/id";
        string photoID = "testImage";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        try
        {
            IWebElement element = driver.FindElement(By.Id(photoID));
            GreenMessage("The PhotoID element is available");
        }
        catch {
            RedMessage("Unable to find the PhotoID Element");
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
