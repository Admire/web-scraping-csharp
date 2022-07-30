using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NhamoigioiController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToNhamoigioi = $"INSERT INTO Nhamoigioi VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToNhamoigioi += "(DEFAULT ";
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
                    sqlInsertToNhamoigioi += $",'{insert}'";
                }
                sqlInsertToNhamoigioi += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToNhamoigioi += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhamoigioi>(sqlInsertToNhamoigioi);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllNhamoigioi = "SELECT * FROM Nhamoigioi";
            List<Nhamoigioi> Nhamoigiois = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Nhamoigiois = db.Query<Nhamoigioi>(sqlGetAllNhamoigioi).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Nhamoigioi Nhamoigioi in Nhamoigiois)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Nhamoigioi.url;
                item.SubItems.Add(Nhamoigioi.ten);
                item.SubItems.Add(Nhamoigioi.diachi);
                item.SubItems.Add(Nhamoigioi.dienthoai);
                item.SubItems.Add(Nhamoigioi.email);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllNhamoigioi = $"DELETE FROM Nhamoigioi";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhamoigioi>(sqlDeleteAllNhamoigioi);
            }
        }
    }
}
