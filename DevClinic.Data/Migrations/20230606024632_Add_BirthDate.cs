
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Add_BirthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Doctor_Specility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Speciality",
                table: "tb_Speciality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Doctor",
                table: "tb_Doctor");

            migrationBuilder.RenameTable(
                name: "tb_Speciality",
                newName: "Specialities");

            migrationBuilder.RenameTable(
                name: "tb_Doctor",
                newName: "Doctors");

            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Specialities",
                newName: "NameSpeciality");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "tb_Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "NameSpeciality",
                table: "Specialities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Doctors",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Register",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "tb_Clients");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Specialities",
                newName: "tb_Speciality");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "tb_Doctor");

            migrationBuilder.RenameColumn(
                name: "NameSpeciality",
                table: "tb_Speciality",
                newName: "Speciality");

            migrationBuilder.AlterColumn<string>(
                name: "Speciality",
                table: "tb_Speciality",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "tb_Doctor",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Register",
                table: "tb_Doctor",
                type: "varchar(6)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "tb_Doctor",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tb_Doctor",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "tb_Doctor",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "tb_Doctor",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Speciality",
                table: "tb_Speciality",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Doctor",
                table: "tb_Doctor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tb_Doctor_Specility",
                columns: table => new
                {
                    SpecilityId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Doctor_Specility", x => new { x.SpecilityId, x.DoctorId });
                    table.ForeignKey(
                        name: "FK_tb_Doctor_Specility_tb_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "tb_Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Doctor_Specility_tb_Speciality_SpecilityId",
                        column: x => x.SpecilityId,
                        principalTable: "tb_Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Doctor_Specility_DoctorId",
                table: "tb_Doctor_Specility",
                column: "DoctorId");
        }
    }
}
