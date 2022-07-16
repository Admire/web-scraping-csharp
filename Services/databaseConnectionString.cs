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
        // địa chỉ kết nối tới server
        public string getConnection()
        {
            string serverName = serverDBname.Text.Trim();
            string serverPort = serverDBport.Text.Trim();
            string userName = userDBname.Text.Trim();
            string password = userDBpassword.Text.Trim();
            string dbName = DBname.Text.Trim();

            string connectionString = $"server={serverName};port={serverPort};user={userName};password={password};database={dbName}";
            return connectionString;
        }
    }
}
