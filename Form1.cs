using OpenQA.Selenium.Chrome;
using System.Net;
using System.Net.Http.Headers;

namespace web_scraping_csharp 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public string HomePage = "https://batdongsan.com.vn";

        private async void button1_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(() =>
            {
                ChromeDriver chromeDriver = new ChromeDriver();
                chromeDriver.Url = HomePage;
                chromeDriver.Navigate();
                var text = chromeDriver.PageSource.ToString();
            textBox1.Text = text;
            });

            newTask.Start();
            
        }
    }
}