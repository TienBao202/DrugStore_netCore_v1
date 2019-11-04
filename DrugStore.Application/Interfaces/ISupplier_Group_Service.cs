using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface ISupplier_Group_Service
    {
        List<Supplier_GroupViewModel> GetAll();

        PagedResult<Supplier_GroupViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Supplier_GroupViewModel GetById(int id);

        void Add(Supplier_GroupViewModel supplier_GroupVM);

        void Update(Supplier_GroupViewModel supplier_GroupVM);

        void Delete(int id);

        void SaveChanges();
    }
}
