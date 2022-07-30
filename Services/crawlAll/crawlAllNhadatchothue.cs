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

        void CrawlAllNhadatchothue()
        {

            int pageRangeNumber = Convert.ToInt32(PageRangeNum.Value + StartPageNum.Value - 1);
            int pageStartNumber = Convert.ToInt32(StartPageNum.Value);

            for (int i = pageStartNumber; i <= pageRangeNumber; i++)
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
                chromeDriver.Quit();
                    break;
                }
                string url = $"{new BatdongsanURL().Nhadatban}{i}";
                chromeDriver.Navigate().GoToUrl(url);

                IWebElement productList = chromeDriver.FindElement(By.Id("product-lists-web"));
                List<IWebElement> productItem = productList.FindElements(By.ClassName("js__card")).ToList();

                List<ListViewItem> insertItems = new();

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

                    insertItems.Add(item);
                }
                if (TableTitle.Text == "Kết quả")
                {
                    chromeDriver.Quit();
                    return;
                }else{
                    new NhadatchothueController().QueryInsertAll(insertItems);
                }
            chromeDriver.Quit();
            }
        }

    }
}