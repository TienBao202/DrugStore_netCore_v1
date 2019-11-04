using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Data.Entities;

namespace DrugStore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AccountViewModel, Account>()
                .ConstructUsing(c => new Account(c.ID, c.FullName, c.UserName, c.Password,
                c.Phone_Number, c.Email, c.Address, c.IsAdmin, c.Status, c.User_Created, c.User_Modified,
                c.ID_Employee));

            CreateMap<AgencyViewModel, Agency>()
                .ConstructUsing(c => new Agency(c.ID, c.Agency_Code, c.Agency_Name, c.Phone_Number, c.Email, 
                c.Delegate_Name, c.Display_Order, c.Status));

            CreateMap<CountryViewModel, Country>()
                .ConstructUsing(c => new Country(c.ID, c.Country_Name, c.Display_Order, c.Status));

            CreateMap<CustomerViewModel, Customer>()
                .ConstructUsing(c => new Customer(c.ID, c.Customer_Code, c.First_Name, c.Last_Name, c.Birth_Day,
                c.Gender, c.Phone_Number, c.Address, c.Email, c.Tax_Code, c.Customer_Type, c.Status, c.User_Created, c.User_Modified));

            CreateMap<EmployeeViewModel, Employee>()
                .ConstructUsing(c => new Employee(c.ID, c.Employee_Code, c.First_Name, c.Last_Name, c.Birth_Day, c.Gender,
                c.Address, c.Phone_Number, c.Email, c.Identity_Number, c.Identity_Date, c.Identity_Address, c.Salary_Min, c.Status, 
                c.User_Created, c.User_Modified, c.ID_Position, c.ID_Agency));

            CreateMap<InvoiceViewModel, Invoice>()
                .ConstructUsing(c => new Invoice(c.ID, c.Invoice_Code, c.Total_Price, c.Discount, c.Customer_Pays, c.Return_Customer,
                c.Status, c.User_Created, c.User_Modified, c.ID_Customer, c.ID_Agency));

            CreateMap<Invoice_DetailViewModel, Invoice_Detail>()
                .ConstructUsing(c => new Invoice_Detail(c.ID, c.ID_Invoice, c.ID_Medicine, c.Quantity, c.Price, c.Status));

            CreateMap<MedicineViewModel, Medicine>()
                .ConstructUsing(c => new Medicine(c.ID, c.Medicine_Code, c.Medicine_Name, c.Medicine_Alias, c.Medicine_Image,
                c.Price, c.Original_Price, c.Quantity, c.Element, c.Effect, c.Indications, c.Contraindications, c.Caution, 
                c.Dosage_And_Administration, c.Warranty, c.Packing, c.Inventory_Min, c.Inventory_Max, c.ID_Medicine_Category, c.ID_Medicine_Unit,
                c.Status, c.User_Created, c.User_Modified));

            CreateMap<Medicine_BatchViewModel, Medicine_Batch>()
                .ConstructUsing(c => new Medicine_Batch(c.ID, c.Medicine_Batch_Code, c.Quantity, c.Start_Date, 
                c.End_Date, c.Status, c.User_Created, c.User_Modified, c.ID_Medicine, c.ID_Country));

            CreateMap<Medicine_CategoryViewModel, Medicine_Category>()
                .ConstructUsing(c => new Medicine_Category(c.ID, c.Category_Code, c.Category_Name, c.Category_Alias,
                c.Category_Parent_ID, c.Display_Order, c.Status, c.User_Created, c.User_Modified));

            CreateMap<Medicine_UnitViewModel, Medicine_Unit>()
                .ConstructUsing(c => new Medicine_Unit(c.ID, c.Medicine_Unit_Name, c.Display_Order, c.Status, 
                c.User_Created, c.User_Modified));

            CreateMap<PositionViewModel, Position>()
                .ConstructUsing(c => new Position(c.ID, c.Position_Code, c.Position_Name, c.Position_Alias, c.Display_Order,
                c.Status));

            CreateMap<Purchase_OrderViewModel, Purchase_Order>()
                .ConstructUsing(c => new Purchase_Order(c.ID, c.Purchase_Order_Code, c.Total_Price, c.Discount, c.Amount_Payment,
                c.Amount_Owed, c.User_Created, c.User_Modified, c.ID_Supplier, c.ID_Agency));

            CreateMap<Purchase_Order_DetailViewModel, Purchase_Order_Detail>()
                .ConstructUsing(c => new Purchase_Order_Detail(c.ID, c.ID_Purchase_Order, 
                c.ID_Medicine_Batch, c.Quantity, c.Price, c.Status));

            CreateMap<SupplierViewModel, Supplier>()
                .ConstructUsing(c => new Supplier(c.ID, c.Supplier_Code, c.Supplier_Name, c.Phone_Number, 
                c.Address, c.Email, c.Tax_Code, c.Status, c.User_Created, c.User_Modified, c.ID_Supplier_Group));

            CreateMap<Supplier_GroupViewModel, Supplier_Group>()
                .ConstructUsing(c => new Supplier_Group(c.ID, c.Supplier_Group_Code, c.Supplier_Group_Name,
                c.Display_Order, c.Description, c.Status));
        }
    }
}
