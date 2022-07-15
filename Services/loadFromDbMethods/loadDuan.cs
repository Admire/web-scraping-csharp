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
        void loadDuan()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 200);
            listView1.Columns.Add("Tiêu đề", 250);
            listView1.Columns.Add("Giá/m2", 100);
            listView1.Columns.Add("Diện tích", 100);
            listView1.Columns.Add("Số căn hộ", 100);
            listView1.Columns.Add("Số tòa nhà", 100);
            listView1.Columns.Add("Địa chỉ", 170);
            listView1.Columns.Add("Công ty", 180);
            listView1.Columns.Add("Tình trạng", 150);
            List<ListViewItem> duans = new duanController().queryFetchAll();
            foreach (ListViewItem duan in duans)
            {
                listView1.Items.Add(duan);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu dự án");
        }
    }
}