using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IAccount_Service
    {
        List<AccountViewModel> GetAll();

        PagedResult<AccountViewModel> GetAllPaging(string status, string keyword, int page, int pageSize);

        AccountViewModel GetById(int id);

        void Add(AccountViewModel accountVM);

        void Update(AccountViewModel accountVM);

        void Delete(int id);

        void SaveChanges();
    }
}
