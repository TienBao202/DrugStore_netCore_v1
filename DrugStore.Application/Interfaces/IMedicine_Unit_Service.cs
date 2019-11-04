using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IMedicine_Unit_Service
    {
        List<Medicine_UnitViewModel> GetAll();

        PagedResult<Medicine_UnitViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Medicine_UnitViewModel GetById(int id);

        void Add(Medicine_UnitViewModel medicine_UnitVM);

        void Update(Medicine_UnitViewModel medicine_UnitVM);

        void Delete(int id);

        void SaveChanges();
    }
}
