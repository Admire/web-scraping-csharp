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
        void LoadNoingoaithat()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url bài viết", 400);
            TableResult.Columns.Add("Tiêu đề", 700);
            List<ListViewItem> Noingoaithats = new NoingoaithatController().QueryFetchAll();
            foreach (ListViewItem Noingoaithat in Noingoaithats)
            {
                TableResult.Items.Add(Noingoaithat);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu Nội-Ngoại thất");
        }
    }
}