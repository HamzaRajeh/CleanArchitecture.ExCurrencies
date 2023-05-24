using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Currencies_CurrenciesId",
                table: "ExCurrenciesDashboard");

 

            migrationBuilder.DropIndex(
                name: "IX_ExCurrenciesDashboard_CurrenciesId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.AlterColumn<int>(
                name: "CurrenciesId",
                table: "ExCurrenciesDashboard",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);



            migrationBuilder.AddPrimaryKey(
                name: "PK_ExCurrenciesDashboard",
                table: "ExCurrenciesDashboard",
                columns: new[] { "CurrenciesId", "ApplicationUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExCurrenciesDashboard_Currencies_CurrenciesId",
                table: "ExCurrenciesDashboard",
                column: "CurrenciesId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExCurrenciesDashboard_Currencies_CurrenciesId",
                table: "ExCurrenciesDashboard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExCurrenciesDashboard",
                table: "ExCurrenciesDashboard");



            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ExCurrenciesDashboard",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "CurrenciesId",
                table: "ExCurrenciesDashboard",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExCurrenciesDashboard",
                table: "ExCurrenciesDashboard",
                column: "Id");

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
        }
    }
}
