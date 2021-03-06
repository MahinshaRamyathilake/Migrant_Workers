using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationWorkersWeb.Migrations
{
    public partial class AddEmbassyContatcNoToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Embassy_Contact_Nos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmbassyID = table.Column<int>(type: "int", nullable: false),
                    Contact_No = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embassy_Contact_Nos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Embassy_Contact_Nos_Embassies_EmbassyID",
                        column: x => x.EmbassyID,
                        principalTable: "Embassies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Embassy_Contact_Nos_EmbassyID",
                table: "Embassy_Contact_Nos",
                column: "EmbassyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embassy_Contact_Nos");
        }
    }
}
