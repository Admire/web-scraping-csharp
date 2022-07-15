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
        void loadNhamoigioi()
        {
            listView1.Clear();
            listView1.Columns.Add("Url bài viết", 200);
            listView1.Columns.Add("Tên nhà môi giới", 300);
            listView1.Columns.Add("Địa chỉ", 250);
            listView1.Columns.Add("Điện thoại", 150);
            listView1.Columns.Add("Email", 200);
            List<ListViewItem> nhamoigiois = new nhamoigioiController().queryFetchAll();
            foreach (ListViewItem nhamoigioi in nhamoigiois)
            {
                listView1.Items.Add(nhamoigioi);
            }
            MessageBox.Show("Đã tải từ cơ sở dữ liệu nhà môi giới");
        }
    }
}