using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("nhamoigioi")]
    public class Nhamoigioi
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public string email { get; set; }
    }
}
