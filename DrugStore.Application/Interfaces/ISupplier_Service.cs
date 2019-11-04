using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;
using DrugStore.Data.Enums;

namespace DrugStore.Application.Interfaces
{
    public interface ISupplier_Service
    {
        List<SupplierViewModel> GetAll();

        PagedResult<SupplierViewModel> GetAllPaging(int? supplier_GroupId, Status? status, string keyword, int page, int pageSize);

        SupplierViewModel GetById(int id);

        void Add(SupplierViewModel supplierVM);

        void Update(SupplierViewModel supplierVM);

        void Delete(int id);

        void SaveChanges();
    }
}
