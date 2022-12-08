using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace PlaywrightTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();
        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false});
        
        //Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://google.com");
        await page.GetByTitle("Search").FillAsync("Playwright");
        System.Threading.Thread.Sleep(3000);
        
        

    }
}