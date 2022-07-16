using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class duanController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToduan = $"INSERT INTO duan VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToduan += "(DEFAULT ";
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
                    sqlInsertToduan += $",'{insert}'";
                }
                sqlInsertToduan += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToduan += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<duan>(sqlInsertToduan);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllduan = "SELECT * FROM duan";
            List<duan> duans = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                duans = db.Query<duan>(sqlGetAllduan).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (duan duan in duans)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  duan.url;
                item.SubItems.Add(duan.tieude);
                item.SubItems.Add(duan.dientich);
                item.SubItems.Add(duan.socanho);
                item.SubItems.Add(duan.sotoanha);
                item.SubItems.Add(duan.diachi);
                item.SubItems.Add(duan.congty);
                item.SubItems.Add(duan.tinhtrang);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllduan = $"DELETE FROM duan";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<duan>(sqlDeleteAllduan);
            }
        }
    }
}
