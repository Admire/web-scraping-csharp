using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class DoanhnghiepController : BaseController
    {
        private string tableName = "Doanhnghiep";
        public void QueryInsertAll(List<ListViewItem> item)
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Doanhnghiep>(InsertString(item, tableName));
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            List<Doanhnghiep> Doanhnghieps = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Doanhnghieps = db.Query<Doanhnghiep>(SelectString(tableName)).ToList();
            }
            return GenerateTable(Doanhnghieps);
        }
        public void QueryDeleteAll()
        {
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Doanhnghiep>(DeleteString(tableName));
            }
        }
    }
}
