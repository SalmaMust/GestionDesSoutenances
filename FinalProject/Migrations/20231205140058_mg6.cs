using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class mg6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Soutenance_PFE_PFEID",
                table: "Soutenance");

            migrationBuilder.AlterColumn<int>(
                name: "RapporteurID",
                table: "Soutenance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PresidentID",
                table: "Soutenance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PFEID",
                table: "Soutenance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tel",
                table: "Societe",
                type: "int",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AddForeignKey(
                name: "FK_Soutenance_PFE_PFEID",
                table: "Soutenance",
                column: "PFEID",
                principalTable: "PFE",
                principalColumn: "PFEID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Soutenance_PFE_PFEID",
                table: "Soutenance");

            migrationBuilder.AlterColumn<int>(
                name: "RapporteurID",
                table: "Soutenance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PresidentID",
                table: "Soutenance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PFEID",
                table: "Soutenance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "Societe",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 8);

            migrationBuilder.AddForeignKey(
                name: "FK_Soutenance_PFE_PFEID",
                table: "Soutenance",
                column: "PFEID",
                principalTable: "PFE",
                principalColumn: "PFEID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
