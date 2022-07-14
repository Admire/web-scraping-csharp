using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using web_scraping_csharp.Models;

namespace web_scraping_csharp.Controllers
{
    public class nhabandatController
    {
        public void queryInsertAll(List<ListViewItem> item)
        {

            string sqlInsertToNhabandat = $"INSERT INTO nhabandat VALUES ";
            foreach (ListViewItem item2 in item)
            {
                sqlInsertToNhabandat += $"(DEFAULT, '{item2.SubItems[0].Text}','{item2.SubItems[1].Text}','{item2.SubItems[2].Text}','{item2.SubItems[3].Text}','{item2.SubItems[4].Text}','{item2.SubItems[5].Text}','{item2.SubItems[6].Text}','{item2.SubItems[7].Text}')";
                if(item.IndexOf(item2) != item.Count() - 1)
                {
                    sqlInsertToNhabandat += ',';
                }
            }
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                db.Query<nhabandat>(sqlInsertToNhabandat);
            }
        }
        public List<ListViewItem> queryFetchAll()
        {
            string sqlGetAllNhabandat = "SELECT * FROM nhabandat;";
            List<nhabandat> nhabandats = new();
            using (IDbConnection db = new MySqlConnection("server=localhost;port=5060;user=root;password=140300;database=batdongsan"))
            {
                nhabandats = db.Query<nhabandat>(sqlGetAllNhabandat).ToList();
            }
            List< ListViewItem > result = new List<ListViewItem>();
            foreach (nhabandat nhabandat in nhabandats)
            {
                ListViewItem item = new ListViewItem();

                item.Text =  nhabandat.url;
                item.SubItems.Add(nhabandat.tieude);
                item.SubItems.Add(nhabandat.gia);
                item.SubItems.Add(nhabandat.giam2);
                item.SubItems.Add(nhabandat.dientich);
                item.SubItems.Add(nhabandat.diachi);
                item.SubItems.Add(nhabandat.ngaydangbai);
                item.SubItems.Add(nhabandat.nenxem);

                result.Add(item);
            }
            return result;
        }
    }
}
