using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatePass.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_db_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plate_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlateUserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateId = table.Column<int>(type: "int", nullable: false),
                    PassDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSafePlate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateUserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlateUserDetail_Plate_PlateId",
                        column: x => x.PlateId,
                        principalTable: "Plate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plate_UserId",
                table: "Plate",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlateUserDetail_PlateId",
                table: "PlateUserDetail",
                column: "PlateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlateUserDetail");

            migrationBuilder.DropTable(
                name: "Plate");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
