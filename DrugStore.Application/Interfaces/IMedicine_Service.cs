using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IMedicine_Service
    {
        List<MedicineViewModel> GetAll();

        PagedResult<MedicineViewModel> GetAllPaging(string keyword, int page, int pageSize);

        MedicineViewModel GetById(int id);

        void Add(MedicineViewModel medicineVM);

        void Update(MedicineViewModel medicineVM);

        void Delete(int id);

        void SaveChanges();
    }
}
