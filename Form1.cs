using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Permissions;
using System.Text;
namespace web_scraping_csharp 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

         public string HomePage = "https://batdongsan.com.vn";
         public string NhaDatBan = "https://batdongsan.com.vn/nha-dat-ban/p";

        private void button1_Click(object sender, EventArgs e)
        {
            Thread buttonOne = new Thread(RunChrome);
            buttonOne.IsBackground = true;

            buttonOne.Start();
        }

        void RunChrome()
        {

            label2.Text = "Đang tiến hành cào dữ liệu";
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
            chromeOptions.AddArgument("--profile-directory=Default");


            ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
            chromeDriver.Manage().Window.Maximize();
            int pageNumber = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 1; i <= pageNumber; i++)
            {
                string url = $"{NhaDatBan}{i}";
                chromeDriver.Navigate().GoToUrl(url);

                IWebElement productList = chromeDriver.FindElement(By.Id("product-lists-web"));
                List<IWebElement> productItem = productList.FindElements(By.ClassName("js__card")).ToList();
                foreach (var product in productItem)
                {
                    ListViewItem item = new ListViewItem();
                    if (product.FindElements(By.TagName("a")).Count() > 0)
                    {
                        item.Text = product.FindElement(By.TagName("a")).GetAttribute("href");

                    }
                    else { item.Text = ""; }
                    if (product.FindElements(By.ClassName("js__card-title")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("js__card-title")).GetAttribute("innerText").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.ClassName("re__card-config-price")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-price")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-config-price_per_m2")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-price_per_m2")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-config-area")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-config-area")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    if (product.FindElements(By.ClassName("re__card-location")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-location")).GetAttribute("innerHTML").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }

                    listView1.Items.Add(item);
                }
            }
            chromeDriver.Quit();
            label2.Text = "Kết quả";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread button2 = new Thread(ClearListView);
            button2.IsBackground = true;
            button2.Start();
        }

        void ClearListView()
        {
            listView1.Items.Clear();
            label2.Text = "Bấm vào get data để bắt đầu";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread button3 = new Thread(SaveToDb);
            button3.IsBackground = true;
            button3.Start();
        }
        void SaveToDb()
        {
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread button4 = new Thread(LoadFromDb);
            button4.IsBackground = true;
            button4.Start();
        }
        void LoadFromDb()
        {
            MessageBox.Show("Đã tải từ cơ sở dữ liệu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8);
                {
                    foreach (ListViewItem item in listView1.Items)
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