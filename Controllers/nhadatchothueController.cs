using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class nhadatchothueController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTonhadatchothue = $"INSERT INTO nhadatchothue VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTonhadatchothue += "(DEFAULT ";
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
                    sqlInsertTonhadatchothue += $",'{insert}'";
                }
                sqlInsertTonhadatchothue += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTonhadatchothue += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<nhadatchothue>(sqlInsertTonhadatchothue);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllnhadatchothue = "SELECT * FROM nhadatchothue";
            List<nhadatchothue> nhadatchothues = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
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
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<nhadatchothue>(sqlDeleteAllnhadatchothue);
            }
        }
    }
}
