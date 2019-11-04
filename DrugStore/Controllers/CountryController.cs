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
    public class CountryController : Controller
    {
        ICountry_Service _countryService;

        public CountryController(ICountry_Service country_Service)
        {
            this._countryService = country_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _countryService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _countryService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _countryService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]CountryViewModel countryVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _countryService.Add(countryVm);
            _countryService.SaveChanges();
            return new OkObjectResult(countryVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]CountryViewModel countryVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _countryService.Update(countryVm);
            _countryService.SaveChanges();
            return new OkObjectResult(countryVm);
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
                _countryService.Delete(id);
                _countryService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}