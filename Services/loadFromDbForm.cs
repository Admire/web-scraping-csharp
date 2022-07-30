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
            TableResult.Clear();
            switch (ListCategories.Text)
            {
                case "Nhà đất bán":
                    TableResult.Columns.Add("Url bài viết", 200);
                    TableResult.Columns.Add("Tiêu đề", 250);
                    TableResult.Columns.Add("Giá", 150);
                    TableResult.Columns.Add("Giá/m2", 150);
                    TableResult.Columns.Add("Diện tích", 150);
                    TableResult.Columns.Add("Địa chỉ", 170);
                    TableResult.Columns.Add("Ngày đăng bài", 150);
                    TableResult.Columns.Add("Nên xem", 150);
                    List<ListViewItem> Nhadatbans = new NhadatbanController().QueryFetchAll();
                    foreach (ListViewItem Nhadatban in Nhadatbans)
                    {
                        TableResult.Items.Add(Nhadatban);
                    }
                    break;
                case "Nhà đất cho thuê":
                    TableResult.Columns.Add("Url bài viết", 200);
                    TableResult.Columns.Add("Tiêu đề", 250);
                    TableResult.Columns.Add("Giá", 150);
                    TableResult.Columns.Add("Giá/m2", 150);
                    TableResult.Columns.Add("Diện tích", 150);
                    TableResult.Columns.Add("Địa chỉ", 170);
                    TableResult.Columns.Add("Ngày đăng bài", 150);
                    TableResult.Columns.Add("Nên xem", 150);
                    List<ListViewItem> Nhadatchothues = new NhadatchothueController().QueryFetchAll();
                    foreach (ListViewItem Nhadatchothue in Nhadatchothues)
                    {
                        TableResult.Items.Add(Nhadatchothue);
                    }
                    break;
                case "Dự án":
                    TableResult.Columns.Add("Url bài viết", 200);
                    TableResult.Columns.Add("Tiêu đề", 250);
                    TableResult.Columns.Add("Giá/m2", 100);
                    TableResult.Columns.Add("Diện tích", 100);
                    TableResult.Columns.Add("Số căn hộ", 100);
                    TableResult.Columns.Add("Số tòa nhà", 100);
                    TableResult.Columns.Add("Địa chỉ", 170);
                    TableResult.Columns.Add("Công ty", 180);
                    TableResult.Columns.Add("Tình trạng", 150);
                    List<ListViewItem> Duans = new DuanController().QueryFetchAll();
                    foreach (ListViewItem Duan in Duans)
                    {
                        TableResult.Items.Add(Duan);
                    }
                    break;
                case "Tin tức":
                    TableResult.Columns.Add("Url bài viết", 400);
                    TableResult.Columns.Add("Tiêu đề", 700);
                    List<ListViewItem> Tintucs = new TintucController().QueryFetchAll();
                    foreach (ListViewItem Tintuc in Tintucs)
                    {
                        TableResult.Items.Add(Tintuc);
                    }
                    break;
                case "Wiki BĐS":
                    TableResult.Columns.Add("Url bài viết", 400);
                    TableResult.Columns.Add("Tiêu đề", 700);
                    List<ListViewItem> Wikis = new WikiController().QueryFetchAll();
                    foreach (ListViewItem Wiki in Wikis)
                    {
                        TableResult.Items.Add(Wiki);
                    }
                    break;
                case "Phong Thủy":
                    TableResult.Columns.Add("Url bài viết", 400);
                    TableResult.Columns.Add("Tiêu đề", 700);
                    List<ListViewItem> Phongthuys = new PhongthuyController().QueryFetchAll();
                    foreach (ListViewItem Phongthuy in Phongthuys)
                    {
                        TableResult.Items.Add(Phongthuy);
                    }
                    break;
                case "Nội-Ngoại thất":
                    TableResult.Columns.Add("Url bài viết", 400);
                    TableResult.Columns.Add("Tiêu đề", 700);
                    List<ListViewItem> Noingoaithats = new NoingoaithatController().QueryFetchAll();
                    foreach (ListViewItem Noingoaithat in Noingoaithats)
                    {
                        TableResult.Items.Add(Noingoaithat);
                    }
                    break;
                case "Nhà môi giới":
                    TableResult.Columns.Add("Url bài viết", 200);
                    TableResult.Columns.Add("Tên nhà môi giới", 300);
                    TableResult.Columns.Add("Địa chỉ", 250);
                    TableResult.Columns.Add("Điện thoại", 150);
                    TableResult.Columns.Add("Email", 200);
                    List<ListViewItem> Nhamoigiois = new NhamoigioiController().QueryFetchAll();
                    foreach (ListViewItem Nhamoigioi in Nhamoigiois)
                    {
                        TableResult.Items.Add(Nhamoigioi);
                    }
                    break;
                case "Doanh nghiệp":
                    TableResult.Columns.Add("Url thông tin", 400);
                    TableResult.Columns.Add("Tên doanh nghiệp", 700);
                    List<ListViewItem> Doanhnghieps = new DoanhnghiepController().QueryFetchAll();
                    foreach (ListViewItem Doanhnghiep in Doanhnghieps)
                    {
                        TableResult.Items.Add(Doanhnghiep);
                    }
                    break;
                default:
                    break;
            }
            MessageBox.Show($"Đã tải từ cơ sở dữ liệu {ListCategories.Text}");

        }
    }
}