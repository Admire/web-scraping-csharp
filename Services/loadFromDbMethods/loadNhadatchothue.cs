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
        void LoadNhadatchothue()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url bài viết", 200);
            TableResult.Columns.Add("Tiêu đề", 250);
            TableResult.Columns.Add("Giá", 150);
            TableResult.Columns.Add("Giá/m2", 150);
            TableResult.Columns.Add("Diện tích", 150);
            TableResult.Columns.Add("Địa chỉ", 170);
            TableResult.Columns.Add("Ngày đăng bài", 150);
            TableResult.Columns.Add("Nên xem", 150);
            List<ListViewItem> Nhadatchothues = new NhadatchothueController().queryFetchAll();
            foreach (ListViewItem Nhadatchothue in Nhadatchothues)
            {
                TableResult.Items.Add(Nhadatchothue);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu nhà đất cho thuê");
        }
    }
}