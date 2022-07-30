using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class NhadatbanController
    {
        public void QueryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToNhadatban = $"INSERT INTO Nhadatban VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToNhadatban += "(DEFAULT ";
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
                    sqlInsertToNhadatban += $",'{insert}'";
                }
                sqlInsertToNhadatban += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToNhadatban += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatban>(sqlInsertToNhadatban);
            }
        }
        public List<ListViewItem> QueryFetchAll()
        {
            string sqlGetAllNhadatban = "SELECT * FROM Nhadatban";
            List<Nhadatban> Nhadatbans = new();
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                Nhadatbans = db.Query<Nhadatban>(sqlGetAllNhadatban).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (Nhadatban Nhadatban in Nhadatbans)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  Nhadatban.url;
                item.SubItems.Add(Nhadatban.tieude);
                item.SubItems.Add(Nhadatban.gia);
                item.SubItems.Add(Nhadatban.giam2);
                item.SubItems.Add(Nhadatban.dientich);
                item.SubItems.Add(Nhadatban.diachi);
                item.SubItems.Add(Nhadatban.ngaydangbai);
                item.SubItems.Add(Nhadatban.nenxem);

                result.Add(item);
            }
            return result;
        }
        public void QueryDeleteAll()
        {

            string sqlDeleteAllNhadatban = $"DELETE FROM Nhadatban";
           
            using (IDbConnection db = new MySqlConnection(new databaseConnectionString().GetConnection()))
            {
                db.Query<Nhadatban>(sqlDeleteAllNhadatban);
            }
        }
    }
}
