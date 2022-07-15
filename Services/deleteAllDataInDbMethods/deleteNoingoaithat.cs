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
        void deleteNoingoaithat()
        {
            listView1.Clear();
            new noingoaithatController().queryDeleteAll();
            MessageBox.Show("Đã xóa toàn bộ bản ghi có trong cơ sở dữ liệu Nội-Ngoại thất");
        }

    }
}