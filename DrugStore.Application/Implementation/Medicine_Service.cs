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
    public class Medicine_Service: IMedicine_Service
    {
        private IRepository<Medicine, int> _MedicineRepository;
        private IUnitOfWork _unitOfWork;

        public Medicine_Service(IRepository<Medicine, int> MedicineRepository,
            IUnitOfWork unitOfWork)
        {
            _MedicineRepository = MedicineRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(MedicineViewModel MedicineVM)
        {
            var model = Mapper.Map<MedicineViewModel, Medicine>(MedicineVM);
            _MedicineRepository.Add(model);
        }

        public void Delete(int id)
        {
            _MedicineRepository.Remove(id);
        }

        public List<MedicineViewModel> GetAll()
        {
            return _MedicineRepository.FindAll().ProjectTo<MedicineViewModel>().ToList();
        }

        public PagedResult<MedicineViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _MedicineRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Medicine_Code.Contains(keyword) || x.Medicine_Name.Contains(keyword) ||
                         x.Medicine_Alias.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Medicine_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<MedicineViewModel>()
            {
                Results = data.ProjectTo<MedicineViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public MedicineViewModel GetById(int id)
        {
            return Mapper.Map<Medicine, MedicineViewModel>(_MedicineRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(MedicineViewModel MedicineVM)
        {
            var page = Mapper.Map<MedicineViewModel, Medicine>(MedicineVM);
            _MedicineRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
