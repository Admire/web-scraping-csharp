using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class duanController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToduan = $"INSERT INTO duan VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToduan += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}','{item2.SubItems[2].Text}','{item2.SubItems[3].Text}','{item2.SubItems[4].Text}','{item2.SubItems[5].Text}','{item2.SubItems[6].Text}','{item2.SubItems[7].Text}','{item2.SubItems[8].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToduan += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<duan>(sqlInsertToduan);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllduan = "SELECT * FROM duan;";
            List<duan> duans = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
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
           
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<duan>(sqlDeleteAllduan);
            }
        }
    }
}
