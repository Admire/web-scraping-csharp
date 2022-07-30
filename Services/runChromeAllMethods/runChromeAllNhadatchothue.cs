using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Text;
using web_scraping_csharp.Controllers;
using web_scraping_csharp.Services;

namespace web_scraping_csharp
{
    public partial class Form1 : Form
    {

        void RunChromeAllNhadatchothue()
        {

            // đóng toàn bộ tiến trình chrome trước khi mở ứng dụng
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }


            TableResult.Columns.Add("Url bài viết", 200);
            TableResult.Columns.Add("Tiêu đề", 250);
            TableResult.Columns.Add("Giá", 150);
            TableResult.Columns.Add("Giá/m2", 150);
            TableResult.Columns.Add("Diện tích", 150);
            TableResult.Columns.Add("Địa chỉ", 170);
            TableResult.Columns.Add("Ngày đăng bài", 150);
            TableResult.Columns.Add("Nên xem", 150);
            int i = 1;
            while (i < 100000000)
            {

                ChromeOptions chromeOptions = new ChromeOptions();
                // chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
                // chromeOptions.AddArgument("--profile-directory=Default");
                chromeOptions.AddArgument("--incognito");
                        chromeOptions.BinaryLocation = "Chromium\\102.0.5005.0\\chrome.exe";

                //ẩn terminal
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                ChromeDriver chromeDriver = new ChromeDriver(service, chromeOptions);
                chromeDriver.Manage().Window.Maximize();
                if (TableTitle.Text == "Kết quả")
                {
                    break;
                }
                string url = $"{new BatdongsanURL().Nhadatchothue}{i}";
                chromeDriver.Navigate().GoToUrl(url);

                IWebElement productList = chromeDriver.FindElement(By.Id("product-lists-web"));
                List<IWebElement> productItem = productList.FindElements(By.ClassName("js__card")).ToList();
                foreach (var product in productItem)
                {
                    if (TableTitle.Text == "Kết quả")
                    {
                        break;
                    }
                    ListViewItem item = new ListViewItem();
                    if (product.FindElements(By.TagName("a")).Count() > 0)
                    {
                        item.Text = product.FindElement(By.TagName("a")).GetAttribute("href");

                    }
                    else { item.Text = ""; }
                    if (product.FindElements(By.ClassName("js__card-title")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("js__card-title")).GetAttribute("innerText").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.ClassName("re__card-config-price")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-price")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-config-price_per_m2")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-price_per_m2")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-config-area")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-area")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-location")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-location")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.ClassName("re__card-published-info-published-at")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-published-info-published-at")).GetAttribute("aria-label").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.ClassName("re__icon-star--sm")).Count() > 0)
                    {
                        item.SubItems.Add("Nên xem");
                    }
                    else { item.SubItems.Add("Không nên xem"); }

                    TableResult.Items.Add(item);
                }
                i++;
            chromeDriver.Quit();
            }
        }

    }
}