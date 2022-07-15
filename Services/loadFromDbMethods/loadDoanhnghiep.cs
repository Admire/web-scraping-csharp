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
        void loadDoanhnghiep()
        {
            listView1.Clear();
            listView1.Columns.Add("Url thông tin", 400);
            listView1.Columns.Add("Tên doanh nghiệp", 700);
            List<ListViewItem> doanhnghieps = new doanhnghiepController().queryFetchAll();
            foreach (ListViewItem doanhnghiep in doanhnghieps)
            {
                listView1.Items.Add(doanhnghiep);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu doanh nghiệp");
        }
    }
}