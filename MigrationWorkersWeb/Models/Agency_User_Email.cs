using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class Agency_User_Email
    {
        [Key]
        public int Id { get; set; }

        public int? AgencyUserID { get; set; }
        [ForeignKey("AgencyUserID")]
        public virtual Agency_User AgencyUser { get; set; }

        public string Email { get; set; }
    }
}
