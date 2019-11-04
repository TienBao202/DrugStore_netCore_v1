using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrugStore.Application.Interfaces;
using DrugStore.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrugStore.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        ICustomer_Service _customerService;

        public CustomerController(ICustomer_Service customer_Service)
        {
            this._customerService = customer_Service;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _customerService.GetAll();
            return new OkObjectResult(model);
        }  
    }
}
