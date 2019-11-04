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
    public class AccountController : Controller
    {
        IAccount_Service _accountService;

        public AccountController(IAccount_Service account_Service)
        {
            this._accountService = account_Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _accountService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string status, string keyword, int page, int pageSize)
        {
            var model = _accountService.GetAllPaging(status, keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _accountService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult Create([FromBody]AccountViewModel accountVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _accountService.Add(accountVm);
            _accountService.SaveChanges();
            return new OkObjectResult(accountVm);
        }

        [HttpPut]
        public IActionResult Update([FromBody]AccountViewModel accountVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _accountService.Update(accountVm);
            _accountService.SaveChanges();
            return new OkObjectResult(accountVm);
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
                _accountService.Delete(id);
                _accountService.SaveChanges();

                return new OkObjectResult(id);
            }
        }


    }
}