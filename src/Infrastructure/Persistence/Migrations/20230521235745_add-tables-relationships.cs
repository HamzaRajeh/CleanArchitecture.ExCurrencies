using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addtablesrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropColumn(
                name: "CurrencyID",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ExCurrenciesDashboard");

            migrationBuilder.RenameColumn(
                name: "CurrencyID",
                table: "ExCurrenciesHistory",
                newName: "CurrencyId");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "ExCurrenciesHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesHistory",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrenciesId",
                table: "ExCurrenciesDashboard",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesHistory_ApplicationUserId",
                table: "ExCurrenciesHistory",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesHistory_CurrencyId",
                table: "ExCurrenciesHistory",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesDashboard_ApplicationUserId",
                table: "ExCurrenciesDashboard",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExCurrenciesDashboard_CurrenciesId",
                table: "ExCurrenciesDashboard",
                column: "CurrenciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesDashboard_Currencies_CurrenciesId",
                table: "ExCurrenciesDashboard",
                column: "CurrenciesId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_ApplicationUserId",
                table: "ExCurrenciesDashboard",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesHistory_Currencies_CurrencyId",
                table: "ExCurrenciesHistory",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesHistory_Users_ApplicationUserId",
                table: "ExCurrenciesHistory",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Currencies_CurrenciesId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesHistory_Currencies_CurrencyId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesHistory_Users_ApplicationUserId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesHistory_ApplicationUserId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesHistory_CurrencyId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_CurrenciesId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ExCurrenciesHistory");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "CurrenciesId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "ExCurrenciesHistory",
                newName: "CurrencyID");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyID",
                table: "ExCurrenciesHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ExCurrenciesHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyID",
                table: "ExCurrenciesDashboard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
