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
        //những method khác có điều kiện là khi label 2 là Kết quả thì sẽ dừng vòng lặp đang chạya
        void StopGetData()
        {
            TableTitle.Text = "Kết quả";
            CrawlSomePagesButton.Enabled = true;
            CrawlAllPagesButton.Enabled = true;
            CrawlAllButton.Enabled = true;
        }
    }
}