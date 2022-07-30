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
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void CrawlSomePagesButton_Click(object sender, EventArgs e)
        {
            Thread buttonOne = new Thread(RunChrome);
            buttonOne.IsBackground = true;

            buttonOne.Start();
        }
        private void DeleteResultButton_Click(object sender, EventArgs e)
        {
            Thread buttonTwo = new Thread(ClearListView);
            buttonTwo.IsBackground = true;
            buttonTwo.Start();
        }
        private void SaveToDbButton_Click(object sender, EventArgs e)
        {
            TextBox serverDBname = Application.OpenForms["Form1"].Controls["serverDBname"] as TextBox;
            TextBox serverDBport = Application.OpenForms["Form1"].Controls["serverDBport"] as TextBox;
            TextBox userDBname = Application.OpenForms["Form1"].Controls["userDBname"] as TextBox;
            TextBox userDBpassword = Application.OpenForms["Form1"].Controls["userDBpassword"] as TextBox;
            TextBox DBname = Application.OpenForms["Form1"].Controls["DBname"] as TextBox;
            string serverName = serverDBname.Text.Trim();
            string serverPort = serverDBport.Text.Trim();
            string userName = userDBname.Text.Trim();
            string password = userDBpassword.Text.Trim();
            string dbName = DBname.Text.Trim();
            if (serverName != "" && serverPort != "" && userName != "" && password != "")
            {
                Thread buttonThree = new Thread(SaveToDb);
                buttonThree.IsBackground = true;
                buttonThree.Start();     
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của cơ sở dữ liệu MySQL trước khi cào");
            }
        }

        private void LoadDbButton_Click(object sender, EventArgs e)
        {
            TextBox serverDBname = Application.OpenForms["Form1"].Controls["serverDBname"] as TextBox;
            TextBox serverDBport = Application.OpenForms["Form1"].Controls["serverDBport"] as TextBox;
            TextBox userDBname = Application.OpenForms["Form1"].Controls["userDBname"] as TextBox;
            TextBox userDBpassword = Application.OpenForms["Form1"].Controls["userDBpassword"] as TextBox;
            TextBox DBname = Application.OpenForms["Form1"].Controls["DBname"] as TextBox;
            string serverName = serverDBname.Text.Trim();
            string serverPort = serverDBport.Text.Trim();
            string userName = userDBname.Text.Trim();
            string password = userDBpassword.Text.Trim();
            string dbName = DBname.Text.Trim();
            if (serverName != "" && serverPort != "" && userName != "" && password != "")
            {
                Thread buttonFour = new Thread(LoadFromDb);
                buttonFour.IsBackground = true;
                buttonFour.Start();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của cơ sở dữ liệu MySQL trước khi cào");
            }

        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            ResultToTextFile();
        }

        private void StopCrawl_Click(object sender, EventArgs e)
        {
            Thread button6 = new Thread(StopGetData);
            button6.IsBackground = true;
            button6.Start();
        }

        private void CrawlAllPagesButton_Click(object sender, EventArgs e)
        {
            Thread buttonSeven = new Thread(RunChromeAllPages);
            buttonSeven.IsBackground = true;

            buttonSeven.Start();
        }

        private void DeleteDbButton_Click(object sender, EventArgs e)
        {
            Thread buttonEight = new Thread(DeleteAllDataInDbForm);
            buttonEight.IsBackground = true;
            buttonEight.Start();
        }

        private void CrawlAllButton_Click(object sender, EventArgs e)
        {
            TextBox serverDBname = Application.OpenForms["Form1"].Controls["serverDBname"] as TextBox;
            TextBox serverDBport = Application.OpenForms["Form1"].Controls["serverDBport"] as TextBox;
            TextBox userDBname = Application.OpenForms["Form1"].Controls["userDBname"] as TextBox;
            TextBox userDBpassword = Application.OpenForms["Form1"].Controls["userDBpassword"] as TextBox;
            TextBox DBname = Application.OpenForms["Form1"].Controls["DBname"] as TextBox;
            string serverName = serverDBname.Text.Trim();
            string serverPort = serverDBport.Text.Trim();
            string userName = userDBname.Text.Trim();
            string password = userDBpassword.Text.Trim();
            string dbName = DBname.Text.Trim();
            if(serverName != "" && serverPort != "" && userName != "" && password != "")
            {
                TableTitle.Text = "Dữ liệu cào của từng danh mục được lưu tự động vào database";
                foreach (var process in Process.GetProcessesByName("chrome"))
                {
                    process.Kill();
                }
                CrawlSomePagesButton.Enabled = false;
                CrawlAllButton.Enabled = false;
                CrawlAllPagesButton.Enabled = false;
                StopCrawl.Enabled = true;

                //dùng new task() để tạo thread mới run ở bg, tách biệt với UI của winform
                Task bgTask = new Task(() =>
                {
                    //option giới hạn lượng thread chạy
                    ParallelOptions parallelOptions = new ParallelOptions
                    {
                        MaxDegreeOfParallelism = 3
                    };
                    // dùng parallel.invoke để thêm 1 nhóm các thread mới
                    Parallel.Invoke(
                           parallelOptions,
                           // task 1 trang
                           () => { CrawlAllDoanhnghiep(); },
                           () => { CrawlAllTintuc(); },
                           () => { CrawlAllWiki(); },
                           () => { CrawlAllPhongthuy(); },
                           () => { CrawlAllNoingoaithat(); },
                           // task nhiều trang
                           () => { CrawlAllNhadatban(); },
                           () => { CrawlAllNhadatchothue(); },
                           () => { CrawlAllDuan(); },
                           () => { CrawlAllNhamoigioi(); }
                       );
                    //hết cái trên mới chạy tới cái dưới
                    Parallel.Invoke(
                            () => {
                                CrawlSomePagesButton.Enabled = true;
                                CrawlAllButton.Enabled = true;
                                CrawlAllPagesButton.Enabled = true;
                                StopCrawl.Enabled = false;
                                TableTitle.Text = "Lưu ý: Tool sẽ đóng tiến trình Chrome hiện tại khi bắt đầu cào";
                            }
                        );
                });
                bgTask.Start();

            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của cơ sở dữ liệu MySQL trước khi cào");
            }

        }

    }
}