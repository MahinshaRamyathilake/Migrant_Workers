using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationWorkersWeb.Models
{
    public class Agency_Contact_No
    {
        [Key]
        public int Id { get; set; }

        public int? AgencyID { get; set; }
        [ForeignKey("AgencyID")]
        public virtual Agency Agency { get; set; }

        public string Contact_No { get; set; }
    }
}
