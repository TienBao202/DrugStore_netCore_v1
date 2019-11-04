using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class SupplierViewModel
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Supplier_Code { set; get; }

        [Required]
        public string Supplier_Name { set; get; }

        public string Phone_Number { set; get; }

        public string Address { set; get; }

        public string Email { set; get; }

        public string Tax_Code { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Supplier_Group { set; get; }

        public Supplier_GroupViewModel Supplier_Groups { set; get; }

        public ICollection<Purchase_OrderViewModel> Purchase_Orders { set; get; }
    }
}
