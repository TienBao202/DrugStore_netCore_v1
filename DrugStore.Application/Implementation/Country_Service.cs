using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using DrugStore.Application.Interfaces;
using DrugStore.Application.ViewModels;
using DrugStore.Data.Entities;
using DrugStore.Infrastructure.Interfaces;
using DrugStore.Utilities.Dtos;
using DrugStore.Data.Enums;

namespace DrugStore.Application.Implementation
{
    public class Country_Service: ICountry_Service
    {
        private IRepository<Country, int> _CountryRepository;
        private IUnitOfWork _unitOfWork;

        public Country_Service(IRepository<Country, int> CountryRepository,
            IUnitOfWork unitOfWork)
        {
            _CountryRepository = CountryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(CountryViewModel CountryVM)
        {
            var model = Mapper.Map<CountryViewModel, Country>(CountryVM);
            _CountryRepository.Add(model);
        }

        public void Delete(int id)
        {
            _CountryRepository.Remove(id);
        }

        public List<CountryViewModel> GetAll()
        {
            return _CountryRepository.FindAll().ProjectTo<CountryViewModel>().ToList();
        }

        public PagedResult<CountryViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _CountryRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Country_Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Display_Order)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<CountryViewModel>()
            {
                Results = data.ProjectTo<CountryViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public CountryViewModel GetById(int id)
        {
            return Mapper.Map<Country, CountryViewModel>(_CountryRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(CountryViewModel CountryVM)
        {
            var page = Mapper.Map<CountryViewModel, Country>(CountryVM);
            _CountryRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
