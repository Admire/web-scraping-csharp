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

        void CrawlAllDuan()
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
                string url = $"{new BatdongsanURL().Duan}{i}";
                chromeDriver.Navigate().GoToUrl(url);
                List<ListViewItem> insertItems = new();


                List<IWebElement> productItem = chromeDriver.FindElements(By.ClassName("js__project-card")).ToList();
                foreach (var product in productItem)
                {
                    if (TableTitle.Text == "Kết quả")
                    {
                        break;
                    }
                    ListViewItem item = new ListViewItem();

                    //url
                    if (product.FindElements(By.TagName("a")).Count() > 0)
                    {
                        item.Text = product.FindElement(By.TagName("a")).GetAttribute("href");

                    }
                    else { item.Text = ""; }

                    // tiêu đề
                    if (product.FindElements(By.ClassName("re__prj-card-title")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__prj-card-title")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    // giá/m2, diện tích, số căn hộ, số tòa nhà
                    string[] arrElements = { "Trống", "Trống", "Trống", "Trống" };
                    List<IWebElement> groupElements = product.FindElements(By.ClassName("re__prj-card-config-value")).ToList();
                    foreach (var piece in groupElements)
                    {
                        if (piece.GetAttribute("innerText").Contains("/m²"))
                        {
                            arrElements[0] = piece.GetAttribute("innerText").Trim();
                        }
                        if (piece.GetAttribute("innerText").Contains("ha") || piece.GetAttribute("innerText").Contains(" m²"))
                        {
                            arrElements[1] = piece.GetAttribute("innerText").Trim();
                        }
                        if (piece.FindElements(By.ClassName("re__icon-home--sm")).Count() > 0)
                        {
                            arrElements[2] = piece.GetAttribute("innerText").Trim();
                        }
                        if (piece.FindElements(By.ClassName("re__icon-building--sm")).Count() > 0)
                        {
                            arrElements[3] = piece.GetAttribute("innerText").Trim();
                        }
                    }

                    foreach (string element in arrElements)
                    {
                        item.SubItems.Add(element);
                    }
                    // địa chỉ
                    if (product.FindElements(By.ClassName("re__prj-card-location")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__prj-card-location")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    // công ty
                    if (product.FindElement(By.ClassName("re__prj-card-contact")).GetAttribute("innerText").Trim() != "")
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__prj-card-contact")).GetAttribute("innerText").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    // tình trạng
                    if (product.FindElements(By.ClassName("re__project-open")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__project-open")).GetAttribute("innerText").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    insertItems.Add(item);
                }
                if (TableTitle.Text == "Kết quả")
                {
                    chromeDriver.Quit();
                    return;
                }else{
                    new DuanController().QueryInsertAll(insertItems);
                }
            chromeDriver.Quit();
            }
        }

    }
}