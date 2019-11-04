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
    public class Medicine_CategoryController : Controller
    {
        IMedicine_Category_Service _medicineCategoryService;

        public Medicine_CategoryController(IMedicine_Category_Service medicineCategoryService)
        {
            this._medicineCategoryService = medicineCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _medicineCategoryService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _medicineCategoryService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _medicineCategoryService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Medicine_CategoryViewModel medicineCategoryVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineCategoryService.Add(medicineCategoryVm);
            _medicineCategoryService.SaveChanges();
            return new OkObjectResult(medicineCategoryVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Medicine_CategoryViewModel medicineCategoryVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineCategoryService.Update(medicineCategoryVm);
            _medicineCategoryService.SaveChanges();
            return new OkObjectResult(medicineCategoryVm);
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
                _medicineCategoryService.Delete(id);
                _medicineCategoryService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}