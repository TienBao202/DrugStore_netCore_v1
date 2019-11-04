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
    public class Agency_Service: IAgency_Service
    {
        private IRepository<Agency, int> _agencyRepository;
        private IUnitOfWork _unitOfWork;

        public Agency_Service(IRepository<Agency, int> agencyRepository,
            IUnitOfWork unitOfWork)
        {
            _agencyRepository = agencyRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AgencyViewModel AgencyVM)
        {
            var model = Mapper.Map<AgencyViewModel, Agency>(AgencyVM);
            _agencyRepository.Add(model);
        }

        public void Delete(int id)
        {
            _agencyRepository.Remove(id);
        }

        public List<AgencyViewModel> GetAll()
        {
            return _agencyRepository.FindAll().ProjectTo<AgencyViewModel>().ToList();
        }

        public PagedResult<AgencyViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _agencyRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Agency_Code.Contains(keyword) || x.Agency_Name.Contains(keyword) ||
                         x.Delegate_Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Agency_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<AgencyViewModel>()
            {
                Results = data.ProjectTo<AgencyViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public AgencyViewModel GetById(int id)
        {
            return Mapper.Map<Agency, AgencyViewModel>(_agencyRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(AgencyViewModel AgencyVM)
        {
            var page = Mapper.Map<AgencyViewModel, Agency>(AgencyVM);
            _agencyRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
