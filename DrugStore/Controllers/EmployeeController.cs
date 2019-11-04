using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrugStore.Application.Interfaces;
using DrugStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DrugStore.Data.Enums;

namespace DrugStore.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployee_Service _employeeService;

        public EmployeeController(IEmployee_Service employee_Service)
        {
            this._employeeService = employee_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _employeeService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string status, string keyword, int page, int pageSize)
        {
            var model = _employeeService.GetAllPaging(status, keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _employeeService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody]EmployeeViewModel EmployeeVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _employeeService.Add(EmployeeVm);
            _employeeService.SaveChanges();
            return new OkObjectResult(EmployeeVm);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody]EmployeeViewModel EmployeeVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _employeeService.Update(EmployeeVm);
            _employeeService.SaveChanges();
            return new OkObjectResult(EmployeeVm);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                _employeeService.Delete(id);
                _employeeService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}