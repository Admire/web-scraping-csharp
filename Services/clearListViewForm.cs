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
            listView1.Clear();
            if (button1.Enabled == true || button7.Enabled == true || button6.Enabled == false)
            {
                label2.Text = "Danh sách trống";
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
            }
        }
    }
}