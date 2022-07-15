using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class nhadatbanController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonhadatban = $"INSERT INTO nhadatban VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonhadatban += "(DEFAULT ";
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
                    sqlInsertTonhadatban += $",'{insert}'";
                }
                sqlInsertTonhadatban += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonhadatban += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<nhadatban>(sqlInsertTonhadatban);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnhadatban = "SELECT * FROM nhadatban";
            List<nhadatban> nhadatbans = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
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
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().connectionString))
            {
                db.Query<nhadatban>(sqlDeleteAllnhadatban);
            }
        }
    }
}
