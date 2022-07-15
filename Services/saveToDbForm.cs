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
            switch (comboBox1.Text)
            {
                case "Nhà đất bán":
                    saveToDbnhadatban();
                    break;
                case "Nhà đất cho thuê":
                    saveToDbnhadatchothue();
                    break;
                case "Dự án":
                    saveToDbduan();
                    break;
                case "Tin tức":
                    saveToDbtintuc();
                    break;
                case "Wiki BĐS":
                    saveToDbwiki();
                    break;
                case "Phong Thủy":
                    saveToDbphongthuy();
                    break;
                case "Nội-Ngoại thất":
                    saveToDbnoingoaithat();
                    break;
                case "Nhà môi giới":
                    saveToDbnhamoigioi();
                    break;
                case "Doanh nghiệp":
                    saveToDbdoanhnghiep();
                    break;
                default:
                    break;
            }
            
        }

    }
}