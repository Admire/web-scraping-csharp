using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class DuanController : BaseController
    {
        private string tableName = "Duan";
        public void QueryInsertAll(List<ListViewItem> item)
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Duan>(InsertString(item, tableName));
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            List<Duan> Duans = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Duans = db.Query<Duan>(SelectString(tableName)).ToList();
            }
            return GenerateTable(Duans);

        }
        public void QueryDeleteAll()
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Duan>(DeleteString(tableName));
            }
        }
    }
}
