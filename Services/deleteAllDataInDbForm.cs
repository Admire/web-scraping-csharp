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
            TableResult.Clear();
            //chọn trang web muốn lưu vào cơ sở dữ liệu
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    new NhadatbanController().QueryDeleteAll();
                    break;
                case "Nhà đất cho thuê":
                    new NhadatchothueController().QueryDeleteAll();
                    break;
                case "Dự án":
                    new DuanController().QueryDeleteAll();
                    break;
                case "Tin tức":
                    new TintucController().QueryDeleteAll();
                    break;
                case "Wiki BĐS":
                    new WikiController().QueryDeleteAll();
                    break;
                case "Phong Thủy":
                    new PhongthuyController().QueryDeleteAll();
                    break;
                case "Nội-Ngoại thất":
                    new NoingoaithatController().QueryDeleteAll();
                    break;
                case "Nhà môi giới":
                    new NhamoigioiController().QueryDeleteAll();
                    break;
                case "Doanh nghiệp":
                    new DoanhnghiepController().QueryDeleteAll();
                    break;
                default:
                    break;
            }
            MessageBox.Show($"Đã xóa toàn bộ bản ghi có trong cơ sở dữ liệu {ListCategories.Text}");
        }

    }
}