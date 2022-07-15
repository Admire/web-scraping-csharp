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
        void loadNoingoaithat()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 400);
            listView1.Columns.Add("Tiêu đề", 700);
            List<ListViewItem> noingoaithats = new noingoaithatController().queryFetchAll();
            foreach (ListViewItem noingoaithat in noingoaithats)
            {
                listView1.Items.Add(noingoaithat);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu Nội-Ngoại thất");
        }
    }
}