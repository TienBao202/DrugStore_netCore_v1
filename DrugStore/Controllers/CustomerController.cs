using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrugStore.Application.Interfaces;
using DrugStore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DrugStore.Controllers
{
    public class CustomerController : Controller
    {
        ICustomer_Service _customerService;

        public CustomerController(ICustomer_Service customer_Service)
        {
            this._customerService = customer_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _customerService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string type, string keyword, int page, int pageSize)
        {
            var model = _customerService.GetAllPaging(type, keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _customerService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody]CustomerViewModel customerVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _customerService.Add(customerVm);
            _customerService.SaveChanges();
            return new OkObjectResult(customerVm);
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody]CustomerViewModel customerVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _customerService.Update(customerVm);
            _customerService.SaveChanges();
            return new OkObjectResult(customerVm);
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
                _customerService.Delete(id);
                _customerService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}