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
        void LoadPhongthuy()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url bài viết", 400);
            TableResult.Columns.Add("Tiêu đề", 700);
            List<ListViewItem> Phongthuys = new PhongthuyController().queryFetchAll();
            foreach (ListViewItem Phongthuy in Phongthuys)
            {
                TableResult.Items.Add(Phongthuy);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu phong thủy");
        }
    }
}