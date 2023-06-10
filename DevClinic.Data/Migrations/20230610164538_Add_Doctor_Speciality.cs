using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Add_Doctor_Speciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Register",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Specialities",
                newName: "tb_Specialities");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "tb_Doctors");

            migrationBuilder.RenameColumn(
                name: "NameSpeciality",
                table: "tb_Specialities",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tb_Specialities",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "tb_Specialities",
                type: "varchar(300)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "tb_Doctors",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tb_Doctors",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "tb_Doctors",
                type: "varchar(11)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CRM",
                table: "tb_Doctors",
                type: "varchar(13)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Specialities",
                table: "tb_Specialities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Doctors",
                table: "tb_Doctors",
                column: "Id");

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
                name: "DoctorSpeciality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Specialities",
                table: "tb_Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Doctors",
                table: "tb_Doctors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "tb_Specialities");

            migrationBuilder.DropColumn(
                name: "CRM",
                table: "tb_Doctors");

            migrationBuilder.RenameTable(
                name: "tb_Specialities",
                newName: "Specialities");

            migrationBuilder.RenameTable(
                name: "tb_Doctors",
                newName: "Doctors");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Specialities",
                newName: "NameSpeciality");

            migrationBuilder.AlterColumn<string>(
                name: "NameSpeciality",
                table: "Specialities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Doctors",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
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

            migrationBuilder.AddColumn<string>(
                name: "Register",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");
        }
    }
}
