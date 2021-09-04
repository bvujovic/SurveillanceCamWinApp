using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SurveillanceCamWinApp.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    IdCam = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeviceName = table.Column<string>(nullable: false),
                    IpLastNum = table.Column<int>(nullable: false),
                    LastImageDL = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.IdCam);
                });

            migrationBuilder.CreateTable(
                name: "DateDirs",
                columns: table => new
                {
                    IdDateDir = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CameraId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImgCountSDC = table.Column<int>(nullable: true),
                    ImgCountLocal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDirs", x => x.IdDateDir);
                    table.ForeignKey(
                        name: "FK_DateDirs_Cameras_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Cameras",
                        principalColumn: "IdCam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageFiles",
                columns: table => new
                {
                    IdImageFile = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateDirId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ExistsOnSDC = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFiles", x => x.IdImageFile);
                    table.ForeignKey(
                        name: "FK_ImageFiles_DateDirs_DateDirId",
                        column: x => x.DateDirId,
                        principalTable: "DateDirs",
                        principalColumn: "IdDateDir",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateDirs_CameraId",
                table: "DateDirs",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFiles_DateDirId",
                table: "ImageFiles",
                column: "DateDirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "ImageFiles");

            migrationBuilder.DropTable(
                name: "DateDirs");

            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}
