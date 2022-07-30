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
        void SaveToDbTintuc()
        {
            List<ListViewItem> item = new();
            for (int i = 0; i < TableResult.Items.Count; i++)
            {
                item.Add(TableResult.Items[i]);
            }
            new TintucController().QueryInsertAll(item);
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu tin tức");
        }

    }
}