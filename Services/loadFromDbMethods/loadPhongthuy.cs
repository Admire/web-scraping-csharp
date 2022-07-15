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
        void loadPhongthuy()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 400);
            listView1.Columns.Add("Tiêu đề", 700);
            List<ListViewItem> phongthuys = new phongthuyController().queryFetchAll();
            foreach (ListViewItem phongthuy in phongthuys)
            {
                listView1.Items.Add(phongthuy);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu phong thủy");
        }
    }
}