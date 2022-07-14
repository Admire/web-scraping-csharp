using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class phongthuyController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTophongthuy = $"INSERT INTO phongthuy VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTophongthuy += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTophongthuy += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<phongthuy>(sqlInsertTophongthuy);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllphongthuy = "SELECT * FROM phongthuy;";
            List<phongthuy> phongthuys = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
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
           
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<phongthuy>(sqlDeleteAllphongthuy);
            }
        }
    }
}
