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
        void LoadFromDb()
        {//chọn trang web muốn tải từ cơ sở dữ liệu
            switch (comboBox1.Text)
            {
                case "Nhà đất bán":
                    loadNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    loadNhadatchothue();
                    break;
                case "Dự án":
                    loadDuan();
                    break;
                case "Tin tức":
                    loadTintuc();
                    break;
                case "Wiki BĐS":
                    loadWiki();
                    break;
                case "Phong Thủy":
                    loadPhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    loadNoingoaithat();
                    break;
                case "Nhà môi giới":
                    loadNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    loadDoanhnghiep();
                    break;
                default:
                    break;
            }

        }
    }
}