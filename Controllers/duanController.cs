using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class DuanController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToDuan = $"INSERT INTO Duan VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToDuan += "(DEFAULT ";
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
                    sqlInsertToDuan += $",'{insert}'";
                }
                sqlInsertToDuan += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToDuan += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Duan>(sqlInsertToDuan);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllDuan = "SELECT * FROM Duan";
            List<Duan> Duans = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Duans = db.Query<Duan>(sqlGetAllDuan).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Duan Duan in Duans)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Duan.url;
                item.SubItems.Add(Duan.tieude);
                item.SubItems.Add(Duan.dientich);
                item.SubItems.Add(Duan.socanho);
                item.SubItems.Add(Duan.sotoanha);
                item.SubItems.Add(Duan.diachi);
                item.SubItems.Add(Duan.congty);
                item.SubItems.Add(Duan.tinhtrang);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllDuan = $"DELETE FROM Duan";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Duan>(sqlDeleteAllDuan);
            }
        }
    }
}
