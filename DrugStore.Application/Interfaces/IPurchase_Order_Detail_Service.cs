using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IPurchase_Order_Detail_Service
    {
        List<Purchase_Order_DetailViewModel> GetAll();

        PagedResult<Purchase_Order_DetailViewModel> GetAllPaging(string keyword, int page, int pageSize);

        Purchase_Order_DetailViewModel GetById(int id);

        void Add(Purchase_Order_DetailViewModel purchase_Order_DetailVM);

        void Update(Purchase_Order_DetailViewModel purchase_Order_DetailVM);

        void Delete(int id);

        void SaveChanges();
    }
}
