using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace test_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\dixit\Downloads\chromedriver_win32");
            driver.Url = "http://automationpractice.com"; // open the website
            driver.FindElement(By.XPath("//a[@href='#homefeatured']")).Click(); // click on the Popular
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/div[2]/a[1]")).Click();//Add to cart first product
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span")).Click(); // close the pop-up box
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[2]/div[2]/a[2]")).Click(); //click on more button of second product
            driver.FindElement(By.Id("quantity_wanted")).Clear(); // clear the quantity textbox
            driver.FindElement(By.Id("quantity_wanted")).SendKeys("3"); //write 3 in quantity textbox
            driver.FindElement(By.Name("Submit")).Click(); // click on add to cart button
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span")).Click(); // close the pop-up box
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a")).Click(); // click on Tshirt 
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("selectProductSort"))); //sorting
            dropdown.SelectByText("Price: Lowest first");
            driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span")).Click();  // add to cart
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span")).Click(); //close the pop-up box
            driver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a")).Click(); // Go to cart
            driver.FindElement(By.Name("quantity_1_1_0_0")).Clear(); // clear first product quantity
            driver.FindElement(By.Name("quantity_1_1_0_0")).SendKeys("5"); //write 5 in quantity
            driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]")).Click(); //check out
            driver.Close();
        }
    }
}
