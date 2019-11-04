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
    public class MedicineController : Controller
    {
        IMedicine_Service _medicineService;

        public MedicineController(IMedicine_Service medicine_Service)
        {
            this._medicineService = medicine_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _medicineService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _medicineService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _medicineService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateMedicine([FromBody]MedicineViewModel MedicineVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineService.Add(MedicineVm);
            _medicineService.SaveChanges();
            return new OkObjectResult(MedicineVm);
        }

        [HttpPut]
        public IActionResult UpdateMedicine([FromBody]MedicineViewModel MedicineVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineService.Update(MedicineVm);
            _medicineService.SaveChanges();
            return new OkObjectResult(MedicineVm);
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
                _medicineService.Delete(id);
                _medicineService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}