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
    public class SupplierController : Controller
    {
        ISupplier_Service _supplierService;

        public SupplierController(ISupplier_Service supplier_Service)
        {
            this._supplierService = supplier_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _supplierService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(int? supplier_GroupId, Status? status, string keyword, int page, int pageSize)
        {
            var model = _supplierService.GetAllPaging(supplier_GroupId, status, keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _supplierService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateSupplier([FromBody]SupplierViewModel SupplierVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _supplierService.Add(SupplierVm);
            _supplierService.SaveChanges();
            return new OkObjectResult(SupplierVm);
        }

        [HttpPut]
        public IActionResult UpdateSupplier([FromBody]SupplierViewModel SupplierVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _supplierService.Update(SupplierVm);
            _supplierService.SaveChanges();
            return new OkObjectResult(SupplierVm);
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
                _supplierService.Delete(id);
                _supplierService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}