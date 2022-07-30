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
        void SaveToDbDuan()
        {
            List<ListViewItem> item = new();
            for (int i = 0; i < TableResult.Items.Count; i++)
            {
                item.Add(TableResult.Items[i]);
            }
            new DuanController().QueryInsertAll(item);
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu dự án");
        }

    }
}