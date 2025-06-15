using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoansApp.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IncludingFeesAndLoanBalanceInLoanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InterestIncome",
                table: "Loans",
                newName: "RemainingFees");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "LoanBalance",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanBalance",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "RemainingFees",
                table: "Loans",
                newName: "InterestIncome");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Loans",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
