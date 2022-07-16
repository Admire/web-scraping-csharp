using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class tintucController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTotintuc = $"INSERT INTO tintuc VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTotintuc += "(DEFAULT ";
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
                    sqlInsertTotintuc += $",'{insert}'";
                }
                sqlInsertTotintuc += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTotintuc += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new Form1().getConnection()))
            {
                db.Query<tintuc>(sqlInsertTotintuc);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAlltintuc = "SELECT * FROM tintuc";
            List<tintuc> tintucs = new();
            using (IDbConnection db = new MySqlConnection(new Form1().getConnection()))
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
           
            using (IDbConnection db = new MySqlConnection(new Form1().getConnection()))
            {
                db.Query<tintuc>(sqlDeleteAlltintuc);
            }
        }
    }
}
