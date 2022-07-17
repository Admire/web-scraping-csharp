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
            label2.Text = "Kết quả";
            button1.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;
        }
    }
}