using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;


namespace DrugStore.Application.Interfaces
{
    public interface ICustomer_Service
    {
        List<CustomerViewModel> GetAll();

        PagedResult<CustomerViewModel> GetAllPaging(string type, string keyword, int page, int pageSize);

        CustomerViewModel GetById(int id);

        void Add(CustomerViewModel customerVM);

        void Update(CustomerViewModel customerVM);

        void Delete(int id);

        void SaveChanges();
    }
}
