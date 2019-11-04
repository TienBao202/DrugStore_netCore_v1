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
    public class Supplier_GroupController : Controller
    {
        ISupplier_Group_Service _supplierGroupService;

        public Supplier_GroupController(ISupplier_Group_Service supplierGroupService)
        {
            this._supplierGroupService = supplierGroupService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _supplierGroupService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _supplierGroupService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _supplierGroupService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Supplier_GroupViewModel supplierGroupVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _supplierGroupService.Add(supplierGroupVm);
            _supplierGroupService.SaveChanges();
            return new OkObjectResult(supplierGroupVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Supplier_GroupViewModel supplierGroupVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _supplierGroupService.Update(supplierGroupVm);
            _supplierGroupService.SaveChanges();
            return new OkObjectResult(supplierGroupVm);
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
                _supplierGroupService.Delete(id);
                _supplierGroupService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}