using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExCurrency.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class colDoneCurrencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Currencies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Currencies");
        }
    }
}
