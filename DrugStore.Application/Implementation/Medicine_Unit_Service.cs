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
    public class Medicine_Unit_Service: IMedicine_Unit_Service
    {
        private IRepository<Medicine_Unit, int> _Medicine_UnitRepository;
        private IUnitOfWork _unitOfWork;

        public Medicine_Unit_Service(IRepository<Medicine_Unit, int> Medicine_UnitRepository,
            IUnitOfWork unitOfWork)
        {
            _Medicine_UnitRepository = Medicine_UnitRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Medicine_UnitViewModel Medicine_UnitVM)
        {
            var model = Mapper.Map<Medicine_UnitViewModel, Medicine_Unit>(Medicine_UnitVM);
            _Medicine_UnitRepository.Add(model);
        }

        public void Delete(int id)
        {
            _Medicine_UnitRepository.Remove(id);
        }

        public List<Medicine_UnitViewModel> GetAll()
        {
            return _Medicine_UnitRepository.FindAll().ProjectTo<Medicine_UnitViewModel>().ToList();
        }

        public PagedResult<Medicine_UnitViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _Medicine_UnitRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Medicine_Unit_Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Display_Order)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<Medicine_UnitViewModel>()
            {
                Results = data.ProjectTo<Medicine_UnitViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public Medicine_UnitViewModel GetById(int id)
        {
            return Mapper.Map<Medicine_Unit, Medicine_UnitViewModel>(_Medicine_UnitRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Medicine_UnitViewModel Medicine_UnitVM)
        {
            var page = Mapper.Map<Medicine_UnitViewModel, Medicine_Unit>(Medicine_UnitVM);
            _Medicine_UnitRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
