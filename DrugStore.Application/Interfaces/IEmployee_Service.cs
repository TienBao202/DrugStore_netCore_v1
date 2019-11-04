using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Data.Enums;
using DrugStore.Utilities.Dtos;

namespace DrugStore.Application.Interfaces
{
    public interface IEmployee_Service
    {
        List<EmployeeViewModel> GetAll();

        PagedResult<EmployeeViewModel> GetAllPaging(string status, string keyword, int page, int pageSize);

        EmployeeViewModel GetById(int id);

        void Add(EmployeeViewModel employeeVM);

        void Update(EmployeeViewModel employeeVM);

        void Delete(int id);

        void SaveChanges();
    }
}
