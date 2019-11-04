using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IMedicine_Batch_Service
    {
        List<Medicine_BatchViewModel> GetAll();

        PagedResult<Medicine_BatchViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Medicine_BatchViewModel GetById(int id);

        void Add(Medicine_BatchViewModel medicine_BatchVM);

        void Update(Medicine_BatchViewModel medicine_BatchVM);

        void Delete(int id);

        void SaveChanges();
    }
}
