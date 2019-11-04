using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IInvoice_Detail_Service
    {
        List<Invoice_DetailViewModel> GetAll();

        PagedResult<Invoice_DetailViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Invoice_DetailViewModel GetById(int id);

        void Add(Invoice_DetailViewModel invoice_DetailVM);

        void Update(Invoice_DetailViewModel invoice_DetailVM);

        void Delete(int id);

        void SaveChanges();
    }
}
