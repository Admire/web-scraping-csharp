using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class TintucController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToTintuc = $"INSERT INTO Tintuc VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToTintuc += "(DEFAULT ";
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
                    sqlInsertToTintuc += $",'{insert}'";
                }
                sqlInsertToTintuc += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToTintuc += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Tintuc>(sqlInsertToTintuc);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllTintuc = "SELECT * FROM Tintuc";
            List<Tintuc> Tintucs = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Tintucs = db.Query<Tintuc>(sqlGetAllTintuc).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Tintuc Tintuc in Tintucs)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Tintuc.url;
                item.SubItems.Add(Tintuc.tieude);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllTintuc = $"DELETE FROM Tintuc";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Tintuc>(sqlDeleteAllTintuc);
            }
        }
    }
}
