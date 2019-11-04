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
    public class InvoiceDetailController : Controller
    {
        IInvoice_Detail_Service _invoiceDetailService;

        public InvoiceDetailController(IInvoice_Detail_Service invoiceDetailService)
        {
            this._invoiceDetailService = invoiceDetailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var model = _invoiceDetailService.GetAll();
            return new OkObjectResult(model);
        }


        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _invoiceDetailService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _invoiceDetailService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult CreateMedicine([FromBody]Invoice_DetailViewModel invoiceDetailVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _invoiceDetailService.Add(invoiceDetailVm);
            _invoiceDetailService.SaveChanges();
            return new OkObjectResult(invoiceDetailVm);
        }

        [HttpPut]
        public IActionResult UpdateMedicine([FromBody]Invoice_DetailViewModel invoiceDetailVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            _invoiceDetailService.Update(invoiceDetailVm);
            _invoiceDetailService.SaveChanges();
            return new OkObjectResult(invoiceDetailVm);
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
                _invoiceDetailService.Delete(id);
                _invoiceDetailService.SaveChanges();

                return new OkObjectResult(id);
            }
        }
    }
}