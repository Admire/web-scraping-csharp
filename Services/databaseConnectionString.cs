using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Text;
using web_scraping_csharp.Controllers;
using web_scraping_csharp.Services;
using System.Windows.Forms;
namespace web_scraping_csharp.Services;

public class databaseConnectionString
{
    // địa chỉ kết nối tới server
    public string GetConnection()
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

        string connectionString = $"server={serverName};port={serverPort};user={userName};password={password};database={dbName}";
        return connectionString;
    }
}
