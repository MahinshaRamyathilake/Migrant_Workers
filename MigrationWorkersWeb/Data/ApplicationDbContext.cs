using MigrationWorkersWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MigrationWorkersWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Agency_email> Agency_emails { get; set; }
        public DbSet<Agency_Contact_No> Agency_Contact_Nos { get; set; }
        public DbSet<Embassy> Embassies { get; set; }
        public DbSet<Embassy_Email> Embassy_Emails { get; set; }
        public DbSet<Embassy_Contact_No> Embassy_Contact_Nos { get; set; }
        public DbSet<Embassy_User> Embassy_Users { get; set; }
        public DbSet<Embassy_User_Email> Embassy_User_Emails { get; set; }
        public DbSet<Agency_User> Agency_Users { get; set; }
        public DbSet<Agency_User_Email> Agency_User_Emails { get; set; }
        public DbSet<SLFB_User> SLFB_Users { get; set; }
        public DbSet<SLFB_User_Email> SLFB_User_Emails { get; set; }
        public DbSet<Query> Queries { get; set; }
    }
}
