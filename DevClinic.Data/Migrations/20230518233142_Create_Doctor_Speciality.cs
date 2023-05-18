using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Create_Doctor_Speciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Doctors_DoctorId",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
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

            migrationBuilder.RenameIndex(
                name: "IX_Specialities_DoctorId",
                table: "tb_Speciality",
                newName: "IX_tb_Speciality_DoctorId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Speciality_tb_Doctor_DoctorId",
                table: "tb_Speciality",
                column: "DoctorId",
                principalTable: "tb_Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Speciality_tb_Doctor_DoctorId",
                table: "tb_Speciality");

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

            migrationBuilder.RenameIndex(
                name: "IX_tb_Speciality_DoctorId",
                table: "Specialities",
                newName: "IX_Specialities_DoctorId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Doctors_DoctorId",
                table: "Specialities",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
