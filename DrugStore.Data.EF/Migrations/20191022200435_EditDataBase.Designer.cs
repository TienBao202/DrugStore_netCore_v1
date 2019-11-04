﻿// <auto-generated />
using System;
using DrugStore.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrugStore.Data.EF.Migrations
{
    [DbContext(typeof(DrugStoreDbContext))]
    [Migration("20191022200435_EditDataBase")]
    partial class EditDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrugStore.Data.Entities.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<string>("Email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("ID_Employee");

                    b.Property<bool?>("IsAdmin");

                    b.Property<string>("Password");

                    b.Property<string>("Phone_Number");

                    b.Property<int>("Status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Employee");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Agency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agency_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Agency_Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Delegate_Name");

                    b.Property<int?>("Display_Order");

                    b.Property<string>("Email");

                    b.Property<string>("Phone_Number");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country_Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("Display_Order");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Birth_Day");

                    b.Property<string>("Customer_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Customer_Type");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<string>("Email");

                    b.Property<string>("First_Name");

                    b.Property<int>("Gender");

                    b.Property<string>("Last_Name");

                    b.Property<string>("Phone_Number");

                    b.Property<int>("Status");

                    b.Property<string>("Tax_Code");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Birth_Day");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<string>("Email");

                    b.Property<string>("Employee_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("First_Name");

                    b.Property<int>("Gender");

                    b.Property<int>("ID_Agency");

                    b.Property<int>("ID_Position");

                    b.Property<string>("Identity_Address");

                    b.Property<string>("Identity_Date");

                    b.Property<string>("Identity_Number");

                    b.Property<string>("Last_Name");

                    b.Property<string>("Phone_Number");

                    b.Property<decimal?>("Salary_Min");

                    b.Property<int>("Status");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Agency");

                    b.HasIndex("ID_Position");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Error", b =>
                {
                    b.Property<int>("Error_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.HasKey("Error_ID");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Customer_Pays");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<float?>("Discount");

                    b.Property<int>("ID_Agency");

                    b.Property<int>("ID_Customer");

                    b.Property<string>("Invoice_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Return_Customer");

                    b.Property<int>("Status");

                    b.Property<decimal>("Total_Price");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Agency");

                    b.HasIndex("ID_Customer");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Invoice_Detail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID_Invoice");

                    b.Property<int>("ID_Medicine");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.HasIndex("ID_Invoice");

                    b.HasIndex("ID_Medicine");

                    b.ToTable("Invoice_Details");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caution");

                    b.Property<string>("Contraindications");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<string>("Dosage_And_Administration");

                    b.Property<string>("Effect");

                    b.Property<string>("Element");

                    b.Property<int>("ID_Medicine_Category");

                    b.Property<int>("ID_Medicine_Unit");

                    b.Property<string>("Indications");

                    b.Property<int?>("Inventory_Max");

                    b.Property<int?>("Inventory_Min");

                    b.Property<string>("Medicine_Alias");

                    b.Property<string>("Medicine_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Medicine_Image");

                    b.Property<string>("Medicine_Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<decimal>("Original_Price");

                    b.Property<string>("Packing");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("Status");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.Property<int?>("Warranty");

                    b.HasKey("ID");

                    b.HasIndex("ID_Medicine_Category");

                    b.HasIndex("ID_Medicine_Unit");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine_Batch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<DateTime>("End_Date");

                    b.Property<int>("ID_Country");

                    b.Property<int>("ID_Medicine");

                    b.Property<string>("Medicine_Batch_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("Start_Date");

                    b.Property<int>("Status");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Country");

                    b.HasIndex("ID_Medicine");

                    b.ToTable("Medicine_Batches");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine_Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Alias");

                    b.Property<string>("Category_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int?>("Category_Parent_ID");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<int?>("Display_Order");

                    b.Property<int>("Status");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.ToTable("Medicine_Categories");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine_Unit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<int?>("Display_Order");

                    b.Property<string>("Medicine_Unit_Name")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.ToTable("Medicine_Units");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Display_Order");

                    b.Property<string>("Position_Alias");

                    b.Property<string>("Position_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Position_Name")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Purchase_Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount_Owed");

                    b.Property<decimal>("Amount_Payment");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<float?>("Discount");

                    b.Property<int>("ID_Agency");

                    b.Property<int>("ID_Supplier");

                    b.Property<string>("Purchase_Order_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.Property<decimal>("Total_Price");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Agency");

                    b.HasIndex("ID_Supplier");

                    b.ToTable("Purchase_Orders");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Purchase_Order_Detail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID_Medicine_Batch");

                    b.Property<int>("ID_Purchase_Order");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.HasIndex("ID_Medicine_Batch");

                    b.HasIndex("ID_Purchase_Order");

                    b.ToTable("Purchase_Order_Details");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Date_Created");

                    b.Property<DateTime>("Date_Modified");

                    b.Property<string>("Email");

                    b.Property<int>("ID_Supplier_Group");

                    b.Property<string>("Phone_Number");

                    b.Property<int>("Status");

                    b.Property<string>("Supplier_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Supplier_Name")
                        .IsRequired();

                    b.Property<string>("Tax_Code");

                    b.Property<string>("User_Created");

                    b.Property<string>("User_Modified");

                    b.HasKey("ID");

                    b.HasIndex("ID_Supplier_Group");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Supplier_Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("Display_Order");

                    b.Property<int>("Status");

                    b.Property<string>("Supplier_Group_Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Supplier_Group_Name");

                    b.HasKey("ID");

                    b.ToTable("Supplier_Groups");
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Account", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Employee", "Employees")
                        .WithMany("Accounts")
                        .HasForeignKey("ID_Employee")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Employee", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Agency", "Agency")
                        .WithMany("Employees")
                        .HasForeignKey("ID_Agency")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Position", "Positions")
                        .WithMany("Employees")
                        .HasForeignKey("ID_Position")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Invoice", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Agency", "Agency")
                        .WithMany("Invoices")
                        .HasForeignKey("ID_Agency")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Customer", "Customers")
                        .WithMany("Invoices")
                        .HasForeignKey("ID_Customer")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Invoice_Detail", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Invoice", "Invoices")
                        .WithMany("Invoice_Details")
                        .HasForeignKey("ID_Invoice")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Medicine", "Medicines")
                        .WithMany("Invoice_Details")
                        .HasForeignKey("ID_Medicine")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Medicine_Category", "Medicine_Categories")
                        .WithMany("Medicines")
                        .HasForeignKey("ID_Medicine_Category")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Medicine_Unit", "Medicine_Units")
                        .WithMany("Medicines")
                        .HasForeignKey("ID_Medicine_Unit")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Medicine_Batch", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Country", "Countrys")
                        .WithMany("Medicine_Batches")
                        .HasForeignKey("ID_Country")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Medicine", "Medicines")
                        .WithMany("Medicine_Batches")
                        .HasForeignKey("ID_Medicine")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Purchase_Order", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Agency", "Agency")
                        .WithMany("Purchase_Orders")
                        .HasForeignKey("ID_Agency")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Supplier", "Suppliers")
                        .WithMany("Purchase_Orders")
                        .HasForeignKey("ID_Supplier")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Purchase_Order_Detail", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Medicine_Batch", "Medicine_Batch")
                        .WithMany("Purchase_Order_Details")
                        .HasForeignKey("ID_Medicine_Batch")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugStore.Data.Entities.Purchase_Order", "Purchase_Orders")
                        .WithMany("Purchase_Order_Details")
                        .HasForeignKey("ID_Purchase_Order")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugStore.Data.Entities.Supplier", b =>
                {
                    b.HasOne("DrugStore.Data.Entities.Supplier_Group", "Supplier_Groups")
                        .WithMany("Suppliers")
                        .HasForeignKey("ID_Supplier_Group")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
