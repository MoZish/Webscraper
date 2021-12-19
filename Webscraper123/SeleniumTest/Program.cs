using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder stringOutput = new StringBuilder();
            //string youtubeCsv = "C:/Users/moham/source/repos/SeleniumTest/youtube.csv";
            //IWebDriver driver = new ChromeDriver();
            //Thread.Sleep(2000);
            //driver.Navigate().GoToUrl("https://www.youtube.com/");
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[text()='I Agree']")).Click();
            //Thread.Sleep(2000);
            //string search = Console.ReadLine();
            //driver.Navigate().GoToUrl(@"https://www.youtube.com/results?search_query=" + search);
            //Thread.Sleep(2000);

            //var list = driver.FindElements(By.TagName("ytd-video-renderer"));
            //Console.WriteLine(list.Count);
            //Thread.Sleep(2000);

            //driver.FindElement(By.TagName("ytd-toggle-button-renderer")).Click();
            //IWebElement uploadDate = driver.FindElement(By.XPath("//*[@id='label']/yt-formatted-string"));
            //uploadDate.Click();
            //Thread.Sleep(2000);

            //for (int i = 0; i <= 5; i++)
            //{
            //    String href = list[i].FindElement(By.TagName("a")).GetAttribute("href");
            //    String title = list[i].FindElement(By.TagName("h3")).Text;
            //    String uploader = list[i].FindElement(By.Id("channel-info")).Text;
            //    IWebElement Views = list[i].FindElement(By.Id("metadata-line"));
            //    String views = Views.FindElement(By.XPath("./span[1]")).Text;
            //    String videoData = string.Join(";", href) + ";" + string.Join(";", title) + ";" + string.Join(";", uploader) + ";" + string.Join(";", views);
            //    stringOutput.AppendLine(videoData);
            //}

            //StringBuilder stringOutput = new StringBuilder();
            //string indeedCsv = "C:/Users/moham/source/repos/SeleniumTest/jobs.csv";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://be.indeed.com/");
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[text()='Accept All Cookies']")).Click();
            //Thread.Sleep(2000);
            //string search = Console.ReadLine();
            //Thread.Sleep(2000);
            //IWebElement searchbar = driver.FindElement(By.Name("q"));
            //searchbar.SendKeys(search);
            //searchbar.SendKeys(Keys.Enter);
            //Thread.Sleep(2000);

            //Thread.Sleep(2000);

            //driver.FindElement(By.ClassName("yosegi-FilterPill-pillLabel")).Click();
            //IWebElement threedays = driver.FindElement(By.XPath("//*[text()='Last 3 days']"));
            //threedays.Click();

            //Thread.Sleep(5000);

            //driver.FindElement(By.ClassName("popover-x-button-close")).Click();

            //Thread.Sleep(2000);

            //var list = driver.FindElements(By.ClassName("result"));
            //Console.WriteLine(list.Count);
            //Thread.Sleep(2000);

            //for (int i = 0; i <= 5; i++)
            //{
            //    IWebElement jobTitle = list[i].FindElement(By.ClassName("jobTitle"));
            //    jobTitle = jobTitle.FindElement(By.XPath("./span"));
            //    IWebElement company = list[i].FindElement(By.ClassName("companyName"));
            //    IWebElement jobLocation = list[i].FindElement(By.ClassName("companyLocation"));
            //    String jobData = string.Join(";", jobTitle.Text) + ";" + string.Join(";", company.Text) + ";" + string.Join(";", jobLocation.Text);
            //    stringOutput.AppendLine(jobData);
            //}

            //File.WriteAllText(indeedCsv, stringOutput.ToString());
            //Thread.Sleep(5000);


            StringBuilder stringOutput = new StringBuilder();
            string indeedCsv = "C:/Users/moham/source/repos/SeleniumTest/bol.csv";


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bol.com/be/nl/");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Accepteren']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Doorgaan']")).Click();
            Thread.Sleep(3000);
            string search = Console.ReadLine();
            IWebElement searchbar = driver.FindElement(By.Name("searchtext"));

            searchbar.SendKeys(search);
            searchbar.SendKeys(Keys.Enter);

            Thread.Sleep(3000);
            driver.FindElement(By.Name("sort")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[text()='Prijs laag - hoog']")).Click();

            var list = driver.FindElements(By.ClassName("product-item--row"));
            Console.WriteLine(list.Count);
            Thread.Sleep(2000);

            for (int i= 0; i < list.Count; i++)
            {
                IWebElement titleElement = driver.FindElement(By.ClassName("product-title--inline"));
                titleElement = titleElement.FindElement(By.XPath("./a"));
                String jobData = string.Join(";", titleElement.Text) + ";";
                stringOutput.AppendLine(jobData);

            }
            File.WriteAllText(indeedCsv, stringOutput.ToString());

        }
    }
}


//console.write("test case started ");
//iwebdriver driver = new chromedriver();
//driver.navigate().gotourl("https://www.google.com/");
//thread.sleep(2000);
//driver.findelement(by.xpath("//*[text()='ik ga akkoord']")).click();
//thread.sleep(2000);
//iwebelement ele = driver.findelement(by.name("q"));
//ele.sendkeys("javatpoint tutorials");
//thread.sleep(2000);
//iwebelement ele1 = driver.findelement(by.name("btnk"));
//ele1.click();
//thread.sleep(3000);
//driver.close();
//console.write("test case ended ");