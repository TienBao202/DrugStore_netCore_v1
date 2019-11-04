using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IInvoice_Service
    {
        List<InvoiceViewModel> GetAll();

        PagedResult<InvoiceViewModel> GetAllPaging(string keyword, int page, int pageSize);

        InvoiceViewModel GetById(int id);

        void Add(InvoiceViewModel invoiceVM);

        void Update(InvoiceViewModel invoiceVM);

        void Delete(int id);

        void SaveChanges();
    }
}
