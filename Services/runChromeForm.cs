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

        void RunChrome()
        {
            listView1.Clear();
            label2.Text = "Đang tiến hành cào dữ liệu (lưu ý: không ẩn trình duyệt chrome)";
            //tạm thời tắt tính năng ấn vào nút để tránh trường hợp cào chồng lên nhau
            button1.Enabled = false;
            button7.Enabled = false;
            startPageNum.Enabled = false;
            pageRangeNum.Enabled = false;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

            //chọn trang web muốn runChrome
            switch (comboBox1.Text) {
                case "Nhà đất bán":
                    runChromeNhadatban();
                    break;
                case "Nhà đất cho thuê":
                    runChromeNhadatchothue();
                    break;
                case "Dự án":
                    runChromeDuan();
                    break;
                case "Tin tức":
                    runChromeTintuc();
                    break;
                case "Wiki BĐS":
                    runChromeWiki();
                    break;
                case "Phong Thủy":
                    runChromePhongthuy();
                    break;
                case "Nội-Ngoại thất":
                    runChromeNoingoaithat();
                    break;
                case "Nhà môi giới":
                    runChromeNhamoigioi();
                    break;
                case "Doanh nghiệp":
                    runChromeDoanhnghiep();
                    break;
                default:
                    break;
            }

            label2.Text = "Kết quả";
            //bật lại tính năng nhấn vào nút
            button1.Enabled = true;
            startPageNum.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = true;
            pageRangeNum.Enabled = true;
        }

    }
}