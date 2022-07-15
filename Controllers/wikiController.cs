using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class wikiController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTowiki = $"INSERT INTO wiki VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTowiki += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTowiki += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<wiki>(sqlInsertTowiki);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllwiki = "SELECT * FROM wiki;";
            List<wiki> wikis = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                wikis = db.Query<wiki>(sqlGetAllwiki).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (wiki wiki in wikis)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  wiki.url;
                item.SubItems.Add(wiki.tieude);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllwiki = $"DELETE FROM wiki";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<wiki>(sqlDeleteAllwiki);
            }
        }
    }
}
