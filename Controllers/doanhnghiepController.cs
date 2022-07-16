using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class doanhnghiepController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertTodoanhnghiep = $"INSERT INTO doanhnghiep VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertTodoanhnghiep += "(DEFAULT ";
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
                    sqlInsertTodoanhnghiep += $",'{insert}'";
                }
                sqlInsertTodoanhnghiep += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertTodoanhnghiep += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection( new databaseConnectionString().getConnection()))
            {
                db.Query<doanhnghiep>(sqlInsertTodoanhnghiep);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAlldoanhnghiep = "SELECT * FROM doanhnghiep";
            List<doanhnghiep> doanhnghieps = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                doanhnghieps = db.Query<doanhnghiep>(sqlGetAlldoanhnghiep).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (doanhnghiep doanhnghiep in doanhnghieps)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  doanhnghiep.url;
                item.SubItems.Add(doanhnghiep.ten);
                result.Add(item);
            }
            return result;
        }
        public void queryDeleteAll()
        {

            string sqlDeleteAlldoanhnghiep = $"DELETE FROM doanhnghiep";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().getConnection()))
            {
                db.Query<doanhnghiep>(sqlDeleteAlldoanhnghiep);
            }
        }
    }
}
