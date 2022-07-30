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
        void LoadNhamoigioi()
        {
            TableResult.Clear();
            TableResult.Columns.Add("Url bài viết", 200);
            TableResult.Columns.Add("Tên nhà môi giới", 300);
            TableResult.Columns.Add("Địa chỉ", 250);
            TableResult.Columns.Add("Điện thoại", 150);
            TableResult.Columns.Add("Email", 200);
            List<ListViewItem> Nhamoigiois = new NhamoigioiController().queryFetchAll();
            foreach (ListViewItem Nhamoigioi in Nhamoigiois)
            {
                TableResult.Items.Add(Nhamoigioi);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu nhà môi giới");
        }
    }
}