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
        void SaveToDb()
        {//chọn trang web muốn lưu vào cơ sở dữ liệu
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    SaveToDbNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    SaveToDbNhadatchothue();
                    break;
                case "Dự án":
                    SaveToDbDuan();
                    break;
                case "Tin tức":
                    SaveToDbTintuc();
                    break;
                case "Wiki BĐS":
                    SaveToDbWiki();
                    break;
                case "Phong Thủy":
                    SaveToDbPhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    SaveToDbNoingoaithat();
                    break;
                case "Nhà môi giới":
                    SaveToDbNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    SaveToDbDoanhnghiep();
                    break;
                default:
                    break;
            }
            
        }

    }
}