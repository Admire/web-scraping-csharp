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
     void ResultToTextFile()
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8);
                {
                    foreach (ListViewItem item in TableResult.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            tw.WriteLine(item.SubItems[i].Text + ';');
                        }
                    }
                }
                MessageBox.Show("Lưu thành công");
            }
        }

    }
}