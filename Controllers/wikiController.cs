using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class WikiController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToWiki = $"INSERT INTO Wiki VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToWiki += "(DEFAULT ";
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
                    sqlInsertToWiki += $",'{insert}'";
                }
                sqlInsertToWiki += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToWiki += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Wiki>(sqlInsertToWiki);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllWiki = "SELECT * FROM Wiki";
            List<Wiki> Wikis = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Wikis = db.Query<Wiki>(sqlGetAllWiki).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Wiki Wiki in Wikis)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Wiki.url;
                item.SubItems.Add(Wiki.tieude);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllWiki = $"DELETE FROM Wiki";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Wiki>(sqlDeleteAllWiki);
            }
        }
    }
}
