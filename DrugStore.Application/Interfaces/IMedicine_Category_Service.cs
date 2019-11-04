using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IMedicine_Category_Service
    {
        List<Medicine_CategoryViewModel> GetAll();

        PagedResult<Medicine_CategoryViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Medicine_CategoryViewModel GetById(int id);

        void Add(Medicine_CategoryViewModel medicine_CategoryVM);

        void Update(Medicine_CategoryViewModel medicine_CategoryVM);

        void Delete(int id);

        void SaveChanges();
    }
}
