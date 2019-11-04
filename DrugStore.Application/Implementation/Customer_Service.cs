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
    public class Customer_Service : ICustomer_Service
    {
        private IRepository<Customer, int> _customerRepository;
        private IUnitOfWork _unitOfWork;

        public Customer_Service(IRepository<Customer, int> customerRepository,
            IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(CustomerViewModel customerVM)
        {
            var page = Mapper.Map<CustomerViewModel, Customer>(customerVM);
            _customerRepository.Add(page);
        }

        public void Delete(int id)
        {
            _customerRepository.Remove(id);
        }

        public List<CustomerViewModel> GetAll()
        {
            return _customerRepository.FindAll().ProjectTo<CustomerViewModel>().ToList();
        }

        public PagedResult<CustomerViewModel> GetAllPaging(string type, string keyword, int page, int pageSize)
        {
            var query = _customerRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Customer_Code.Contains(keyword) || x.Last_Name.Contains(keyword) ||
                         x.First_Name.Contains(keyword) || (x.First_Name + x.Last_Name).Contains(keyword));
            if (!string.IsNullOrEmpty(type))
            {
                if (type == "canhan")
                {
                    query = query.Where(x => x.Customer_Type == true);
                }
                else if (type == "congty")
                {
                    query = query.Where(x => x.Customer_Type == false);
                }
            }

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Customer_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<CustomerViewModel>()
            {
                Results = data.ProjectTo<CustomerViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public CustomerViewModel GetById(int id)
        {
            return Mapper.Map<Customer, CustomerViewModel>(_customerRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(CustomerViewModel customerVM)
        {
            var page = Mapper.Map<CustomerViewModel, Customer>(customerVM);
            _customerRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
