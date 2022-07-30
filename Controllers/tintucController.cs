using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class TintucController : BaseController
    {
        private string tableName = "Tintuc";
        public void QueryInsertAll(List<ListViewItem> item)
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Tintuc>(InsertString(item, tableName));
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            List<Tintuc> Tintucs = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Tintucs = db.Query<Tintuc>(SelectString(tableName)).ToList();
            }
            return GenerateTable(Tintucs);
        }
        public void QueryDeleteAll()
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Tintuc>(DeleteString(tableName));
            }
        }
    }
}
