using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Users_UsersId",
                table: "ExCurrenciesDashboard");


            migrationBuilder.DropIndex(
                name: "IX_Users_BaseCurrencyID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_UsersId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "BaseCurrencyID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.AddColumn<string>(
                name: "POSTURL",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_ApplicationUserId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropColumn(
                name: "POSTURL",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "BaseCurrencyID",
                table: "Users",
                type: "int",
                nullable: true);

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

        }
    }
}
