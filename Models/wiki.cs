using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("wiki")]
    public class Wiki
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string tieude { get; set; }
    }
}
