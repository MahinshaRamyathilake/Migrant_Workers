using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class Embassy_User_Email
    {
        [Key]
        public int Id { get; set; }

        public int? EmbassyUserID { get; set; }
        [ForeignKey("EmbassyUserID")]
        public virtual Embassy_User User { get; set; }

        public string Email { get; set; }
    }
}
