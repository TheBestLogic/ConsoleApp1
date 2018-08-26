using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class MigrateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rewiews_",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    FeedbackEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewiews_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics_",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharactericticText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media_",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products_",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductToCharacteristics_",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    CharactericticID = table.Column<int>(nullable: false),
                    CharactericticName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductToCharacteristics_", x => new { x.ProductID, x.CharactericticID });
                    table.ForeignKey(
                        name: "FK_ProductToCharacteristics__Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rewiews_");

            migrationBuilder.DropTable(
                name: "Characteristics_");

            migrationBuilder.DropTable(
                name: "Media_");

            migrationBuilder.DropTable(
                name: "ProductToCharacteristics_");

            migrationBuilder.DropTable(
                name: "Products_");
        }
    }
}
