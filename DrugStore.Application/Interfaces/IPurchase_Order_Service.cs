using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IPurchase_Order_Service
    {
        List<Purchase_OrderViewModel> GetAll();

        PagedResult<Purchase_OrderViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Purchase_OrderViewModel GetById(int id);

        void Add(Purchase_OrderViewModel purchase_OrderVM);

        void Update(Purchase_OrderViewModel purchase_OrderVM);

        void Delete(int id);

        void SaveChanges();
    }
}
