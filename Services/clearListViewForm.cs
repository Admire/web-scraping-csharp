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
        void ClearListView()
        {
            TableResult.Clear();
            if (CrawlSomePagesButton.Enabled == true || CrawlAllPagesButton.Enabled == true || StopCrawl.Enabled == false)
            {
                TableTitle.Text = "Danh sách trống";
                SaveToDbButton.Enabled = false;
                SaveToFileButton.Enabled = true;
                StopCrawl.Enabled = false;
            }
        }
    }
}