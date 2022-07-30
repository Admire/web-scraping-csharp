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
        void LoadDoanhnghiep()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url thông tin", 400);
            TableResult.Columns.Add("Tên doanh nghiệp", 700);
            List<ListViewItem> Doanhnghieps = new DoanhnghiepController().queryFetchAll();
            foreach (ListViewItem Doanhnghiep in Doanhnghieps)
            {
                TableResult.Items.Add(Doanhnghiep);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu doanh nghiệp");
        }
    }
}