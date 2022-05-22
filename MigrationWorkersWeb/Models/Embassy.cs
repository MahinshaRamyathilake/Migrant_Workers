using System.ComponentModel.DataAnnotations;

namespace MigrationWorkersWeb.Models
{
    public class Embassy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Ambassador { get; set; }
    }
}
