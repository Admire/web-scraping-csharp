using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class nhamoigioiController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonhamoigioi = $"INSERT INTO nhamoigioi VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonhamoigioi += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}','{item2.SubItems[2].Text}','{item2.SubItems[3].Text}','{item2.SubItems[4].Text}','{item2.SubItems[5].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonhamoigioi += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<nhamoigioi>(sqlInsertTonhamoigioi);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnhamoigioi = "SELECT * FROM nhamoigioi;";
            List<nhamoigioi> nhamoigiois = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                nhamoigiois = db.Query<nhamoigioi>(sqlGetAllnhamoigioi).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (nhamoigioi nhamoigioi in nhamoigiois)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  nhamoigioi.url;
                item.SubItems.Add(nhamoigioi.ten);
                item.SubItems.Add(nhamoigioi.diachi);
                item.SubItems.Add(nhamoigioi.dienthoai);
                item.SubItems.Add(nhamoigioi.email);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAllnhamoigioi = $"DELETE FROM nhamoigioi";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<nhamoigioi>(sqlDeleteAllnhamoigioi);
            }
        }
    }
}
