using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class nhadatbanController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonhadatban = $"INSERT INTO nhadatban VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonhadatban += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}','{item2.SubItems[2].Text}','{item2.SubItems[3].Text}','{item2.SubItems[4].Text}','{item2.SubItems[5].Text}','{item2.SubItems[6].Text}','{item2.SubItems[7].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonhadatban += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<nhadatban>(sqlInsertTonhadatban);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnhadatban = "SELECT * FROM nhadatban;";
            List<nhadatban> nhadatbans = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                nhadatbans = db.Query<nhadatban>(sqlGetAllnhadatban).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (nhadatban nhadatban in nhadatbans)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  nhadatban.url;
                item.SubItems.Add(nhadatban.tieude);
                item.SubItems.Add(nhadatban.gia);
                item.SubItems.Add(nhadatban.giam2);
                item.SubItems.Add(nhadatban.dientich);
                item.SubItems.Add(nhadatban.diachi);
                item.SubItems.Add(nhadatban.ngaydangbai);
                item.SubItems.Add(nhadatban.nenxem);

                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllnhadatban = $"DELETE FROM nhadatban";
           
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<nhadatban>(sqlDeleteAllnhadatban);
            }
        }
    }
}
