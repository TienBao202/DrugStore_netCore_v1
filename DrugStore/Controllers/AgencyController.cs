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
    public class AgencyController : Controller
    {
        IAgency_Service _agencyService;

        public AgencyController(IAgency_Service agency_Service)
        {
            this._agencyService = agency_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _agencyService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _agencyService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _agencyService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]AgencyViewModel agencyVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _agencyService.Add(agencyVm);
            _agencyService.SaveChanges();
            return new OkObjectResult(agencyVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]AgencyViewModel agencyVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _agencyService.Update(agencyVm);
            _agencyService.SaveChanges();
            return new OkObjectResult(agencyVm);
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
                _agencyService.Delete(id);
                _agencyService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}