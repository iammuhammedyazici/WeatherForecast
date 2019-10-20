using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HavaDurumu.Api.Migrations
{
    public partial class DatabaseContextDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WEATHERFORECAST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CITY = table.Column<string>(nullable: true),
                    CELCIUS = table.Column<int>(nullable: false),
                    STATUS = table.Column<string>(nullable: true),
                    HUMIDITY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEATHERFORECAST", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WEATHERFORECAST");
        }
    }
}
