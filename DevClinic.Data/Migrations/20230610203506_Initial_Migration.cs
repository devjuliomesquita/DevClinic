using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Register = table.Column<string>(type: "varchar(50)", nullable: false),
                    Plan = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(1)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "varchar(13)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(1)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Specialities", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "DoctorSpeciality",
                columns: table => new
                {
                    DoctorsId = table.Column<int>(type: "int", nullable: false),
                    SpecialitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpeciality", x => new { x.DoctorsId, x.SpecialitiesId });
                    table.ForeignKey(
                        name: "FK_DoctorSpeciality_tb_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "tb_Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSpeciality_tb_Specialities_SpecialitiesId",
                        column: x => x.SpecialitiesId,
                        principalTable: "tb_Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpeciality_SpecialitiesId",
                table: "DoctorSpeciality",
                column: "SpecialitiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "DoctorSpeciality");

            migrationBuilder.DropTable(
                name: "tb_Address");

            migrationBuilder.DropTable(
                name: "tb_ContactEmail");

            migrationBuilder.DropTable(
                name: "tb_ContactPhone");

            migrationBuilder.DropTable(
                name: "tb_Doctors");

            migrationBuilder.DropTable(
                name: "tb_Specialities");

            migrationBuilder.DropTable(
                name: "tb_Clients");
        }
    }
}
