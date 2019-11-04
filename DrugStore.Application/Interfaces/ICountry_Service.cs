using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface ICountry_Service
    {
        List<CountryViewModel> GetAll();

        PagedResult<CountryViewModel> GetAllPaging(string keyword, int page, int pageSize);

        CountryViewModel GetById(int id);

        void Add(CountryViewModel countryVM);

        void Update(CountryViewModel countryVM);

        void Delete(int id);

        void SaveChanges();
    }
}
