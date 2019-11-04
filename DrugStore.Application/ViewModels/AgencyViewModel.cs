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
    public class AgencyViewModel : ISwitchable
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Agency_Code { set; get; }

        [Required]
        [StringLength(256)]
        public string Agency_Name { set; get; }

        public string Phone_Number { set; get; }

        public string Email { set; get; }

        public string Delegate_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public ICollection<EmployeeViewModel> Employees { set; get; }

        public ICollection<InvoiceViewModel> Invoices { set; get; }

        public ICollection<Purchase_OrderViewModel> Purchase_Orders { set; get; }
    }
}
