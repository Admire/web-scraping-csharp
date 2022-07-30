using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class DoanhnghiepController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToDoanhnghiep = $"INSERT INTO Doanhnghiep VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToDoanhnghiep += "(DEFAULT ";
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
                    sqlInsertToDoanhnghiep += $",'{insert}'";
                }
                sqlInsertToDoanhnghiep += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToDoanhnghiep += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection( new databaseConnectionString().GetConnection()))
            {
                db.Query<Doanhnghiep>(sqlInsertToDoanhnghiep);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllDoanhnghiep = "SELECT * FROM Doanhnghiep";
            List<Doanhnghiep> Doanhnghieps = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Doanhnghieps = db.Query<Doanhnghiep>(sqlGetAllDoanhnghiep).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Doanhnghiep Doanhnghiep in Doanhnghieps)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Doanhnghiep.url;
                item.SubItems.Add(Doanhnghiep.ten);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllDoanhnghiep = $"DELETE FROM Doanhnghiep";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Doanhnghiep>(sqlDeleteAllDoanhnghiep);
            }
        }
    }
}
