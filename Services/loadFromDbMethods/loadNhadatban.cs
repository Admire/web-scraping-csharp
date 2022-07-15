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
        void loadNhadatban()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 200);
            listView1.Columns.Add("Tiêu đề", 250);
            listView1.Columns.Add("Giá", 150);
            listView1.Columns.Add("Giá/m2", 150);
            listView1.Columns.Add("Diện tích", 150);
            listView1.Columns.Add("Địa chỉ", 170);
            listView1.Columns.Add("Ngày đăng bài", 150);
            listView1.Columns.Add("Nên xem", 150);
            List<ListViewItem> nhadatbans = new nhadatbanController().queryFetchAll();
            foreach (ListViewItem nhadatban in nhadatbans)
            {
                listView1.Items.Add(nhadatban);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu nhà đất bán");
        }
    }
}