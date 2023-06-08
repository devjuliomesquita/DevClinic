using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Address_Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Address",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Number = table.Column<string>(type: "varchar(10)", nullable: true),
                    Complement = table.Column<string>(type: "varchar(50)", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Address", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_tb_Address_tb_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tb_Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Address");
        }
    }
}
