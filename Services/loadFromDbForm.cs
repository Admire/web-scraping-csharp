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
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    LoadNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    LoadNhadatchothue();
                    break;
                case "Dự án":
                    LoadDuan();
                    break;
                case "Tin tức":
                    LoadTintuc();
                    break;
                case "Wiki BĐS":
                    LoadWiki();
                    break;
                case "Phong Thủy":
                    LoadPhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    LoadNoingoaithat();
                    break;
                case "Nhà môi giới":
                    LoadNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    LoadDoanhnghiep();
                    break;
                default:
                    break;
            }

        }
    }
}