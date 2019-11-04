using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Data.Entities;

namespace DrugStore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Account, AccountViewModel>();
            CreateMap<Agency, AgencyViewModel>();
            CreateMap<Country, CountryViewModel>();
            CreateMap<Customer, CustomerViewModel>().MaxDepth(2);
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<Invoice, InvoiceViewModel>();
            CreateMap<Invoice_Detail, Invoice_DetailViewModel>();
            CreateMap<Medicine, MedicineViewModel>();
            CreateMap<Medicine_Batch, Medicine_BatchViewModel>();
            CreateMap<Medicine_Category, Medicine_CategoryViewModel>();
            CreateMap<Medicine_Unit, Medicine_UnitViewModel>();
            CreateMap<Position, PositionViewModel>();
            CreateMap<Purchase_Order, Purchase_OrderViewModel>();
            CreateMap<Purchase_Order_Detail, Purchase_Order_DetailViewModel>();
            CreateMap<Supplier, SupplierViewModel>();
            CreateMap<Supplier_Group, Supplier_GroupViewModel>();

        }
    }
}
