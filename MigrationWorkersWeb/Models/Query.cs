using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class Query
    {
        [Key]
        public int Id { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public int? To { get; set; }
        [ForeignKey("To")]
        public virtual Embassy Embassy { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
