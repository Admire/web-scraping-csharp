using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("nhadatban")]
    public class Nhadatban
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string tieude { get; set; }
        public string gia { get; set; }
        public string giam2 { get; set; }
        public string dientich { get; set; }
        public string diachi { get; set; }
        public string ngaydangbai { get; set; }
        public string nenxem { get; set; }
    }
}
