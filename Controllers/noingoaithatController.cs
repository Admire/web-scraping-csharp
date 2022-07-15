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
                sqlInsertTonoingoaithat += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonoingoaithat += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<noingoaithat>(sqlInsertTonoingoaithat);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnoingoaithat = "SELECT * FROM noingoaithat;";
            List<noingoaithat> noingoaithats = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
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
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<noingoaithat>(sqlDeleteAllnoingoaithat);
            }
        }
    }
}
