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
    public class Supplier_Service: ISupplier_Service
    {
        private IRepository<Supplier, int> _supplierRepository;
        private IUnitOfWork _unitOfWork;

        public Supplier_Service(IRepository<Supplier, int> supplierRepository,
            IUnitOfWork unitOfWork)
        {
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(SupplierViewModel SupplierVM)
        {
            var model = Mapper.Map<SupplierViewModel, Supplier>(SupplierVM);
            _supplierRepository.Add(model);
        }

        public void Delete(int id)
        {
            _supplierRepository.Remove(id);
        }

        public List<SupplierViewModel> GetAll()
        {
            return _supplierRepository.FindAll().ProjectTo<SupplierViewModel>().ToList();
        }

        public PagedResult<SupplierViewModel> GetAllPaging(int? supplier_GroupId, Status? status, string keyword, int page, int pageSize)
        {
            var query = _supplierRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Supplier_Code.Contains(keyword) || x.Supplier_Name.Contains(keyword) ||
                         x.Email.Contains(keyword));
            if (supplier_GroupId.HasValue)
                query = query.Where(x => x.ID_Supplier_Group == supplier_GroupId.Value);
            if (status.HasValue)
                query = query.Where(x => x.Status == status.Value);

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Supplier_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<SupplierViewModel>()
            {
                Results = data.ProjectTo<SupplierViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public SupplierViewModel GetById(int id)
        {
            return Mapper.Map<Supplier, SupplierViewModel>(_supplierRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(SupplierViewModel SupplierVM)
        {
            var page = Mapper.Map<SupplierViewModel, Supplier>(SupplierVM);
            _supplierRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
