using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NhamoigioiController : BaseController
    {
        private string tableName = "Nhamoigioi";
        public void QueryInsertAll(List<ListViewItem> item)
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhamoigioi>(InsertString(item, tableName));
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            List<Nhamoigioi> Nhamoigiois = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Nhamoigiois = db.Query<Nhamoigioi>(SelectString(tableName)).ToList();
            }
            return GenerateTable(Nhamoigiois);
        }
        public void QueryDeleteAll()
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhamoigioi>(DeleteString(tableName));
            }
        }
    }
}
