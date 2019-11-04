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
    public class IvoiceDetail_Service: IInvoice_Detail_Service
    {
        private IRepository<Invoice_Detail, int> _Invoice_DetailRepository;
        private IUnitOfWork _unitOfWork;

        public IvoiceDetail_Service(IRepository<Invoice_Detail, int> Invoice_DetailRepository,
            IUnitOfWork unitOfWork)
        {
            _Invoice_DetailRepository = Invoice_DetailRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Invoice_DetailViewModel Invoice_DetailVM)
        {
            var model = Mapper.Map<Invoice_DetailViewModel, Invoice_Detail>(Invoice_DetailVM);
            _Invoice_DetailRepository.Add(model);
        }

        public void Delete(int id)
        {
            _Invoice_DetailRepository.Remove(id);
        }

        public List<Invoice_DetailViewModel> GetAll()
        {
            return _Invoice_DetailRepository.FindAll().ProjectTo<Invoice_DetailViewModel>().ToList();
        }

        public PagedResult<Invoice_DetailViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _Invoice_DetailRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Medicines.Medicine_Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.ID)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<Invoice_DetailViewModel>()
            {
                Results = data.ProjectTo<Invoice_DetailViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public Invoice_DetailViewModel GetById(int id)
        {
            return Mapper.Map<Invoice_Detail, Invoice_DetailViewModel>(_Invoice_DetailRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Invoice_DetailViewModel Invoice_DetailVM)
        {
            var page = Mapper.Map<Invoice_DetailViewModel, Invoice_Detail>(Invoice_DetailVM);
            _Invoice_DetailRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
