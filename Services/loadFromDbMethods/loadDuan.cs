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
        void LoadDuan()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url bài viết", 200);
            TableResult.Columns.Add("Tiêu đề", 250);
            TableResult.Columns.Add("Giá/m2", 100);
            TableResult.Columns.Add("Diện tích", 100);
            TableResult.Columns.Add("Số căn hộ", 100);
            TableResult.Columns.Add("Số tòa nhà", 100);
            TableResult.Columns.Add("Địa chỉ", 170);
            TableResult.Columns.Add("Công ty", 180);
            TableResult.Columns.Add("Tình trạng", 150);
            List<ListViewItem> Duans = new DuanController().QueryFetchAll();
            foreach (ListViewItem Duan in Duans)
            {
                TableResult.Items.Add(Duan);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu dự án");
        }
    }
}