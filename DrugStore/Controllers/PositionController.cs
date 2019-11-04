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
    public class PositionController : Controller
    {
        IPosition_Service _positionService;

        public PositionController(IPosition_Service positionService)
        {
            this._positionService = positionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _positionService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _positionService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _positionService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreatePosition([FromBody]PositionViewModel PositionVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _positionService.Add(PositionVm);
            _positionService.SaveChanges();
            return new OkObjectResult(PositionVm);
        }

        [HttpPut]
        public IActionResult UpdatePosition([FromBody]PositionViewModel PositionVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _positionService.Update(PositionVm);
            _positionService.SaveChanges();
            return new OkObjectResult(PositionVm);
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
                _positionService.Delete(id);
                _positionService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}