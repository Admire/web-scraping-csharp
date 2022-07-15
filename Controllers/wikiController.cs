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
                sqlInsertTowiki += "(DEFAULT ";
                List<string> insertList = new();
                Char value = '\'';
                for(int i = 0; i < item2.SubItems.Count; i++){
                    string test = item2.SubItems[i].Text;
                    if (test.Contains(value)){
                        insertList.Add(String.Join("\\'", test.Split(value)));
                    }
                    else{
                        insertList.Add(test);
                    }
                }
                foreach(string insert in insertList)
                {
                    sqlInsertTowiki += $",'{insert}'";
                }
                sqlInsertTowiki += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
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
            string sqlGetAllwiki = "SELECT * FROM wiki";
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
