using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStore.Data.EF.Migrations
{
    public partial class changeGenderbool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Customer_Type",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Customer_Type",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
