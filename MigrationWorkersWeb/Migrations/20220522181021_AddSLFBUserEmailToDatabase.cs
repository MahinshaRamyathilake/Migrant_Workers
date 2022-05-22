using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationWorkersWeb.Migrations
{
    public partial class AddSLFBUserEmailToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SLFB_User_Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SLFBUserID = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLFB_User_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SLFB_User_Emails_SLFB_Users_SLFBUserID",
                        column: x => x.SLFBUserID,
                        principalTable: "SLFB_Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SLFB_User_Emails_SLFBUserID",
                table: "SLFB_User_Emails",
                column: "SLFBUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SLFB_User_Emails");
        }
    }
}
