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
    public class Medicine_Batch_Service: IMedicine_Batch_Service
    {
        private IRepository<Medicine_Batch, int> _Medicine_BatchRepository;
        private IUnitOfWork _unitOfWork;

        public Medicine_Batch_Service(IRepository<Medicine_Batch, int> Medicine_BatchRepository,
            IUnitOfWork unitOfWork)
        {
            _Medicine_BatchRepository = Medicine_BatchRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Medicine_BatchViewModel Medicine_BatchVM)
        {
            var model = Mapper.Map<Medicine_BatchViewModel, Medicine_Batch>(Medicine_BatchVM);
            _Medicine_BatchRepository.Add(model);
        }

        public void Delete(int id)
        {
            _Medicine_BatchRepository.Remove(id);
        }

        public List<Medicine_BatchViewModel> GetAll()
        {
            return _Medicine_BatchRepository.FindAll().ProjectTo<Medicine_BatchViewModel>().ToList();
        }

        public PagedResult<Medicine_BatchViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _Medicine_BatchRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Medicine_Batch_Code.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Medicine_Batch_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<Medicine_BatchViewModel>()
            {
                Results = data.ProjectTo<Medicine_BatchViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public Medicine_BatchViewModel GetById(int id)
        {
            return Mapper.Map<Medicine_Batch, Medicine_BatchViewModel>(_Medicine_BatchRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Medicine_BatchViewModel Medicine_BatchVM)
        {
            var page = Mapper.Map<Medicine_BatchViewModel, Medicine_Batch>(Medicine_BatchVM);
            _Medicine_BatchRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
