using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class tintucController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTotintuc = $"INSERT INTO tintuc VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTotintuc += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTotintuc += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<tintuc>(sqlInsertTotintuc);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAlltintuc = "SELECT * FROM tintuc;";
            List<tintuc> tintucs = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                tintucs = db.Query<tintuc>(sqlGetAlltintuc).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (tintuc tintuc in tintucs)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  tintuc.url;
                item.SubItems.Add(tintuc.tieude);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAlltintuc = $"DELETE FROM tintuc";
           
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<tintuc>(sqlDeleteAlltintuc);
            }
        }
    }
}
