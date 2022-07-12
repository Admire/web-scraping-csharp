using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace web_scraping_csharp 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public string HomePage = "https://batdongsan.com.vn";

        private void button1_Click(object sender, EventArgs e)
        {
            Thread newTask = new Thread( () =>
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("user-data-dir=C:/Users/manh/AppData/Local/Google/Chrome/User Data");
                chromeOptions.AddArgument("--profile-directory=Default");

                ChromeDriver chromeDriver = new ChromeDriver(chromeOptions);
                chromeDriver.Manage().Window.Maximize();
                chromeDriver.Navigate().GoToUrl(HomePage);


                //hiện mã nguồn trang

                /*              string text =  chromeDriver.PageSource.ToString();
                                textBox1.Text = text;*/


                // nên dùng element.GetAttribute("innerText") thay cho element.text;
                // vì dùng element.text thì những element có text nhưng k hiện sẽ không hiển thị

                /*                string texthihi = "";
                                List<IWebElement> menuList = chromeDriver.FindElements(By.CssSelector("div.re__right-menu > div > ul > li>a>span.text")).ToList();
                                foreach (IWebElement element in menuList)
                                {
                                    texthihi += element.GetAttribute("innerText") + " ";
                                }
                                textBox2.Text = texthihi;*/

                //mở từng menu con 1
                List<IWebElement> menuLink = chromeDriver.FindElements(By.CssSelector("div.re__right-menu > div > ul > li:not(li.tablet) > a")).ToList();
                List<string> menuUrl = new();
                foreach (IWebElement element in menuLink)
                {
                    if (element.GetAttribute("href") != "javascript:void(0);")
                    {
                        menuUrl.Add(element.GetAttribute("href"));
                    }
                }
                foreach (string item in menuUrl)
                {
                  chromeDriver.SwitchTo().NewWindow(WindowType.Tab);
                  chromeDriver.Navigate().GoToUrl(item);
                }
                    //chromeDriver.Quit();
            });

             newTask.Start();
            
        }
    }
}