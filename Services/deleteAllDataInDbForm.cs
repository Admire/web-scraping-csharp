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
        void DeleteAllDataInDbForm()
        {
            //chọn trang web muốn lưu vào cơ sở dữ liệu
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    DeleteNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    DeleteNhadatchothue();
                    break;
                case "Dự án":
                    DeleteDuan();
                    break;
                case "Tin tức":
                    DeleteTintuc();
                    break;
                case "Wiki BĐS":
                    DeleteWiki();
                    break;
                case "Phong Thủy":
                    DeletePhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    DeleteNoingoaithat();
                    break;
                case "Nhà môi giới":
                    DeleteNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    DeleteDoanhnghiep();
                    break;
                default:
                    break;
            }
        }

    }
}