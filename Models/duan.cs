using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("duan")]
    public class Duan
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string tieude { get; set; }
        public string giam2 { get; set; }
        public string dientich { get; set; }
        public string socanho { get; set; }
        public string sonhatoa { get; set; }
        public string diachi { get; set; }
        public string congty { get; set; }
        public string tinhtrang { get; set; }
    }
}
