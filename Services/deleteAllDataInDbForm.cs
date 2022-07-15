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
        void deleteAllDataInDbForm()
        {
            //chọn trang web muốn lưu vào cơ sở dữ liệu
            switch (comboBox1.Text)
            {
                case "Nhà đất bán":
                    deleteNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    deleteNhadatchothue();
                    break;
                case "Dự án":
                    deleteDuan();
                    break;
                case "Tin tức":
                    deleteTintuc();
                    break;
                case "Wiki BĐS":
                    deleteWiki();
                    break;
                case "Phong Thủy":
                    deletePhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    deleteNoingoaithat();
                    break;
                case "Nhà môi giới":
                    deleteNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    deleteDoanhnghiep();
                    break;
                default:
                    break;
            }
        }

    }
}