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
        void loadTintuc()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 400);
            listView1.Columns.Add("Tiêu đề", 700);
            List<ListViewItem> tintucs = new tintucController().queryFetchAll();
            foreach (ListViewItem tintuc in tintucs)
            {
                listView1.Items.Add(tintuc);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu tin tức");
        }
    }
}