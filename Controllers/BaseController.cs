using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;
using web_scraping_csharp.Models;
using web_scraping_csharp.Services;

namespace web_scraping_csharp.Controllers
{
    public class BaseController
    {
        public string InsertString(List<ListViewItem> item, string tableName)
        {
            string sqlInsertString = $"INSERT INTO {tableName} VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertString += "(DEFAULT ";
                List<string> insertList = new();
                Char value = '\'';
                for (int i = 0; i < item2.SubItems.Count; i++)
                {
                    string test = item2.SubItems[i].Text;
                    if (test.Contains(value))
                    {
                        insertList.Add(String.Join("\\'", test.Split(value)));
                    }
                    else
                    {
                        insertList.Add(test);
                    }
                }
                foreach (string insert in insertList)
                {
                    sqlInsertString += $",'{insert}'";
                }
                sqlInsertString += ") ";

                if (item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertString += ',';
                }
            }
            return sqlInsertString;
        }
        public string SelectString(string tableName)
        {
            string sqlSelectString = $"SELECT * FROM {tableName}";
            return sqlSelectString;
        }
        public string DeleteString(string tableName)
        {
            string sqlDeleteString = $"DELETE FROM {tableName}";
            return sqlDeleteString;
        }
        public List<ListViewItem>  GenerateTable<T>(List<T> list){
            List<ListViewItem> result = new List<ListViewItem>();
            foreach (var record in list)
            {
                Type t = record.GetType();
                PropertyInfo[] props = t.GetProperties();
                ListViewItem item = new ListViewItem();
                item.Text = props[1].GetValue(record, null).ToString();
                for (int i = 2; i < props.Length; i++)
                {
                    if (props[i].GetValue(record, null) != null)
                    {
                        item.SubItems.Add(props[i].GetValue(record, null).ToString());
                    }
                    else
                    {
                        item.SubItems.Add("Trống");
                    }
                }
                result.Add(item);
            }
            return result;
        }
    }
}