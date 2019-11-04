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
    public class InvoiceController : Controller
    {
        IInvoice_Service _invoiceService;

        public InvoiceController(IInvoice_Service invoiceService)
        {
            this._invoiceService = invoiceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _invoiceService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _invoiceService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _invoiceService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateMedicine([FromBody]InvoiceViewModel InvoiceVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _invoiceService.Add(InvoiceVm);
            _invoiceService.SaveChanges();
            return new OkObjectResult(InvoiceVm);
        }

        [HttpPut]
        public IActionResult UpdateMedicine([FromBody]InvoiceViewModel InvoiceVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _invoiceService.Update(InvoiceVm);
            _invoiceService.SaveChanges();
            return new OkObjectResult(InvoiceVm);
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
                _invoiceService.Delete(id);
                _invoiceService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}