using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class AddList_Email_Phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "tb_Clients");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tb_Clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Doctors");

            migrationBuilder.CreateTable(
                name: "tb_ContactEmail",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ContactEmail", x => new { x.ClientId, x.Email });
                    table.ForeignKey(
                        name: "FK_tb_ContactEmail_tb_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tb_Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_ContactPhone",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ContactPhone", x => new { x.ClientId, x.Phone });
                    table.ForeignKey(
                        name: "FK_tb_ContactPhone_tb_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tb_Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_ContactEmail");

            migrationBuilder.DropTable(
                name: "tb_ContactPhone");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tb_Clients",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tb_Clients",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
