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
    public class Medicine_UnitController : Controller
    {
        IMedicine_Unit_Service _medicineUnitService;

        public Medicine_UnitController(IMedicine_Unit_Service medicineUnitService)
        {
            this._medicineUnitService = medicineUnitService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _medicineUnitService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _medicineUnitService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _medicineUnitService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Medicine_UnitViewModel medicineUnitVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineUnitService.Add(medicineUnitVm);
            _medicineUnitService.SaveChanges();
            return new OkObjectResult(medicineUnitVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Medicine_UnitViewModel medicineUnitVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _medicineUnitService.Update(medicineUnitVm);
            _medicineUnitService.SaveChanges();
            return new OkObjectResult(medicineUnitVm);
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
                _medicineUnitService.Delete(id);
                _medicineUnitService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}