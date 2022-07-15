﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Text;
using web_scraping_csharp.Controllers;
using web_scraping_csharp.Services;

namespace web_scraping_csharp
{
    public partial class Form1 : Form
    {

        void runChromeNhamoigioi()
        {

            // đóng toàn bộ tiến trình chrome trước khi mở ứng dụng
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }



            int pageRangeNumber = Convert.ToInt32(pageRangeNum.Value + startPageNum.Value - 1);
            int pageStartNumber = Convert.ToInt32(startPageNum.Value);

            listView1.Columns.Add("Url bài viết", 200);
            listView1.Columns.Add("Tên nhà môi giới", 300);
            listView1.Columns.Add("Địa chỉ", 250);
            listView1.Columns.Add("Điện thoại", 150);
            listView1.Columns.Add("Email", 200);
            for (int i = pageStartNumber; i <= pageRangeNumber; i++)
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                // chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
                // chromeOptions.AddArgument("--profile-directory=Default");
                chromeOptions.AddArgument("--incognito");
                //ẩn terminal
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                ChromeDriver chromeDriver = new ChromeDriver(service, chromeOptions);
                chromeDriver.Manage().Window.Maximize();
                if (label2.Text == "Kết quả")
                {
                    break;
                }
                string url = $"{new batdongsanURL().nhamoigioi}{i}";
                chromeDriver.Navigate().GoToUrl(url);

                IWebElement productList = chromeDriver.FindElement(By.Id("broker-page"));
                List <IWebElement> productItem = productList.FindElements(By.ClassName("re__broker-item")).ToList();
                foreach (var product in productItem)
                {
                    if (label2.Text == "Kết quả")
                    {
                        break;
                    }
                    ListViewItem item = new ListViewItem();

                    if (product.FindElements(By.ClassName("re__broker-title--xs")).Count() > 0)
                    {
                        item.Text = product.FindElement(By.ClassName("re__broker-title--xs")).GetAttribute("href").Trim();
                        item.SubItems.Add(product.FindElement(By.ClassName("re__broker-title--xs")).GetAttribute("innerText").Trim());
                    }
                    else { item.Text = "Trống"; }
                    if (product.FindElements(By.CssSelector("div.re__broker-address > span")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.CssSelector("div.re__broker-address > span")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.CssSelector("div.re__broker-address >div> span")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.CssSelector("div.re__broker-address >div> span")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.Id("lnkSendEmail")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.Id("lnkSendEmail")).GetAttribute("data-email"));
                    }
                    else { item.SubItems.Add("Trống"); }

                    listView1.Items.Add(item);
                }
            chromeDriver.Quit();
            }
        }

    }
}