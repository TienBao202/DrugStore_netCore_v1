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
    public class Medicine_Category_Service: IMedicine_Category_Service
    {
        private IRepository<Medicine_Category, int> _Medicine_CategoryRepository;
        private IUnitOfWork _unitOfWork;

        public Medicine_Category_Service(IRepository<Medicine_Category, int> Medicine_CategoryRepository,
            IUnitOfWork unitOfWork)
        {
            _Medicine_CategoryRepository = Medicine_CategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Medicine_CategoryViewModel Medicine_CategoryVM)
        {
            var model = Mapper.Map<Medicine_CategoryViewModel, Medicine_Category>(Medicine_CategoryVM);
            _Medicine_CategoryRepository.Add(model);
        }

        public void Delete(int id)
        {
            _Medicine_CategoryRepository.Remove(id);
        }

        public List<Medicine_CategoryViewModel> GetAll()
        {
            return _Medicine_CategoryRepository.FindAll().ProjectTo<Medicine_CategoryViewModel>().ToList();
        }

        public PagedResult<Medicine_CategoryViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _Medicine_CategoryRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Category_Code.Contains(keyword) || x.Category_Name.Contains(keyword) ||
                         x.Category_Alias.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Category_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<Medicine_CategoryViewModel>()
            {
                Results = data.ProjectTo<Medicine_CategoryViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public Medicine_CategoryViewModel GetById(int id)
        {
            return Mapper.Map<Medicine_Category, Medicine_CategoryViewModel>(_Medicine_CategoryRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Medicine_CategoryViewModel Medicine_CategoryVM)
        {
            var page = Mapper.Map<Medicine_CategoryViewModel, Medicine_Category>(Medicine_CategoryVM);
            _Medicine_CategoryRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
