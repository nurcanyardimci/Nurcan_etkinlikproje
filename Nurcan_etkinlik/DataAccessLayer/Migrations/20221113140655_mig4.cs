using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_AboutID",
                table: "Writers",
                column: "AboutID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AboutID",
                table: "Users",
                column: "AboutID");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AboutID",
                table: "Admins",
                column: "AboutID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Abouts_AboutID",
                table: "Admins",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Abouts_AboutID",
                table: "Users",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Abouts_AboutID",
                table: "Writers",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Abouts_AboutID",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Abouts_AboutID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Abouts_AboutID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_AboutID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Users_AboutID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AboutID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "Admins");
        }
    }
}
