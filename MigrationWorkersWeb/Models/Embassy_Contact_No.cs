using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class Embassy_Contact_No
    {
        [Key]
        public int Id { get; set; }

        public int? EmbassyID { get; set; }
        [ForeignKey("EmbassyID")]
        public virtual Embassy Embassy { get; set; }

        public string Contact_No { get; set; }
    }
}
