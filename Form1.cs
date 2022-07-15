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

        private void button1_Click(object sender, EventArgs e)
        {
            Thread buttonOne = new Thread(RunChrome);
            buttonOne.IsBackground = true;

            buttonOne.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread buttonTwo = new Thread(ClearListView);
            buttonTwo.IsBackground = true;
            buttonTwo.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread buttonThree = new Thread(SaveToDb);
            buttonThree.IsBackground = true;
            buttonThree.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread buttonFour = new Thread(LoadFromDb);
            buttonFour.IsBackground = true;
            buttonFour.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultToTextFile();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread button6 = new Thread(StopGetData);
            button6.IsBackground = true;
            button6.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread buttonSeven = new Thread(RunChromeAllPages);
            buttonSeven.IsBackground = true;

            buttonSeven.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread buttonEight = new Thread(deleteAllDataInDbForm);
            buttonEight.IsBackground = true;
            buttonEight.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Đang tiến hành cào toàn bộ danh mục theo trang đã nhập";
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 3
            };
             Parallel.Invoke(
                    parallelOptions,
                    // task 1 trang
                    () => {crawlAllDoanhnghiep();
                    },
                    () => {crawlAllTintuc();
                    },
                    () => {crawlAllWiki();
                    },
                    () => {crawlAllPhongthuy();
                    },
                    () => {crawlAllNoingoaithat();
                    },
                    // task nhiều trang
                    () => {crawlAllNhadatban();
                    },
                    () => {crawlAllNhadatchothue();
                    },
                    () => {crawlAllDuan();
                    },
                    () => {crawlAllNhamoigioi();
                    }
                );

            if (Process.GetProcessesByName("chrome").Count() == 0)
            {
                label2.Text = "Quá trình cào đã kết thúc, hãy chọn từng danh mục để xem dữ liệu đã lưu";
            }
        }

    }
}