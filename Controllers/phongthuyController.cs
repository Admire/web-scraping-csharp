using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class PhongthuyController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToPhongthuy = $"INSERT INTO Phongthuy VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToPhongthuy += "(DEFAULT ";
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
                    sqlInsertToPhongthuy += $",'{insert}'";
                }
                sqlInsertToPhongthuy += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToPhongthuy += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Phongthuy>(sqlInsertToPhongthuy);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllPhongthuy = "SELECT * FROM Phongthuy";
            List<Phongthuy> Phongthuys = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Phongthuys = db.Query<Phongthuy>(sqlGetAllPhongthuy).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Phongthuy Phongthuy in Phongthuys)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Phongthuy.url;
                item.SubItems.Add(Phongthuy.tieude);
                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllPhongthuy = $"DELETE FROM Phongthuy";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Phongthuy>(sqlDeleteAllPhongthuy);
            }
        }
    }
}
