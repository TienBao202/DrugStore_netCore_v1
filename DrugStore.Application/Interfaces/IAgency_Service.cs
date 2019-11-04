using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IAgency_Service
    {
        List<AgencyViewModel> GetAll();

        PagedResult<AgencyViewModel> GetAllPaging(string keyword, int page, int pageSize);

        AgencyViewModel GetById(int id);

        void Add(AgencyViewModel agencyVM);

        void Update(AgencyViewModel agencyVM);

        void Delete(int id);

        void SaveChanges();
    }
}
