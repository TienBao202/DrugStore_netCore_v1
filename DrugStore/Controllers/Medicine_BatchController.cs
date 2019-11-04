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
    public class Medicine_BatchController : Controller
    {
        IMedicine_Batch_Service _medicine_BatchService;

        public Medicine_BatchController(IMedicine_Batch_Service medicine_Batch_Service)
        {
            this._medicine_BatchService = medicine_Batch_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _medicine_BatchService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _medicine_BatchService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _medicine_BatchService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Medicine_BatchViewModel medicineBatchVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicine_BatchService.Add(medicineBatchVm);
            _medicine_BatchService.SaveChanges();
            return new OkObjectResult(medicineBatchVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Medicine_BatchViewModel medicineBatchVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicine_BatchService.Update(medicineBatchVm);
            _medicine_BatchService.SaveChanges();
            return new OkObjectResult(medicineBatchVm);
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
                _medicine_BatchService.Delete(id);
                _medicine_BatchService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}