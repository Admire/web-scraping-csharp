using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class phongthuyController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTophongthuy = $"INSERT INTO phongthuy VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTophongthuy += "(DEFAULT ";
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
                    sqlInsertTophongthuy += $",'{insert}'";
                }
                sqlInsertTophongthuy += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTophongthuy += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<phongthuy>(sqlInsertTophongthuy);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllphongthuy = "SELECT * FROM phongthuy";
            List<phongthuy> phongthuys = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                phongthuys = db.Query<phongthuy>(sqlGetAllphongthuy).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (phongthuy phongthuy in phongthuys)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  phongthuy.url;
                item.SubItems.Add(phongthuy.tieude);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllphongthuy = $"DELETE FROM phongthuy";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<phongthuy>(sqlDeleteAllphongthuy);
            }
        }
    }
}
