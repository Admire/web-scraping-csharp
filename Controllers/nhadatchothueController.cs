using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NhadatchothueController : BaseController
    {
        private string tableName = "Nhadatchothue";
        public void QueryInsertAll(List<ListViewItem> item)
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatchothue>(InsertString(item, tableName));
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            List<Nhadatchothue> Nhadatchothues = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Nhadatchothues = db.Query<Nhadatchothue>(SelectString(tableName)).ToList();
            }
            return GenerateTable(Nhadatchothues);
        }
        public void QueryDeleteAll()
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatchothue>(DeleteString(tableName));
            }
        }
    }
}
