using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addBasecolUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountDescription",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BaseCurrencyID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountDescription",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BaseCurrencyID",
                table: "Users");
        }
    }
}
