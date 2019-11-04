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
    public class InvoiceViewModel 
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Invoice_Code { set; get; }

        public decimal Total_Price { set; get; }

        [DefaultValue(0)]
        public float? Discount { set; get; }

        public decimal Customer_Pays { set; get; }

        public decimal Return_Customer { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Customer { set; get; }

        public int ID_Agency { set; get; }

        public  CustomerViewModel Customers { set; get; }

        public  AgencyViewModel Agency { set; get; }

        public ICollection<Invoice_DetailViewModel> Invoice_Details { set; get; }
    }
}
