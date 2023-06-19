using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace veterinaria_backend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorialMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vacunas_desparacitaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paciente_mascota_id = table.Column<int>(type: "int", nullable: false),
                    propietario_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialMedicas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitaMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horaCita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    consultorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaMedicas", x => x.id);
                    table.ForeignKey(
                        name: "FK_CitaMedicas_HistorialMedicas_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichaMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color_mucosas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Palpitacion_abdominal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genitales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Pulso_femoral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaMedicas", x => x.id);
                    table.ForeignKey(
                        name: "FK_FichaMedicas_HistorialMedicas_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    specie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false),
                    historialMedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pacientes_HistorialMedicas_historialMedicoId",
                        column: x => x.historialMedicoId,
                        principalTable: "HistorialMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    historialMedicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Propietario_HistorialMedicas_historialMedicoId",
                        column: x => x.historialMedicoId,
                        principalTable: "HistorialMedicas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    ContraseñaHash = table.Column<string>(type: "varchar(50)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_rolId",
                        column: x => x.rolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Experiencia = table.Column<string>(type: "varchar(50)", nullable: false),
                    Educacion = table.Column<string>(type: "varchar(50)", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicos_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Horario = table.Column<string>(type: "varchar(50)", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personal_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicas_HistorialMedicoId",
                table: "CitaMedicas",
                column: "HistorialMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FichaMedicas_HistorialMedicoId",
                table: "FichaMedicas",
                column: "HistorialMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_usuarioId",
                table: "Medicos",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_historialMedicoId",
                table: "Pacientes",
                column: "historialMedicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_usuarioId",
                table: "Personal",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietario_historialMedicoId",
                table: "Propietario",
                column: "historialMedicoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_rolId",
                table: "Usuarios",
                column: "rolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitaMedicas");

            migrationBuilder.DropTable(
                name: "FichaMedicas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "HistorialMedicas");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
