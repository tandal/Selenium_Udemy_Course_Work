using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPointInputTextBox
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/text-input-field/";
       
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text!");

        //Adding sleep to visually see the text entry
        Thread.Sleep(3000);

        string textMaxLentgh = textBox.GetAttribute("maxlength");
        YellowMessage("The max length of the textbox is " + textMaxLentgh);

        textBox.Clear();

        //Adding sleep to see the clear method in action
        Thread.Sleep(3000);

        driver.Quit();
    }

    private static void YellowMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

