using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NoingoaithatController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToNoingoaithat = $"INSERT INTO Noingoaithat VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToNoingoaithat += "(DEFAULT ";
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
                    sqlInsertToNoingoaithat += $",'{insert}'";
                }
                sqlInsertToNoingoaithat += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToNoingoaithat += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Noingoaithat>(sqlInsertToNoingoaithat);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllNoingoaithat = "SELECT * FROM Noingoaithat";
            List<Noingoaithat> Noingoaithats = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Noingoaithats = db.Query<Noingoaithat>(sqlGetAllNoingoaithat).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Noingoaithat Noingoaithat in Noingoaithats)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Noingoaithat.url;
                item.SubItems.Add(Noingoaithat.tieude);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllNoingoaithat = $"DELETE FROM Noingoaithat";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Noingoaithat>(sqlDeleteAllNoingoaithat);
            }
        }
    }
}
