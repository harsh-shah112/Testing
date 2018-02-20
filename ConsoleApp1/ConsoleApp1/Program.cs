using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
			IWebDriver driver = new ChromeDriver(@"C:\New folder");
			driver.Url = "http://automationpractice.com";

			var row = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[2]/div[2]/a[1]/span"));
			row.Click();
			var row1= driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/span/span"));
			Thread.Sleep(1500);
			row1.Click();
			var row2 = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[2]/div[2]/a[2]/span"));
			row2.Click();
			var row3 = driver.FindElement(By.XPath("//*[@id=\"quantity_wanted_p\"]/a[2]/span"));
			row3.Click();
			var row4 = driver.FindElement(By.XPath("//*[@id=\"quantity_wanted_p\"]/a[2]/span"));
			row4.Click();
			var row5 = driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button/span"));
			row5.Click();
			var row6 = driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/span/span"));
			Thread.Sleep(1500);
			row6.Click();
			var tshirt = driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ul/li[3]/a"));
			tshirt.Click();
			var lowest = driver.FindElement(By.XPath("//*[@id=\"selectProductSort\"]/option[2]"));
			lowest.Click();
			var first = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/ul/li/div/div[2]/div[2]/a[1]/span"));
			first.Click();

			var cn = driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/span/span"));
			Thread.Sleep(1500);
			cn.Click();
			var cart = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[3]/div/div/div[3]/div/a/b"));
			cart.Click();
			var last2 = driver.FindElement(By.XPath("//*[@id=\"cart_quantity_up_1_1_0_0\"]/span/i"));
			last2.Click();
			var last3 = driver.FindElement(By.XPath("//*[@id=\"cart_quantity_up_1_1_0_0\"]/span/i"));
			last3.Click();
			var last4 = driver.FindElement(By.XPath("//*[@id=\"cart_quantity_up_1_1_0_0\"]/span/i"));
			last4.Click();
			var last5 = driver.FindElement(By.XPath("//*[@id=\"cart_quantity_up_1_1_0_0\"]/span/i"));
			last5.Click();
			var checkout = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/p[2]/a[1]/span"));
			checkout.Click();
			

		}
	}
}
