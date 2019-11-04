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
    public class Employee_Service: IEmployee_Service
    {
        private IRepository<Employee, int> _employeeRepository;
        private IUnitOfWork _unitOfWork;

        public Employee_Service(IRepository<Employee, int> employeeRepository,
            IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(EmployeeViewModel EmployeeVM)
        {
            var model = Mapper.Map<EmployeeViewModel, Employee>(EmployeeVM);
            _employeeRepository.Add(model);
        }

        public void Delete(int id)
        {
            _employeeRepository.Remove(id);
        }

        public List<EmployeeViewModel> GetAll()
        {
            return _employeeRepository.FindAll().ProjectTo<EmployeeViewModel>().ToList();
        }

        public PagedResult<EmployeeViewModel> GetAllPaging(string status, string keyword, int page, int pageSize)
        {
            var query = _employeeRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Employee_Code.Contains(keyword) || x.Last_Name.Contains(keyword) ||
                         x.First_Name.Contains(keyword) || (x.First_Name + x.Last_Name).Contains(keyword));
            if (!string.IsNullOrEmpty(status))
            {
                if(status == "Active")
                {
                    query = query.Where(x => x.Status == Status.Active);
                }
                else if (status == "InActive")
                {
                    query = query.Where(x => x.Status == Status.InActive);
                }
            }
               

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Employee_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<EmployeeViewModel>()
            {
                Results = data.ProjectTo<EmployeeViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public EmployeeViewModel GetById(int id)
        {
            return Mapper.Map<Employee, EmployeeViewModel>(_employeeRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(EmployeeViewModel EmployeeVM)
        {
            var page = Mapper.Map<EmployeeViewModel, Employee>(EmployeeVM);
            _employeeRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
