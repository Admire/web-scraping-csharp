using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("phongthuy")]
    public class Phongthuy
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string tieude { get; set; }
    }
}
