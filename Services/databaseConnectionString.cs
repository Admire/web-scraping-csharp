using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Text;
using web_scraping_csharp.Controllers;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Services;

public class databaseConnectionString
{
    // địa chỉ kết nối tới server
    public string getConnection()
    {
        string serverName = new Form1().serverDBname.Text.Trim();
        string serverPort = new Form1().serverDBport.Text.Trim();
        string userName = new Form1().userDBname.Text.Trim();
        string password = new Form1().userDBpassword.Text.Trim();
        string dbName = new Form1().DBname.Text.Trim();

        string connectionString = $"server={serverName};port={serverPort};user={userName};password={password};database={dbName}";
        return connectionString;
    }
}
