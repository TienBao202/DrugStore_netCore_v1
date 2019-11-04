using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;
using DrugStore.Infrastructure.SharedKernel;


namespace DrugStore.Application.ViewModels
{
    public class Invoice_DetailViewModel
    {
        public int ID { set; get; }

        public int ID_Invoice { set; get; }

        public int ID_Medicine { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public Status Status { set; get; }

        public  InvoiceViewModel Invoices { set; get; }

        public  MedicineViewModel Medicines { set; get; }


    }
}
