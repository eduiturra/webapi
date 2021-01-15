using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webapi.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "archivosTipo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archivosTipo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "archivos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    idTipoArchivo = table.Column<int>(nullable: false),
                    Indice = table.Column<int>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    Preview = table.Column<string>(nullable: true),
                    File = table.Column<string>(nullable: true),
                    idCarpeta = table.Column<int>(nullable: true),
                    Creador = table.Column<string>(nullable: true),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archivos", x => x.id);
                    table.ForeignKey(
                        name: "FK_archivos_archivos_idCarpeta",
                        column: x => x.idCarpeta,
                        principalTable: "archivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_archivos_archivosTipo_idTipoArchivo",
                        column: x => x.idTipoArchivo,
                        principalTable: "archivosTipo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "archivoMateriales",
                columns: table => new
                {
                    idArchivo = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archivoMateriales", x => x.idArchivo);
                    table.ForeignKey(
                        name: "FK_archivoMateriales_archivos_idArchivo",
                        column: x => x.idArchivo,
                        principalTable: "archivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "archivosLog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    idArchivo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_archivosLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_archivosLog_archivos_idArchivo",
                        column: x => x.idArchivo,
                        principalTable: "archivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_archivos_idCarpeta",
                table: "archivos",
                column: "idCarpeta");

            migrationBuilder.CreateIndex(
                name: "IX_archivos_idTipoArchivo",
                table: "archivos",
                column: "idTipoArchivo");

            migrationBuilder.CreateIndex(
                name: "IX_archivosLog_idArchivo",
                table: "archivosLog",
                column: "idArchivo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "archivoMateriales");

            migrationBuilder.DropTable(
                name: "archivosLog");

            migrationBuilder.DropTable(
                name: "archivos");

            migrationBuilder.DropTable(
                name: "archivosTipo");
        }
    }
}
