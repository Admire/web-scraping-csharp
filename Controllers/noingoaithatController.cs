using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class noingoaithatController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonoingoaithat = $"INSERT INTO noingoaithat VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonoingoaithat += "(DEFAULT ";
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
                    sqlInsertTonoingoaithat += $",'{insert}'";
                }
                sqlInsertTonoingoaithat += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonoingoaithat += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<noingoaithat>(sqlInsertTonoingoaithat);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnoingoaithat = "SELECT * FROM noingoaithat";
            List<noingoaithat> noingoaithats = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                noingoaithats = db.Query<noingoaithat>(sqlGetAllnoingoaithat).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (noingoaithat noingoaithat in noingoaithats)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  noingoaithat.url;
                item.SubItems.Add(noingoaithat.tieude);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllnoingoaithat = $"DELETE FROM noingoaithat";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<noingoaithat>(sqlDeleteAllnoingoaithat);
            }
        }
    }
}
