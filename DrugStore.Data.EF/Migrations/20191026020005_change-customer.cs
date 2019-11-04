using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStore.Data.EF.Migrations
{
    public partial class changecustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
