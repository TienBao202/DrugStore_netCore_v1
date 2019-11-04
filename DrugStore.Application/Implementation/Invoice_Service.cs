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
    public class Invoice_Service: IInvoice_Service
    {
        private IRepository<Invoice, int> _InvoiceRepository;
        private IUnitOfWork _unitOfWork;

        public Invoice_Service(IRepository<Invoice, int> InvoiceRepository,
            IUnitOfWork unitOfWork)
        {
            _InvoiceRepository = InvoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(InvoiceViewModel InvoiceVM)
        {
            var model = Mapper.Map<InvoiceViewModel, Invoice>(InvoiceVM);
            _InvoiceRepository.Add(model);
        }

        public void Delete(int id)
        {
            _InvoiceRepository.Remove(id);
        }

        public List<InvoiceViewModel> GetAll()
        {
            return _InvoiceRepository.FindAll().ProjectTo<InvoiceViewModel>().ToList();
        }

        public PagedResult<InvoiceViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _InvoiceRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Invoice_Code.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Invoice_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<InvoiceViewModel>()
            {
                Results = data.ProjectTo<InvoiceViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public InvoiceViewModel GetById(int id)
        {
            return Mapper.Map<Invoice, InvoiceViewModel>(_InvoiceRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(InvoiceViewModel InvoiceVM)
        {
            var page = Mapper.Map<InvoiceViewModel, Invoice>(InvoiceVM);
            _InvoiceRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
