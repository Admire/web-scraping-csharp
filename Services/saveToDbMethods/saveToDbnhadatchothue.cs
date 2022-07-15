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
        void saveToDbnhadatchothue()
        {
            List<ListViewItem> item = new();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                item.Add(listView1.Items[i]);
            }
            new nhadatchothueController().queryInsertAll(item);
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu nhà đất cho thuê");
        }

    }
}