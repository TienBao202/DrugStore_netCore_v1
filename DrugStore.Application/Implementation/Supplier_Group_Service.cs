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
    public class Supplier_Group_Service: ISupplier_Group_Service
    {
        private IRepository<Supplier_Group, int> _supplier_GroupRepository;
        private IUnitOfWork _unitOfWork;

        public Supplier_Group_Service(IRepository<Supplier_Group, int> supplier_GroupRepository,
            IUnitOfWork unitOfWork)
        {
            _supplier_GroupRepository = supplier_GroupRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Supplier_GroupViewModel Supplier_GroupVM)
        {
            var model = Mapper.Map<Supplier_GroupViewModel, Supplier_Group>(Supplier_GroupVM);
            _supplier_GroupRepository.Add(model);
        }

        public void Delete(int id)
        {
            _supplier_GroupRepository.Remove(id);
        }

        public List<Supplier_GroupViewModel> GetAll()
        {
            return _supplier_GroupRepository.FindAll().ProjectTo<Supplier_GroupViewModel>().ToList();
        }

        public PagedResult<Supplier_GroupViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _supplier_GroupRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Supplier_Group_Code.Contains(keyword) || x.Supplier_Group_Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Supplier_Group_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<Supplier_GroupViewModel>()
            {
                Results = data.ProjectTo<Supplier_GroupViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public Supplier_GroupViewModel GetById(int id)
        {
            return Mapper.Map<Supplier_Group, Supplier_GroupViewModel>(_supplier_GroupRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Supplier_GroupViewModel Supplier_GroupVM)
        {
            var page = Mapper.Map<Supplier_GroupViewModel, Supplier_Group>(Supplier_GroupVM);
            _supplier_GroupRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
