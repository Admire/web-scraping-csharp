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
            List<ListViewItem> item = new();
            for (int i = 0; i < TableResult.Items.Count; i++)
            {
                item.Add(TableResult.Items[i]);
            }
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    new NhadatbanController().QueryInsertAll(item);
                    break;
                case "Nhà đất cho thuê":
                    new NhadatchothueController().QueryInsertAll(item);
                    break;
                case "Dự án":
                    new DuanController().QueryInsertAll(item);
                    break;
                case "Tin tức":
                    new TintucController().QueryInsertAll(item);
                    break;
                case "Wiki BĐS":
                    new WikiController().QueryInsertAll(item);
                    break;
                case "Phong Thủy":
                    new PhongthuyController().QueryInsertAll(item);
                    break;
                case "Nội-Ngoại thất":
                    new NoingoaithatController().QueryInsertAll(item);
                    break;
                case "Nhà môi giới":
                    new NhamoigioiController().QueryInsertAll(item);
                    break;
                case "Doanh nghiệp":
                    new DoanhnghiepController().QueryInsertAll(item);
                    break;
                default:
                    break;
            }

            MessageBox.Show($"Đã lưu vào cơ sở dữ liệu {ListCategories.Text}");
        }

    }
}