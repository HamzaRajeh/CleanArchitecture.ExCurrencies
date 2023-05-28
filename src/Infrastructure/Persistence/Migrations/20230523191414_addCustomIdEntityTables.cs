using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCustomIdEntityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesHistory_Users_ApplicationUserId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "ExCurrenciesHistory",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_ExCurrenciesHistory_ApplicationUserId",
                table: "ExCurrenciesHistory",
                newName: "IX_ExCurrenciesHistory_UsersId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BaseCurrencyID",
                table: "Users",
                column: "BaseCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesDashboard_UsersId",
                table: "ExCurrenciesDashboard",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_UsersId",
                table: "ExCurrenciesDashboard",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesHistory_Users_UsersId",
                table: "ExCurrenciesHistory",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");

 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_UsersId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesHistory_Users_UsersId",
                table: "ExCurrenciesHistory");



            migrationBuilder.DropIndex(
                name: "IX_Users_BaseCurrencyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_UsersId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "ExCurrenciesHistory",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ExCurrenciesHistory_UsersId",
                table: "ExCurrenciesHistory",
                newName: "IX_ExCurrenciesHistory_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesDashboard_ApplicationUserId",
                table: "ExCurrenciesDashboard",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_ApplicationUserId",
                table: "ExCurrenciesDashboard",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesHistory_Users_ApplicationUserId",
                table: "ExCurrenciesHistory",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
