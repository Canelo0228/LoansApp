using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoansApp.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixingVariablesTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Loans_LoanID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "LoanValue",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "MonthDay",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "LoanBalance",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "loanNumber",
                table: "Records",
                newName: "TotalInterestIncome");

            migrationBuilder.RenameColumn(
                name: "TotalInterestIncomes",
                table: "Records",
                newName: "OriginalLoanAmount");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Records",
                newName: "MonthlyPrincipal");

            migrationBuilder.RenameColumn(
                name: "MonthlyIncome",
                table: "Records",
                newName: "MonthlyPayment");

            migrationBuilder.RenameColumn(
                name: "MonthlyCapital",
                table: "Records",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "LoanID",
                table: "Payments",
                newName: "LoanId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Payments",
                newName: "Date");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_LoanID",
                table: "Payments",
                newName: "IX_Payments_LoanId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Loans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Loans",
                newName: "OutstandingBalance");

            migrationBuilder.RenameColumn(
                name: "TotalIncome",
                table: "Loans",
                newName: "OriginalLoanAmount");

            migrationBuilder.RenameColumn(
                name: "RemainingFees",
                table: "Loans",
                newName: "MonthlyPrincipal");

            migrationBuilder.RenameColumn(
                name: "PayDay",
                table: "Loans",
                newName: "MonthlyPayment");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Loans",
                newName: "MonthlyInterest");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Loans",
                newName: "CustomerName");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "PaymentDay",
                table: "Loans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingInstallments",
                table: "Loans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Loans_LoanId",
                table: "Payments",
                column: "LoanId",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Loans_LoanId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentDay",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "RemainingInstallments",
                table: "Loans");

            migrationBuilder.RenameColumn(
                name: "TotalInterestIncome",
                table: "Records",
                newName: "loanNumber");

            migrationBuilder.RenameColumn(
                name: "OriginalLoanAmount",
                table: "Records",
                newName: "TotalInterestIncomes");

            migrationBuilder.RenameColumn(
                name: "MonthlyPrincipal",
                table: "Records",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MonthlyPayment",
                table: "Records",
                newName: "MonthlyIncome");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Records",
                newName: "MonthlyCapital");

            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "Payments",
                newName: "LoanID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Payments",
                newName: "Year");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_LoanId",
                table: "Payments",
                newName: "IX_Payments_LoanID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Loans",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "OutstandingBalance",
                table: "Loans",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "OriginalLoanAmount",
                table: "Loans",
                newName: "TotalIncome");

            migrationBuilder.RenameColumn(
                name: "MonthlyPrincipal",
                table: "Loans",
                newName: "RemainingFees");

            migrationBuilder.RenameColumn(
                name: "MonthlyPayment",
                table: "Loans",
                newName: "PayDay");

            migrationBuilder.RenameColumn(
                name: "MonthlyInterest",
                table: "Loans",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Loans",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "LoanValue",
                table: "Records",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonthDay",
                table: "Payments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Interest",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoanBalance",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Loans_LoanID",
                table: "Payments",
                column: "LoanID",
                principalTable: "Loans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
