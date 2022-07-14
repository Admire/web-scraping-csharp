using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using web_scraping_csharp.Controllers;
using web_scraping_csharp.Models;

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
            listView1.Items.Clear();
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
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
            chromeOptions.AddArgument("--profile-directory=Default");


            ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
            chromeDriver.Manage().Window.Maximize();
            int pageRangeNumber = Convert.ToInt32(pageRangeNum.Value + startPageNum.Value -1);
            int pageStartNumber = Convert.ToInt32(startPageNum.Value);
            for (int i = pageStartNumber; i <= pageRangeNumber; i++)
            {
                if (label2.Text == "Kết quả")
                {
                    break;
                }
                string url = $"{NhaDatBan}{i}";
                chromeDriver.Navigate().GoToUrl(url);

                IWebElement productList = chromeDriver.FindElement(By.Id("product-lists-web"));
                List<IWebElement> productItem = productList.FindElements(By.ClassName("js__card")).ToList();
                foreach (var product in productItem)
                {
                    if(label2.Text == "Kết quả")
                    {
                        break;
                    }
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
                    if (product.FindElements(By.ClassName("re__card-published-info-published-at")).Count() > 0)
                    {
                        item.SubItems.Add(product.FindElement(By.ClassName("re__card-published-info-published-at")).GetAttribute("aria-label").Trim());
                    }
                    else { item.SubItems.Add("Trống"); }
                    if (product.FindElements(By.ClassName("re__icon-star--sm")).Count() > 0)
                    {
                        item.SubItems.Add("Nên xem");
                    }
                    else { item.SubItems.Add("Không nên xem"); }

                    listView1.Items.Add(item);
                }
            }
            chromeDriver.Quit();
            label2.Text = "Kết quả";
            //bật lại tính năng nhấn vào nút
            button1.Enabled = true;
            startPageNum.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = true;
            pageRangeNum.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread buttonTwo = new Thread(ClearListView);
            buttonTwo.IsBackground = true;
            buttonTwo.Start();
        }

        void ClearListView()
        {
            listView1.Items.Clear();
            if(button1.Enabled == true|| button7.Enabled == true || button6.Enabled == false)
            {
                label2.Text = "Bấm vào \"Cào theo số đã nhập\" hoặc \"Cào tất cả các trang\" để bắt đầu";
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread buttonThree = new Thread(SaveToDb);
            buttonThree.IsBackground = true;
            buttonThree.Start();
        }
        void SaveToDb()
        {
            List<ListViewItem> item = new();
            for(int i = 0; i <listView1.Items.Count; i++)
            {
                item.Add(listView1.Items[i]);
            }
            new nhabandatController().queryInsertAll(item);
            MessageBox.Show("Đã lưu vào cơ sở dữ liệu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread buttonFour = new Thread(LoadFromDb);
            buttonFour.IsBackground = true;
            buttonFour.Start();
        }
        void LoadFromDb()
        {
            listView1.Items.Clear();
            List<ListViewItem> nhabandats = new nhabandatController().queryFetchAll();
            foreach(ListViewItem nhabandat in nhabandats)
            {
                listView1.Items.Add(nhabandat);
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            Thread button6 = new Thread(StopGetData);
            button6.IsBackground = true;
            button6.Start();
        }
        void StopGetData()
        {
            label2.Text = "Kết quả";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread buttonSeven = new Thread(RunChromeAllPages);
            buttonSeven.IsBackground = true;

            buttonSeven.Start();
        }
        void RunChromeAllPages()
        {
            listView1.Items.Clear();
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
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
            chromeOptions.AddArgument("--profile-directory=Default");


            ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
            chromeDriver.Manage().Window.Maximize();
            int i = 1;
            while (i<100000000)
            {
                if (label2.Text == "Kết quả")
                {
                    break;
                }
                string url = $"{NhaDatBan}{i}";
                chromeDriver.Navigate().GoToUrl(url);
                if (chromeDriver.FindElements(By.ClassName("re__srp-empty")).Count()>0)
                {
                    break;
                }
                else
                {
                    IWebElement productList = chromeDriver.FindElement(By.Id("product-lists-web"));
                    List<IWebElement> productItem = productList.FindElements(By.ClassName("js__card")).ToList();
                    foreach (var product in productItem)
                    {
                        if (label2.Text == "Kết quả")
                        {
                            break;
                        }
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
                        if (product.FindElements(By.ClassName("re__card-published-info-published-at")).Count() > 0)
                        {
                            item.SubItems.Add(product.FindElement(By.ClassName("re__card-published-info-published-at")).GetAttribute("aria-label").Trim());
                        }
                        else { item.SubItems.Add("Trống"); }
                        if (product.FindElements(By.ClassName("re__icon-star--sm")).Count() > 0)
                        {
                            item.SubItems.Add("Nên xem");
                        }
                        else { item.SubItems.Add("Không nên xem"); }

                        listView1.Items.Add(item);
                    }
                }
                i++;
            }
            chromeDriver.Quit();
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