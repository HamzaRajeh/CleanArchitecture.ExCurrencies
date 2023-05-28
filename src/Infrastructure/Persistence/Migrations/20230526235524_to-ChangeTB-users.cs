using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class toChangeTBusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesHistory_Users_UsersId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesHistory_UsersId",
                table: "ExCurrenciesHistory");

            migrationBuilder.AlterColumn<string>(
                name: "UsersId",
                table: "ExCurrenciesHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsersId",
                table: "ExCurrenciesHistory",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesHistory_UsersId",
                table: "ExCurrenciesHistory",
                column: "UsersId");
 
 

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesHistory_Users_UsersId",
                table: "ExCurrenciesHistory",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
