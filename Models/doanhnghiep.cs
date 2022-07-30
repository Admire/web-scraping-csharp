using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraping_csharp.Models
{
    [Table("doanhnghiep")]
    public class Doanhnghiep
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }
        public string ten { get; set; }
    }
}
