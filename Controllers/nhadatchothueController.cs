using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class nhadatchothueController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonhadatchothue = $"INSERT INTO nhadatchothue VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonhadatchothue += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}','{item2.SubItems[2].Text}','{item2.SubItems[3].Text}','{item2.SubItems[4].Text}','{item2.SubItems[5].Text}','{item2.SubItems[6].Text}','{item2.SubItems[7].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonhadatchothue += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<nhadatchothue>(sqlInsertTonhadatchothue);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnhadatchothue = "SELECT * FROM nhadatchothue;";
            List<nhadatchothue> nhadatchothues = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                nhadatchothues = db.Query<nhadatchothue>(sqlGetAllnhadatchothue).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (nhadatchothue nhadatchothue in nhadatchothues)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  nhadatchothue.url;
                item.SubItems.Add(nhadatchothue.tieude);
                item.SubItems.Add(nhadatchothue.gia);
                item.SubItems.Add(nhadatchothue.giam2);
                item.SubItems.Add(nhadatchothue.dientich);
                item.SubItems.Add(nhadatchothue.diachi);
                item.SubItems.Add(nhadatchothue.ngaydangbai);
                item.SubItems.Add(nhadatchothue.nenxem);

                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllnhadatchothue = $"DELETE FROM nhadatchothue";
           
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<nhadatchothue>(sqlDeleteAllnhadatchothue);
            }
        }
    }
}
