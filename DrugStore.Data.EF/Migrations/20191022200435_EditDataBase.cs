using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrugStore.Data.EF.Migrations
{
    public partial class EditDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agency_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Agency_Name = table.Column<string>(maxLength: 256, nullable: false),
                    Phone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Delegate_Name = table.Column<string>(nullable: true),
                    Display_Order = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country_Name = table.Column<string>(maxLength: 256, nullable: false),
                    Display_Order = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Customer_Code = table.Column<string>(maxLength: 50, nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Birth_Day = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Phone_Number = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Tax_Code = table.Column<string>(nullable: true),
                    Customer_Type = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Errors",
                columns: table => new
                {
                    Error_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errors", x => x.Error_ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicine_Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Category_Name = table.Column<string>(maxLength: 256, nullable: false),
                    Category_Alias = table.Column<string>(nullable: true),
                    Category_Parent_ID = table.Column<int>(nullable: true),
                    Display_Order = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicine_Units",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Medicine_Unit_Name = table.Column<string>(nullable: false),
                    Display_Order = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Position_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Position_Name = table.Column<string>(nullable: false),
                    Position_Alias = table.Column<string>(nullable: true),
                    Display_Order = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier_Groups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Supplier_Group_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Supplier_Group_Name = table.Column<string>(nullable: true),
                    Display_Order = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Invoice_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Total_Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<float>(nullable: true),
                    Customer_Pays = table.Column<decimal>(nullable: false),
                    Return_Customer = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Customer = table.Column<int>(nullable: false),
                    ID_Agency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invoices_Agencies_ID_Agency",
                        column: x => x.ID_Agency,
                        principalTable: "Agencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_ID_Customer",
                        column: x => x.ID_Customer,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Medicine_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Medicine_Name = table.Column<string>(maxLength: 256, nullable: false),
                    Medicine_Alias = table.Column<string>(nullable: true),
                    Medicine_Image = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Original_Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Element = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Indications = table.Column<string>(nullable: true),
                    Contraindications = table.Column<string>(nullable: true),
                    Caution = table.Column<string>(nullable: true),
                    Dosage_And_Administration = table.Column<string>(nullable: true),
                    Warranty = table.Column<int>(nullable: true),
                    Packing = table.Column<string>(nullable: true),
                    Inventory_Min = table.Column<int>(nullable: true),
                    Inventory_Max = table.Column<int>(nullable: true),
                    ID_Medicine_Category = table.Column<int>(nullable: false),
                    ID_Medicine_Unit = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Medicines_Medicine_Categories_ID_Medicine_Category",
                        column: x => x.ID_Medicine_Category,
                        principalTable: "Medicine_Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicines_Medicine_Units_ID_Medicine_Unit",
                        column: x => x.ID_Medicine_Unit,
                        principalTable: "Medicine_Units",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Employee_Code = table.Column<string>(maxLength: 50, nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Birth_Day = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Identity_Number = table.Column<string>(nullable: true),
                    Identity_Date = table.Column<string>(nullable: true),
                    Identity_Address = table.Column<string>(nullable: true),
                    Salary_Min = table.Column<decimal>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Position = table.Column<int>(nullable: false),
                    ID_Agency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Agencies_ID_Agency",
                        column: x => x.ID_Agency,
                        principalTable: "Agencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_ID_Position",
                        column: x => x.ID_Position,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Supplier_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Supplier_Name = table.Column<string>(nullable: false),
                    Phone_Number = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Tax_Code = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Supplier_Group = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Supplier_Groups_ID_Supplier_Group",
                        column: x => x.ID_Supplier_Group,
                        principalTable: "Supplier_Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Invoice = table.Column<int>(nullable: false),
                    ID_Medicine = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invoice_Details_Invoices_ID_Invoice",
                        column: x => x.ID_Invoice,
                        principalTable: "Invoices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Details_Medicines_ID_Medicine",
                        column: x => x.ID_Medicine,
                        principalTable: "Medicines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicine_Batches",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Medicine_Batch_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Start_Date = table.Column<DateTime>(nullable: false),
                    End_Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Medicine = table.Column<int>(nullable: false),
                    ID_Country = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine_Batches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Medicine_Batches_Countrys_ID_Country",
                        column: x => x.ID_Country,
                        principalTable: "Countrys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicine_Batches_Medicines_ID_Medicine",
                        column: x => x.ID_Medicine,
                        principalTable: "Medicines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 256, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Employee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Accounts_Employees_ID_Employee",
                        column: x => x.ID_Employee,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Purchase_Order_Code = table.Column<string>(maxLength: 50, nullable: false),
                    Total_Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<float>(nullable: true),
                    Amount_Payment = table.Column<decimal>(nullable: false),
                    Amount_Owed = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modified = table.Column<DateTime>(nullable: false),
                    User_Created = table.Column<string>(nullable: true),
                    User_Modified = table.Column<string>(nullable: true),
                    ID_Supplier = table.Column<int>(nullable: false),
                    ID_Agency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Purchase_Orders_Agencies_ID_Agency",
                        column: x => x.ID_Agency,
                        principalTable: "Agencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Orders_Suppliers_ID_Supplier",
                        column: x => x.ID_Supplier,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Order_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Purchase_Order = table.Column<int>(nullable: false),
                    ID_Medicine_Batch = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Order_Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Purchase_Order_Details_Medicine_Batches_ID_Medicine_Batch",
                        column: x => x.ID_Medicine_Batch,
                        principalTable: "Medicine_Batches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Order_Details_Purchase_Orders_ID_Purchase_Order",
                        column: x => x.ID_Purchase_Order,
                        principalTable: "Purchase_Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ID_Employee",
                table: "Accounts",
                column: "ID_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ID_Agency",
                table: "Employees",
                column: "ID_Agency");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ID_Position",
                table: "Employees",
                column: "ID_Position");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Details_ID_Invoice",
                table: "Invoice_Details",
                column: "ID_Invoice");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Details_ID_Medicine",
                table: "Invoice_Details",
                column: "ID_Medicine");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ID_Agency",
                table: "Invoices",
                column: "ID_Agency");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ID_Customer",
                table: "Invoices",
                column: "ID_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Batches_ID_Country",
                table: "Medicine_Batches",
                column: "ID_Country");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_Batches_ID_Medicine",
                table: "Medicine_Batches",
                column: "ID_Medicine");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ID_Medicine_Category",
                table: "Medicines",
                column: "ID_Medicine_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ID_Medicine_Unit",
                table: "Medicines",
                column: "ID_Medicine_Unit");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Order_Details_ID_Medicine_Batch",
                table: "Purchase_Order_Details",
                column: "ID_Medicine_Batch");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Order_Details_ID_Purchase_Order",
                table: "Purchase_Order_Details",
                column: "ID_Purchase_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Orders_ID_Agency",
                table: "Purchase_Orders",
                column: "ID_Agency");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Orders_ID_Supplier",
                table: "Purchase_Orders",
                column: "ID_Supplier");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ID_Supplier_Group",
                table: "Suppliers",
                column: "ID_Supplier_Group");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Errors");

            migrationBuilder.DropTable(
                name: "Invoice_Details");

            migrationBuilder.DropTable(
                name: "Purchase_Order_Details");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Medicine_Batches");

            migrationBuilder.DropTable(
                name: "Purchase_Orders");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Medicine_Categories");

            migrationBuilder.DropTable(
                name: "Medicine_Units");

            migrationBuilder.DropTable(
                name: "Supplier_Groups");
        }
    }
}
