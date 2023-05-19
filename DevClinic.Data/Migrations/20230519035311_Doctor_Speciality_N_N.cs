using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class Doctor_Speciality_N_N : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Speciality_tb_Doctor_DoctorId",
                table: "tb_Speciality");

            migrationBuilder.DropIndex(
                name: "IX_tb_Speciality_DoctorId",
                table: "tb_Speciality");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "tb_Speciality");

            migrationBuilder.CreateTable(
                name: "tb_Doctor_Specility",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    SpecilityId = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Doctor_Specility");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "tb_Speciality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Speciality_DoctorId",
                table: "tb_Speciality",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Speciality_tb_Doctor_DoctorId",
                table: "tb_Speciality",
                column: "DoctorId",
                principalTable: "tb_Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
