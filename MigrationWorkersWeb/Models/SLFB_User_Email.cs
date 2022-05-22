using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class SLFB_User_Email
    {
        [Key]
        public int Id { get; set; }

        public int? SLFBUserID { get; set; }
        [ForeignKey("SLFBUserID")]
        public virtual SLFB_User SLFB_User { get; set; }

        public string Email { get; set; }
    }
}
