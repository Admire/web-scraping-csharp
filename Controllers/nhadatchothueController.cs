using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NhadatchothueController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToNhadatchothue = $"INSERT INTO Nhadatchothue VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToNhadatchothue += "(DEFAULT ";
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
                    sqlInsertToNhadatchothue += $",'{insert}'";
                }
                sqlInsertToNhadatchothue += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToNhadatchothue += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatchothue>(sqlInsertToNhadatchothue);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllNhadatchothue = "SELECT * FROM Nhadatchothue";
            List<Nhadatchothue> Nhadatchothues = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Nhadatchothues = db.Query<Nhadatchothue>(sqlGetAllNhadatchothue).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Nhadatchothue Nhadatchothue in Nhadatchothues)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Nhadatchothue.url;
                item.SubItems.Add(Nhadatchothue.tieude);
                item.SubItems.Add(Nhadatchothue.gia);
                item.SubItems.Add(Nhadatchothue.giam2);
                item.SubItems.Add(Nhadatchothue.dientich);
                item.SubItems.Add(Nhadatchothue.diachi);
                item.SubItems.Add(Nhadatchothue.ngaydangbai);
                item.SubItems.Add(Nhadatchothue.nenxem);

                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllNhadatchothue = $"DELETE FROM Nhadatchothue";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatchothue>(sqlDeleteAllNhadatchothue);
            }
        }
    }
}
