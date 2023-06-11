using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevClinic.Data.Migrations
{
    public partial class add_table_doctorsSpecialities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorSpeciality");

            migrationBuilder.CreateTable(
                name: "tb_DoctorsSpecialities",
                columns: table => new
                {
                    id_doctor = table.Column<int>(type: "int", nullable: false),
                    id_speciality = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DoctorsSpecialities", x => new { x.id_doctor, x.id_speciality });
                    table.ForeignKey(
                        name: "FK_tb_DoctorsSpecialities_tb_Doctors_id_doctor",
                        column: x => x.id_doctor,
                        principalTable: "tb_Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_DoctorsSpecialities_tb_Specialities_id_speciality",
                        column: x => x.id_speciality,
                        principalTable: "tb_Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_DoctorsSpecialities_id_speciality",
                table: "tb_DoctorsSpecialities",
                column: "id_speciality");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_DoctorsSpecialities");

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
    }
}
